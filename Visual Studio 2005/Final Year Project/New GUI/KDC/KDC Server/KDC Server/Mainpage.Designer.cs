namespace KDC_Server
{
    partial class Mainpage
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.newUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newUserToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.changeKeyPairsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.requestsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.fileToolStripMenuItem,
            this.updatesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(696, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem1,
            this.newUserToolStripMenuItem,
            this.newUserToolStripMenuItem1});
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.loginToolStripMenuItem.Text = "&Login";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Enabled = false;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(171, 22);
            this.toolStripMenuItem2.Text = " ";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(168, 6);
            // 
            // newUserToolStripMenuItem
            // 
            this.newUserToolStripMenuItem.Name = "newUserToolStripMenuItem";
            this.newUserToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.newUserToolStripMenuItem.Text = "Change &Password";
            this.newUserToolStripMenuItem.Click += new System.EventHandler(this.newUserToolStripMenuItem_Click);
            // 
            // newUserToolStripMenuItem1
            // 
            this.newUserToolStripMenuItem1.Name = "newUserToolStripMenuItem1";
            this.newUserToolStripMenuItem1.Size = new System.Drawing.Size(171, 22);
            this.newUserToolStripMenuItem1.Text = "Create New &User";
            this.newUserToolStripMenuItem1.Click += new System.EventHandler(this.newUserToolStripMenuItem1_Click);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.runServerToolStripMenuItem,
            this.toolStripMenuItem3,
            this.changeKeyPairsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // runServerToolStripMenuItem
            // 
            this.runServerToolStripMenuItem.Name = "runServerToolStripMenuItem";
            this.runServerToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.runServerToolStripMenuItem.Text = "Run &Server";
            this.runServerToolStripMenuItem.Click += new System.EventHandler(this.runServerToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(166, 6);
            // 
            // changeKeyPairsToolStripMenuItem
            // 
            this.changeKeyPairsToolStripMenuItem.Name = "changeKeyPairsToolStripMenuItem";
            this.changeKeyPairsToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.changeKeyPairsToolStripMenuItem.Text = "Change &Key Pairs";
            this.changeKeyPairsToolStripMenuItem.Click += new System.EventHandler(this.changeKeyPairsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // updatesToolStripMenuItem
            // 
            this.updatesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.requestsToolStripMenuItem});
            this.updatesToolStripMenuItem.Name = "updatesToolStripMenuItem";
            this.updatesToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.updatesToolStripMenuItem.Text = "&Updates";
            // 
            // requestsToolStripMenuItem
            // 
            this.requestsToolStripMenuItem.Name = "requestsToolStripMenuItem";
            this.requestsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.requestsToolStripMenuItem.Text = "&Requests";
            this.requestsToolStripMenuItem.Click += new System.EventHandler(this.requestsToolStripMenuItem_Click);
            // 
            // Mainpage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 577);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Mainpage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mainpage";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Mainpage_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem newUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newUserToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runServerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem changeKeyPairsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem requestsToolStripMenuItem;
    }
}