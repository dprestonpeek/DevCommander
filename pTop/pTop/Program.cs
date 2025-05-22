using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Text;
using HWND = System.IntPtr;
using System.Drawing;
using System.Threading;
using System.IO;
using System.Reflection;

namespace DevCommander
{
    class Program
    {
        static string programName = "DevCommander";

        static string cmdFile = "commands.txt";

        static ManualResetEvent _quitEvent = new ManualResetEvent(false);
        static NotifyIcon notifyIcon = new NotifyIcon();
        static ContextMenuStrip commandMenu = new ContextMenuStrip();
        static ContextMenuStrip pTopMenu = new ContextMenuStrip();
        static EditCommands editCmdsWindow;

        static string currentSelected = "";
        static bool editingCommands = false;

        static void Main(string[] args)
        {
            bool hasArgs = false;
            string commandToRun = "";
            if (args.Length > 0)
            {
                //quick-run a command and then close
                commandToRun = args[0].Substring(1, args[0].Length - 1);
                hasArgs = true;
            }
            else
            {
                //long-run the program and minimize to tray
                notifyIcon.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
                notifyIcon.Visible = true;
                notifyIcon.Text = Application.ProductName;
                notifyIcon.MouseClick += OpenContextMenu;
                commandMenu.ShowCheckMargin = true;
            }

            //if commands exist, load them, else create new file
            if (File.Exists(cmdFile))
            {
                LoadCommands();
            }
            else
            {
                File.WriteAllText(cmdFile, "");
            }

            if (hasArgs)
            {
                Commands.FireCommandByString(commandToRun);
            }
            else
            {
                Application.Run();
            }

        }

        public static void LoadCommands()
        {
            string commandText = File.ReadAllText(cmdFile);
            string[] commands = commandText.Split('~');
            for (int i = 0; i < commands.Length - 1; i += 3)
            {
                Commands.commandList.Add(new Command(commands[i], commands[i + 1], bool.Parse(commands[i + 2])));
            }
        }

        public static void SaveCommands()
        {
            string saveText = "";
            foreach (Command cmd in Commands.commandList)
            {
                saveText += cmd.displayText + "~" + cmd.commandText + "~" + cmd.togglable;
                if (cmd.displayText != Commands.commandList[Commands.commandList.Count - 1].displayText)
                {
                    saveText += "~";
                }
            }
            File.WriteAllText(cmdFile, saveText);
        }

        private static void OpenContextMenu(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                notifyIcon.ContextMenuStrip = commandMenu;
                commandMenu.Items.Clear();
                ToolStripMenuItem lastItemAdded = null;
                List<ToolStripMenuItem> parents = new List<ToolStripMenuItem>();
                foreach (Command command in Commands.commandList)
                {
                    ToolStripMenuItem itemToAdd = null;
                    string displayName = command.displayText;
                    
                    //this is a new parent, but also close the current submenu
                    if (displayName != "" && displayName.Substring(0, 2).Equals("><"))
                    {
                        string braces = "><<";
                        int substringAdd = 0;
                        while (displayName.Contains(braces))
                        {
                            if (parents.Count > 0)
                            {
                                parents.RemoveAt(parents.Count - 1);
                                braces += "<";
                                substringAdd++;
                            }
                            else
                            {
                                return;
                            }
                        }

                        if (parents.Count > 0)
                        {
                            parents.RemoveAt(parents.Count - 1);
                            if (parents.Count > 0)
                            {
                                itemToAdd = (ToolStripMenuItem)parents[parents.Count - 1].DropDownItems.Add(displayName.Substring(2 + substringAdd));
                            }
                            else
                            {
                                itemToAdd = (ToolStripMenuItem)commandMenu.Items.Add(displayName.Substring(2 + substringAdd));
                            }
                            parents.Add(itemToAdd);
                        }
                    }
                    //this will be a new parent
                    else if (displayName != "" && displayName.Substring(0, 2).Equals(">>"))
                    {
                        if (parents.Count > 0)
                        {
                            itemToAdd = (ToolStripMenuItem)parents[parents.Count - 1].DropDownItems.Add(displayName.Substring(2));
                        }
                        else
                        {
                            itemToAdd = (ToolStripMenuItem)commandMenu.Items.Add(displayName.Substring(2));
                        }
                        parents.Add(itemToAdd);
                    }
                    else
                    {
                        if (parents.Count > 0)
                        {
                            itemToAdd = (ToolStripMenuItem)parents[parents.Count - 1].DropDownItems.Add(displayName);
                        }
                        else
                        {
                            itemToAdd = (ToolStripMenuItem)commandMenu.Items.Add(displayName);
                        }
                    }
                    if (itemToAdd != null)
                    {
                        itemToAdd.Click += ClickedItem;
                        itemToAdd.Checked = command.isOn;
                        lastItemAdded = itemToAdd;
                    }
                }
                ToolStripMenuItem divider = (ToolStripMenuItem)commandMenu.Items.Add("____________");
                divider.Enabled = false;
                ToolStripMenuItem editCommand = (ToolStripMenuItem)commandMenu.Items.Add("Edit Commands...");
                editCommand.Name = "Edit";
                editCommand.Click += ClickedItem;
                ToolStripMenuItem quit = (ToolStripMenuItem)commandMenu.Items.Add("Quit " + programName);
                quit.Name = "Quit";
                quit.Click += ClickedItem;

                MethodInfo mi = typeof(NotifyIcon).GetMethod("ShowContextMenu", BindingFlags.Instance | BindingFlags.NonPublic);
                mi.Invoke(notifyIcon, null);
            }
        }

