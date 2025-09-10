using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevCommander
{
    public partial class Popup : Form
    {
        public string Response = "";

        string title = "Title";
        string message = "Message";
        int responseButtons = 0;
        string buttonText = "Yes,No,Cancel";

        public Popup(string title, string message, int responseButtons)
        {
            InitializeComponent();
            this.title = title;
            this.message = message;
            this.responseButtons = responseButtons;
        }

        public Popup(string title, string message, int responseButtons, string buttonText)
        {
            InitializeComponent();
            this.title = title;
            this.message = message;
            this.responseButtons = responseButtons;
            this.buttonText = buttonText;
        }

        //button text should be separated by commas
        public string GetDialogResponse()
        {
            string[] buttons = buttonText.Split(',');
            Text = title;
            messageLabel.Text = message;

            if (responseButtons == 1)
            {
                MiddleButton.Text = buttonText;
                RightButton.Visible = false;
                LeftButton.Visible = false;
            }
            if (responseButtons == 2)
            {
                LeftButton.Text = buttons[0];
                MiddleButton.Visible = false;
                RightButton.Text = buttons[1];
            }
            if (responseButtons == 3)
            {
                LeftButton.Text = buttons[0];
                MiddleButton.Text = buttons[1];
                RightButton.Text = buttons[2];
            }

            ShowDialog();
            return Response;
        }

        private void LeftButton_Click(object sender, EventArgs e)
        {
            Response = LeftButton.Text;
            Close();
        }

        private void MiddleButton_Click(object sender, EventArgs e)
        {
            Response = MiddleButton.Text;
            Close();
        }

        private void RightButton_Click(object sender, EventArgs e)
        {
            Response = RightButton.Text;
            Close();
        }
    }
}
