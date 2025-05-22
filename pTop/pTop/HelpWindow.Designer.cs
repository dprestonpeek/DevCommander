
namespace DevCommander
{
    partial class HelpWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpWindow));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Child Node");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Child Node");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Child Node");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode(">>Parent Node", new System.Windows.Forms.TreeNode[] { treeNode3 });
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Child Node");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("><Aunt Node", new System.Windows.Forms.TreeNode[] { treeNode5 });
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode(">>Parent Node (Root)", new System.Windows.Forms.TreeNode[] { treeNode1, treeNode2, treeNode4, treeNode6 });
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("><< Grand Node (Root)");
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            ExampleTree = new System.Windows.Forms.TreeView();
            tabControl1 = new System.Windows.Forms.TabControl();
            tabPage3 = new System.Windows.Forms.TabPage();
            label14 = new System.Windows.Forms.Label();
            label13 = new System.Windows.Forms.Label();
            tabPage1 = new System.Windows.Forms.TabPage();
            tabPage2 = new System.Windows.Forms.TabPage();
            label7 = new System.Windows.Forms.Label();
            label12 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            richTextBox1 = new System.Windows.Forms.RichTextBox();
            label3 = new System.Windows.Forms.Label();
            tabControl1.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(8, 12);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(388, 30);
            label1.TabIndex = 0;
            label1.Text = "Preceed the name of your command with one of these options.\r\nWhen adding nodes, the relationship context reads from top to bottom. ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(42, 65);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(361, 30);
            label2.TabIndex = 1;
            label2.Text = "Parent Node - This node is a \"parent\". All subsequent nodes will be \r\nChild Nodes unless otherwise specified.";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(8, 65);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(23, 15);
            label4.TabIndex = 3;
            label4.Text = ">>";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(8, 110);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(23, 15);
            label8.TabIndex = 7;
            label8.Text = "><";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(42, 110);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(370, 60);
            label9.TabIndex = 8;
            label9.Text = resources.GetString("label9.Text");
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(1, 186);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(40, 15);
            label10.TabIndex = 9;
            label10.Text = "><<...";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new System.Drawing.Point(42, 186);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(367, 75);
            label11.TabIndex = 10;
            label11.Text = resources.GetString("label11.Text");
            // 
            // ExampleTree
            // 
            ExampleTree.ItemHeight = 30;
            ExampleTree.Location = new System.Drawing.Point(423, 3);
            ExampleTree.Name = "ExampleTree";
            treeNode1.Name = "Node1";
            treeNode1.Text = "Child Node";
            treeNode2.Name = "Node2";
            treeNode2.Text = "Child Node";
            treeNode3.Name = "Node5";
            treeNode3.Text = "Child Node";
            treeNode4.Name = "Node4";
            treeNode4.Text = ">>Parent Node";
            treeNode5.Name = "Node6";
            treeNode5.Text = "Child Node";
            treeNode6.Name = "Node3";
            treeNode6.Text = "><Aunt Node";
            treeNode7.Name = "Node0";
            treeNode7.Text = ">>Parent Node (Root)";
            treeNode8.Name = "Node7";
            treeNode8.Text = "><< Grand Node (Root)";
            ExampleTree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] { treeNode7, treeNode8 });
            ExampleTree.Size = new System.Drawing.Size(214, 258);
            ExampleTree.TabIndex = 11;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new System.Drawing.Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new System.Drawing.Size(648, 302);
            tabControl1.TabIndex = 12;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(label14);
            tabPage3.Controls.Add(label13);
            tabPage3.Location = new System.Drawing.Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new System.Drawing.Size(640, 274);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Intro";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new System.Drawing.Point(3, 128);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(575, 135);
            label14.TabIndex = 1;
            label14.Text = resources.GetString("label14.Text");
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new System.Drawing.Point(3, 13);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(624, 105);
            label13.TabIndex = 0;
            label13.Text = resources.GetString("label13.Text");
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(ExampleTree);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label11);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label10);
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(label9);
            tabPage1.Location = new System.Drawing.Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new System.Windows.Forms.Padding(3);
            tabPage1.Size = new System.Drawing.Size(640, 274);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Nodes";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(label12);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(richTextBox1);
            tabPage2.Controls.Add(label3);
            tabPage2.Location = new System.Drawing.Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new System.Windows.Forms.Padding(3);
            tabPage2.Size = new System.Drawing.Size(640, 274);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Keywords";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(70, 142);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(256, 45);
            label7.TabIndex = 6;
            label7.Text = "Make use of the Call feature. When the above \r\nkeyword is detected, the specified script (in this\r\ncase, \"Example Function Name\" will execute.";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new System.Drawing.Point(6, 142);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(40, 15);
            label12.TabIndex = 5;
            label12.Text = "::pCall";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(70, 68);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(264, 45);
            label6.TabIndex = 4;
            label6.Text = "Make use of the Toggle feature. When the above \r\nkeyword is detected, the pScript menu item will\r\ntoggle its checkmark within the command list.";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(6, 68);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(55, 15);
            label5.TabIndex = 3;
            label5.Text = "::pToggle";
            // 
            // richTextBox1
            // 
            richTextBox1.Enabled = false;
            richTextBox1.Location = new System.Drawing.Point(360, 3);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new System.Drawing.Size(274, 265);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "echo \"this line is not important\"\n\n\n::pToggle\n\n\necho \"this line is not important\"\n\n\n::pCall`Example Function Name`";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(6, 12);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(319, 15);
            label3.TabIndex = 1;
            label3.Text = "Keywords can be used in scripts to execute special features.";
            // 
            // HelpWindow
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(677, 326);
            Controls.Add(tabControl1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "HelpWindow";
            Text = "Help - Dev Commander";
            tabControl1.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TreeView ExampleTree;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
    }
}