        private static void ClickedItem(object sender, EventArgs e)
        {
            //Check if option was "Edit" or "Quit"
            ToolStripMenuItem option = (ToolStripMenuItem)sender;
            if (option.Name == "Edit")
            {
                if (!editingCommands)
                {
                    editingCommands = true;
                    editCmdsWindow = new EditCommands();
                    editCmdsWindow.ShowDialog();
                    editingCommands = false;
                }
                else
                {
                    editCmdsWindow.WindowState = FormWindowState.Normal;
                    editCmdsWindow.Focus();
                }
            }
            if (option.Name == "Quit")
            {
                Application.Exit();
                return;
            }

            //Fire using the Command obj
            foreach (Command command in Commands.commandList)
            {
                string displayName = command.displayText;
                if (displayName == option.Text)
                {
                    //Do command here
                    Commands.FireCommandByString(displayName);
                }
            }
        }

        private static bool IsSelected(string action)
        {
            if (currentSelected == action)
            {
                return true;
            }
            return false;
        }
    }

/// <summary>Contains functionality to get all the open windows.</summary>
public static class OpenWindowGetter
    {
        /// <summary>Returns a dictionary that contains the handle and title of all the open windows.</summary>
        /// <returns>A dictionary that contains the handle and title of all the open windows.</returns>
        public static IDictionary<HWND, string> GetOpenWindows()
        {
            HWND shellWindow = GetShellWindow();
            Dictionary<HWND, string> windows = new Dictionary<HWND, string>();

            EnumWindows(delegate (HWND hWnd, int lParam)
            {
                if (hWnd == shellWindow) return true;
                if (!IsWindowVisible(hWnd)) return true;

                int length = GetWindowTextLength(hWnd);
                if (length == 0) return true;

                StringBuilder builder = new StringBuilder(length);
                GetWindowText(hWnd, builder, length + 1);

                windows[hWnd] = builder.ToString();
                return true;

            }, 0);

            return windows;
        }

        private delegate bool EnumWindowsProc(HWND hWnd, int lParam);

        [DllImport("USER32.DLL")]
        private static extern bool EnumWindows(EnumWindowsProc enumFunc, int lParam);

        [DllImport("USER32.DLL")]
        private static extern int GetWindowText(HWND hWnd, StringBuilder lpString, int nMaxCount);

        [DllImport("USER32.DLL")]
        private static extern int GetWindowTextLength(HWND hWnd);

        [DllImport("USER32.DLL")]
        private static extern bool IsWindowVisible(HWND hWnd);

        [DllImport("USER32.DLL")]
        private static extern IntPtr GetShellWindow();
    }
}
