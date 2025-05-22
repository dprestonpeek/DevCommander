using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DevCommander
{
    internal class Features
    {
        public static Features Instance;
        public static bool pToggle;
        public static bool pCall;

        public static string ApplyFeatures(string commandText)
        {
            pToggle = CheckForpToggle(commandText);
            while (CheckForpCall(commandText))
            {
                commandText = ReplaceCommand(commandText);
            }
            return commandText;
        }

        public static bool CheckForpToggle(string commandText)
        {
            bool haspToggle = false;
            if (commandText.Contains("::pToggle"))
            {
                haspToggle = true;
            }
            return haspToggle;
        }

        public static bool CheckForpCall(string commandText)
        {
            string pattern = "[?:][?:][?p][?C][?a][?l][?l][?`].+[?`]";
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(commandText);
            if (matches.Count > 0)
            {
                string command = matches[0].Value.Substring(8, matches[0].Value.Length - 9);
                return true;
            }
            return false;
        }

        public static string ReplaceCommand(string commandText)
        {
            string pattern = "[?:][?:][?p][?C][?a][?l][?l][?`].+[?`]";
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(commandText);
            if (matches.Count > 0)
            {
                string match = matches[0].Value;
                string command = matches[0].Value.Substring(8, matches[0].Value.Length - 9);
                string newCommandText = commandText.Replace(match, Commands.GetCommandByString(command).commandText + "\n");
                return newCommandText;
            }
            return commandText;
        }

    }
}
