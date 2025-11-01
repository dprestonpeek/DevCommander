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

        static NotifyIcon notifyIcon = new NotifyIcon();
        static ContextMenuStrip commandMenu = new ContextMenuStrip();
        static EditCommands editCmdsWindow;

        static string currentSelected = "";
        static bool editingCommands = false;

        //4 Digit Version Number: Major.minor-fixx
        // 0.2-00 would be 200. 1.4.13 would be 1413.
        public static int version = 300;
        public static string versionNumStr = "0.3-00";
        public static string lilVersionStr = "Alpha Version " + versionNumStr;
        public static string versionStr = "Alpha Version " + versionNumStr + "  |  Released November 1st, 2025";

        static void Main(string[] args)
        {
            UpdatePatching.VersionBasedUpdate();

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

        #region SaveLoad
        public static void SaveCommands()
        {
            string saveText = "";
            foreach (Command cmd in Commands.commandList)
            {
                saveText += cmd.displayText + "~" + cmd.commandText + "~" + cmd.togglable + "~" + cmd.runsHidden;
                if (cmd.displayText != Commands.commandList[Commands.commandList.Count - 1].displayText)
                {
                    saveText += "~";
                }
            }
            File.WriteAllText(cmdFile, saveText);
        }

        public static void LoadCommands()
        {
            string commandText = File.ReadAllText(cmdFile);
            string[] commands = commandText.Split('~');
            for (int i = 0; i < commands.Length - 1; i += 4)
            {
                try
                {
                    Commands.commandList.Add(new Command(commands[i], commands[i + 1], bool.Parse(commands[i + 2]), bool.Parse(commands[i + 3])));
                }
                catch(Exception ex)
                {
                    UpdatePatching.ForceUpdate();
                }
            }
        }
        #endregion

        #region Re-Parenting Functions
        public static string GetPrefix(string text)
        {
            string prefix = text.Substring(0, 2);
            int extraBraces = 0;
            if (!string.IsNullOrEmpty(prefix))
            {
                if (prefix == "><")
                {
                    for (int i = 2; i < text.Length; i++)
                    {
                        if (text[i] == '<')
                        {
                            extraBraces++;
                        }
                    }
                }
            }
            for (int i = 0; i < extraBraces; i++)
            {
                prefix += "<";
            }
            return prefix;
        }

        public static string MakeParent(string displayText)
        {
            string newname = displayText;
            foreach (Command cmd in Commands.commandList)
            {
                if (cmd.displayText == displayText)
                {
                    cmd.displayText = ">>" + displayText;
                    newname = cmd.displayText;
                }
            }
            SaveCommands();
            return newname;
        }

        public static string DemakeParent(string displayText)
        {
            string newname = displayText;
            foreach (Command cmd in Commands.commandList)
            {
                if (cmd.displayText == displayText)
                {
                    cmd.displayText = cmd.displayText.Replace(">>", "");
                    newname = cmd.displayText;
                }
            }
            SaveCommands();
            return newname;
        }

        public static string MakeSibling(string displayText)
        {
            string newname = displayText;
            foreach (Command cmd in Commands.commandList)
            {
                if (cmd.displayText == displayText)
                {
                    cmd.displayText = "><" + displayText;
                    newname = cmd.displayText;
                }
            }
            SaveCommands();
            return newname;
        }

        public static string AddBrace(string displayText)
        {
            string newname = displayText;
            foreach (Command cmd in Commands.commandList)
            {
                if (cmd.displayText == displayText)
                {
                    cmd.displayText = cmd.displayText.Insert(2, "<");
                    newname = cmd.displayText;
                }
            }
            SaveCommands();
            return newname;
        }

        public static string SubtractBrace(string displayText)
        {
            string newname = displayText;
            foreach (Command cmd in Commands.commandList)
            {
                if (cmd.displayText == displayText)
                {
                    if (cmd.displayText[2] == '<')
                    {
                        cmd.displayText = cmd.displayText.Remove(2, 1);
                        newname = cmd.displayText;
                    }
                }
            }
            SaveCommands();
            return newname;
        }

        public static string DemakeSibling(string displayText)
        {
            string newname = "";
            foreach (Command cmd in Commands.commandList)
            {
                if (cmd.displayText == displayText)
                {
                    cmd.displayText = cmd.displayText.Replace("><", "");
                    newname = cmd.displayText;
                }
            }
            SaveCommands();
            return newname;
        }

        public static string TurnParentIntoSibling(string displayText)
        {
            string newname = "";
            foreach (Command cmd in Commands.commandList)
            {
                if (cmd.displayText == displayText)
                {
                    cmd.displayText = cmd.displayText.Replace(">>", "><");
                    newname = cmd.displayText;
                }
            }
            SaveCommands();
            return newname;
        }

        public static string TurnSiblingIntoParent(string displayText)
        {
            string newname = "";
            foreach (Command cmd in Commands.commandList)
            {
                if (cmd.displayText == displayText)
                {
                    cmd.displayText = cmd.displayText.Replace("><", ">>");
                    newname = cmd.displayText;
                }
            }
            SaveCommands();
            return newname;
        }

        public static bool ParentsExistAbove(string displayText)
        {
            bool exists = false;
            foreach (Command cmd in Commands.commandList)
            {
                if (cmd.displayText.Substring(0, 2) == ">>")
                {
                    exists = true;
                }
                if (cmd.displayText == displayText)
                {
                    break;
                }
            }
            return exists;
        }

        public static bool GrandParentsExistBelow(string displayText)
        {
            bool exists = false;
            foreach (Command cmd in Commands.commandList)
            {
                if (cmd.displayText.Substring(0, 3) == "><<")
                {
                    exists = true;
                }
                if (cmd.displayText == displayText)
                {
                    break;
                }
            }
            return exists;
        }

        public static List<Command> GetGrandParentsBelow(string displayText)
        {
            List<Command> grandParents = new List<Command>();
            bool currNodeFound = false;
            foreach (Command cmd in Commands.commandList)
            {
                if (!currNodeFound)
                {
                    if (cmd.displayText != displayText)
                    {
                        continue;
                    }
                    else
                    {
                        currNodeFound = true;
                        continue;
                    }
                }

                if (GetPrefix(cmd.displayText) == "><<")
                {
                    grandParents.Add(cmd);
                }
            }
            return grandParents;
        }

        public static bool SiblingsExistBelow(string displayText)
        {
            bool exists = false;
            foreach (Command cmd in Commands.commandList)
            {

                if (GetPrefix(cmd.displayText) == "><")
                {
                    exists = true;
                }
                if (cmd.displayText == displayText)
                {
                    break;
                }
            }
            return exists;
        }

        public static List<Command> GetSiblingsBelow(string displayText)
        {
            List<Command> siblings = new List<Command>();
            bool currNodeFound = false;
            foreach (Command cmd in Commands.commandList)
            {
                if (!currNodeFound)
                {
                    if (cmd.displayText != displayText)
                    {
                        continue;
                    }
                    else
                    {
                        currNodeFound = true;
                        continue;
                    }
                }

                if (GetPrefix(cmd.displayText) == "><")
                {
                    siblings.Add(cmd);
                }
            }
            return siblings;
        }
        #endregion
    }

    #region OpenWindowGetter
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
#endregion