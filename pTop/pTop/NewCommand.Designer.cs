
namespace DevCommander
{
    partial class NewCommand
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewCommand));
            label1 = new System.Windows.Forms.Label();
            DisplayTextBox = new System.Windows.Forms.TextBox();
            CommandTextBox = new System.Windows.Forms.RichTextBox();
            label2 = new System.Windows.Forms.Label();
            TogglableCheckbox = new System.Windows.Forms.CheckBox();
            CreateButton = new System.Windows.Forms.Button();
            theCancelButton = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(41, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(72, 15);
            label1.TabIndex = 0;
            label1.Text = "Display Text:";
            // 
            // DisplayTextBox
            // 
            DisplayTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            DisplayTextBox.Location = new System.Drawing.Point(139, 6);
            DisplayTextBox.Name = "DisplayTextBox";
            DisplayTextBox.Size = new System.Drawing.Size(343, 23);
            DisplayTextBox.TabIndex = 1;
            // 
            // CommandTextBox
            // 
            CommandTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            CommandTextBox.Location = new System.Drawing.Point(139, 35);
            CommandTextBox.Name = "CommandTextBox";
            CommandTextBox.Size = new System.Drawing.Size(343, 165);
            CommandTextBox.TabIndex = 2;
            CommandTextBox.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(22, 38);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(91, 15);
            label2.TabIndex = 3;
            label2.Text = "Command Text:";
            // 
            // TogglableCheckbox
            // 
            TogglableCheckbox.AutoSize = true;
            TogglableCheckbox.Location = new System.Drawing.Point(139, 209);
            TogglableCheckbox.Name = "TogglableCheckbox";
            TogglableCheckbox.Size = new System.Drawing.Size(165, 19);
            TogglableCheckbox.TabIndex = 4;
            TogglableCheckbox.Text = "This action can be toggled";
            TogglableCheckbox.UseVisualStyleBackColor = true;
            // 
            // CreateButton
            // 
            CreateButton.Location = new System.Drawing.Point(407, 206);
            CreateButton.Name = "CreateButton";
            CreateButton.Size = new System.Drawing.Size(75, 23);
            CreateButton.TabIndex = 5;
            CreateButton.Text = "Create";
            CreateButton.UseVisualStyleBackColor = true;
            CreateButton.Click += CreateButton_Click;
            // 
            // theCancelButton
            // 
            theCancelButton.Location = new System.Drawing.Point(326, 206);
            theCancelButton.Name = "theCancelButton";
            theCancelButton.Size = new System.Drawing.Size(75, 23);
            theCancelButton.TabIndex = 6;
            theCancelButton.Text = "Cancel";
            theCancelButton.UseVisualStyleBackColor = true;
            theCancelButton.Click += CancelButton_Click;
            // 
            // NewCommand
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(494, 233);
            Controls.Add(theCancelButton);
            Controls.Add(CreateButton);
            Controls.Add(TogglableCheckbox);
            Controls.Add(label2);
            Controls.Add(CommandTextBox);
            Controls.Add(DisplayTextBox);
            Controls.Add(label1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "NewCommand";
            Text = "New Command";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.Button theCancelButton;
        public System.Windows.Forms.TextBox DisplayTextBox;
        public System.Windows.Forms.RichTextBox CommandTextBox;
        public System.Windows.Forms.CheckBox TogglableCheckbox;
    }
}