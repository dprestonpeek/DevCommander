namespace pPasswordCSharp
{
    public partial class pPassword : Form
    {
        public pPassword(string[] args)
        {
            InitializeComponent();

            // Check if any arguments were passed
            if (args.Length > 0)
            {
                string action = args[0];
                Clipboard.SetText(action.Substring(0, action.Length));
            }
            else
            {
                Clipboard.SetText(GeneratePassword());
            }
            Environment.Exit(0);
        }

        string GeneratePassword()
        {
            string password = "";
            int lowLetters = 0;
            int highLetters = 0;
            int digits = 0;
            int specials = 0;

            Random random = new Random();
            for (int i = 0; i < 16; i++)
            {
                char code = (char)(random.Next() % 94 + 33);
                char next = code;

                if (code >= 48 && code <= 57 && digits < 5)
                {
                    password += next;
                    digits++;
                }
                else if (code >= 64 && code <= 90 && highLetters < 4)
                {
                    password += next;
                    highLetters++;
                }
                else if (code >= 97 && code <= 122 && lowLetters < 4)
                {
                    password += next;
                    lowLetters++;
                }
                else if (((code == 33) || (code >= 35 && code <= 43) || (code >= 45 && code <= 47)) && specials < 4)
                {
                    password += next;
                    specials++;
                }
                else
                {
                    i--;
                }
            }

            return password;
        }
    }
}
