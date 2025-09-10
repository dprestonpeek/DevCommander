namespace DevCommander
{
    partial class Popup
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Popup));
            messageLabel = new System.Windows.Forms.Label();
            MiddleButton = new System.Windows.Forms.Button();
            LeftButton = new System.Windows.Forms.Button();
            RightButton = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // messageLabel
            // 
            messageLabel.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            messageLabel.Location = new System.Drawing.Point(12, 9);
            messageLabel.Name = "messageLabel";
            messageLabel.Size = new System.Drawing.Size(422, 96);
            messageLabel.TabIndex = 0;
            messageLabel.Text = resources.GetString("messageLabel.Text");
            messageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MiddleButton
            // 
            MiddleButton.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            MiddleButton.Location = new System.Drawing.Point(184, 143);
            MiddleButton.Name = "MiddleButton";
            MiddleButton.Size = new System.Drawing.Size(75, 23);
            MiddleButton.TabIndex = 1;
            MiddleButton.Text = "OK";
            MiddleButton.UseVisualStyleBackColor = true;
            MiddleButton.Click += MiddleButton_Click;
            // 
            // LeftButton
            // 
            LeftButton.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            LeftButton.Location = new System.Drawing.Point(103, 143);
            LeftButton.Name = "LeftButton";
            LeftButton.Size = new System.Drawing.Size(75, 23);
            LeftButton.TabIndex = 2;
            LeftButton.Text = "Yes";
            LeftButton.UseVisualStyleBackColor = true;
            LeftButton.Click += LeftButton_Click;
            // 
            // RightButton
            // 
            RightButton.Location = new System.Drawing.Point(265, 143);
            RightButton.Name = "RightButton";
            RightButton.Size = new System.Drawing.Size(75, 23);
            RightButton.TabIndex = 3;
            RightButton.Text = "No";
            RightButton.UseVisualStyleBackColor = true;
            RightButton.Click += RightButton_Click;
            // 
            // Popup
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(446, 193);
            Controls.Add(RightButton);
            Controls.Add(LeftButton);
            Controls.Add(MiddleButton);
            Controls.Add(messageLabel);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Popup";
            SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            Text = "Title";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.Button MiddleButton;
        private System.Windows.Forms.Button LeftButton;
        private System.Windows.Forms.Button RightButton;
    }
}