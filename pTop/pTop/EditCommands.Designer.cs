
namespace DevCommander
{
    partial class EditCommands
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditCommands));
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            CommandTextBox = new System.Windows.Forms.RichTextBox();
            DisplayTextBox = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            OKButton = new System.Windows.Forms.Button();
            SaveButton = new System.Windows.Forms.Button();
            ReorderDown = new System.Windows.Forms.Button();
            ReorderUp = new System.Windows.Forms.Button();
            AddButton = new System.Windows.Forms.Button();
            DeleteButton = new System.Windows.Forms.Button();
            SaveChanges = new System.Windows.Forms.Label();
            FlashTimer = new System.Windows.Forms.Timer(components);
            HelpButton = new System.Windows.Forms.Button();
            RunButton = new System.Windows.Forms.Button();
            CommandTree = new System.Windows.Forms.TreeView();
            FolderButton = new System.Windows.Forms.Button();
            splitContainer1 = new System.Windows.Forms.SplitContainer();
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            openSourceFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            howToUseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(8, 26);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(72, 15);
            label1.TabIndex = 1;
            label1.Text = "Commands:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(12, 70);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(91, 15);
            label2.TabIndex = 8;
            label2.Text = "Command Text:";
            // 
            // CommandTextBox
            // 
            CommandTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            CommandTextBox.Enabled = false;
            CommandTextBox.Location = new System.Drawing.Point(12, 92);
            CommandTextBox.Name = "CommandTextBox";
            CommandTextBox.ShowSelectionMargin = true;
            CommandTextBox.Size = new System.Drawing.Size(277, 203);
            CommandTextBox.TabIndex = 1;
            CommandTextBox.Text = "";
            CommandTextBox.TextChanged += CommandTextBox_TextChanged;
            // 
            // DisplayTextBox
            // 
            DisplayTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            DisplayTextBox.Enabled = false;
            DisplayTextBox.Location = new System.Drawing.Point(12, 35);
            DisplayTextBox.Name = "DisplayTextBox";
            DisplayTextBox.Size = new System.Drawing.Size(277, 23);
            DisplayTextBox.TabIndex = 0;
            DisplayTextBox.TextChanged += DisplayTextBox_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(12, 14);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(72, 15);
            label3.TabIndex = 5;
            label3.Text = "Display Text:";
            // 
            // OKButton
            // 
            OKButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            OKButton.Location = new System.Drawing.Point(201, 301);
            OKButton.Name = "OKButton";
            OKButton.Size = new System.Drawing.Size(75, 23);
            OKButton.TabIndex = 11;
            OKButton.Text = "Close";
            OKButton.UseVisualStyleBackColor = true;
            OKButton.Click += OKButton_Click;
            // 
            // SaveButton
            // 
            SaveButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            SaveButton.Enabled = false;
            SaveButton.Location = new System.Drawing.Point(214, 301);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new System.Drawing.Size(75, 23);
            SaveButton.TabIndex = 3;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // ReorderDown
            // 
            ReorderDown.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            ReorderDown.Location = new System.Drawing.Point(162, 19);
            ReorderDown.Name = "ReorderDown";
            ReorderDown.Size = new System.Drawing.Size(23, 23);
            ReorderDown.TabIndex = 6;
            ReorderDown.Text = "↓";
            ReorderDown.UseVisualStyleBackColor = true;
            ReorderDown.Click += ReorderDown_Click;
            // 
            // ReorderUp
            // 
            ReorderUp.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            ReorderUp.Location = new System.Drawing.Point(187, 19);
            ReorderUp.Name = "ReorderUp";
            ReorderUp.Size = new System.Drawing.Size(23, 23);
            ReorderUp.TabIndex = 7;
            ReorderUp.Text = "↑";
            ReorderUp.UseVisualStyleBackColor = true;
            ReorderUp.Click += ReorderUp_Click;
            // 
            // AddButton
            // 
            AddButton.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            AddButton.Location = new System.Drawing.Point(253, 19);
            AddButton.Name = "AddButton";
            AddButton.Size = new System.Drawing.Size(23, 23);
            AddButton.TabIndex = 9;
            AddButton.Text = "+";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            DeleteButton.Location = new System.Drawing.Point(228, 19);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new System.Drawing.Size(23, 23);
            DeleteButton.TabIndex = 8;
            DeleteButton.Text = "-";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // SaveChanges
            // 
            SaveChanges.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            SaveChanges.AutoSize = true;
            SaveChanges.ForeColor = System.Drawing.Color.Red;
            SaveChanges.Location = new System.Drawing.Point(111, 305);
            SaveChanges.Name = "SaveChanges";
            SaveChanges.Size = new System.Drawing.Size(85, 15);
            SaveChanges.TabIndex = 16;
            SaveChanges.Text = "Save Changes?";
            SaveChanges.Visible = false;
            // 
            // FlashTimer
            // 
            FlashTimer.Interval = 10;
            // 
            // HelpButton
            // 
            HelpButton.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            HelpButton.Location = new System.Drawing.Point(214, 6);
            HelpButton.Name = "HelpButton";
            HelpButton.Size = new System.Drawing.Size(75, 23);
            HelpButton.TabIndex = 11;
            HelpButton.Text = "Help";
            HelpButton.UseVisualStyleBackColor = true;
            HelpButton.Visible = false;
            HelpButton.Click += HelpButton_Click;
            // 
            // RunButton
            // 
            RunButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            RunButton.Enabled = false;
            RunButton.Location = new System.Drawing.Point(12, 301);
            RunButton.Name = "RunButton";
            RunButton.Size = new System.Drawing.Size(75, 23);
            RunButton.TabIndex = 4;
            RunButton.Text = "Run";
            RunButton.UseVisualStyleBackColor = true;
            RunButton.Click += RunButton_Click;
            // 
            // CommandTree
            // 
            CommandTree.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            CommandTree.FullRowSelect = true;
            CommandTree.HideSelection = false;
            CommandTree.Location = new System.Drawing.Point(8, 48);
            CommandTree.Name = "CommandTree";
            CommandTree.Size = new System.Drawing.Size(268, 247);
            CommandTree.TabIndex = 5;
            CommandTree.AfterSelect += CommandTree_AfterSelect;
            // 
            // FolderButton
            // 
            FolderButton.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            FolderButton.Font = new System.Drawing.Font("Segoe UI Symbol", 9F);
            FolderButton.Location = new System.Drawing.Point(184, 6);
            FolderButton.Name = "FolderButton";
            FolderButton.Size = new System.Drawing.Size(24, 23);
            FolderButton.TabIndex = 10;
            FolderButton.Text = "🗀";
            FolderButton.UseVisualStyleBackColor = true;
            FolderButton.Visible = false;
            FolderButton.Click += FolderButton_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainer1.Location = new System.Drawing.Point(0, 24);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(label3);
            splitContainer1.Panel1.Controls.Add(FolderButton);
            splitContainer1.Panel1.Controls.Add(label2);
            splitContainer1.Panel1.Controls.Add(DisplayTextBox);
            splitContainer1.Panel1.Controls.Add(RunButton);
            splitContainer1.Panel1.Controls.Add(CommandTextBox);
            splitContainer1.Panel1.Controls.Add(HelpButton);
            splitContainer1.Panel1.Controls.Add(SaveButton);
            splitContainer1.Panel1MinSize = 200;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(label1);
            splitContainer1.Panel2.Controls.Add(CommandTree);
            splitContainer1.Panel2.Controls.Add(OKButton);
            splitContainer1.Panel2.Controls.Add(SaveChanges);
            splitContainer1.Panel2.Controls.Add(ReorderDown);
            splitContainer1.Panel2.Controls.Add(DeleteButton);
            splitContainer1.Panel2.Controls.Add(ReorderUp);
            splitContainer1.Panel2.Controls.Add(AddButton);
            splitContainer1.Panel2MinSize = 250;
            splitContainer1.Size = new System.Drawing.Size(575, 336);
            splitContainer1.SplitterDistance = 292;
            splitContainer1.TabIndex = 21;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { editToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(575, 24);
            menuStrip1.TabIndex = 22;
            menuStrip1.Text = "menuStrip1";
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { openSourceFolderToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            editToolStripMenuItem.Text = "Edit";
            // 
            // openSourceFolderToolStripMenuItem
            // 
            openSourceFolderToolStripMenuItem.Name = "openSourceFolderToolStripMenuItem";
            openSourceFolderToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            openSourceFolderToolStripMenuItem.Text = "Open Source Folder";
            openSourceFolderToolStripMenuItem.Click += openSourceFolderToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { howToUseToolStripMenuItem, aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            helpToolStripMenuItem.Text = "Help";
            // 
            // howToUseToolStripMenuItem
            // 
            howToUseToolStripMenuItem.Name = "howToUseToolStripMenuItem";
            howToUseToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            howToUseToolStripMenuItem.Text = "How to use...";
            howToUseToolStripMenuItem.Click += howToUseToolStripMenuItem_Click;
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            aboutToolStripMenuItem.Text = "About...";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // EditCommands
            // 
            AcceptButton = SaveButton;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(575, 360);
            Controls.Add(splitContainer1);
            Controls.Add(menuStrip1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            MainMenuStrip = menuStrip1;
            Name = "EditCommands";
            Text = "Edit commands - DevCommander v0.1";
            Load += EditCommands_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.RichTextBox CommandTextBox;
        public System.Windows.Forms.TextBox DisplayTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button ReorderDown;
        private System.Windows.Forms.Button ReorderUp;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Label SaveChanges;
        public System.Windows.Forms.Timer FlashTimer;
        private System.Windows.Forms.Button HelpButton;
        private System.Windows.Forms.Button RunButton;
        public System.Windows.Forms.TreeView CommandTree;
        private System.Windows.Forms.Button FolderButton;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openSourceFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem howToUseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}