using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevCommander
{
    internal class UpdatePatching
    {
        public static bool CheckVersion()
        {
            int programVersion = Program.version;
            int userVersion = 0;
            try
            {
                 userVersion = Properties.Settings.Default.version;
            }
            catch
            {
                userVersion = 0;
            }

            if (programVersion > userVersion)
            {
                if (userVersion <= 199 || userVersion == 0)
                {
                    // Add runsHidden data field to all entries as "false"
                    LoadCommands_Pre200();
                    //SaveCommands_Pre200();
                    Program.SaveCommands();
                    Properties.Settings.Default.version = programVersion;
                    Properties.Settings.Default.Save();
                }
                return true;
            }
            return false;
        }

        private static void LoadCommands_Pre200()
        {
            string cmdFile = "commands.txt";
            string commandText = File.ReadAllText(cmdFile);
            string[] commands = commandText.Split('~');
            for (int i = 0; i < commands.Length - 1; i += 3)
            {
                Commands.commandList.Add(new Command(commands[i], commands[i + 1], bool.Parse(commands[i + 2]), false));
            }
        }

        private static void SaveCommands_Pre200()
        {
            string cmdFile = "commands.txt";
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
    }
}
