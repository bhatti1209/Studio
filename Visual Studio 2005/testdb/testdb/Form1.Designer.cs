namespace testdb
{
    partial class Form1
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
            this.logInToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createNewAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageAdminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.logOffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentMarksheetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataBaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchDBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.markSheetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.browseCourseDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.browseMarkSheetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.fileToolStripMenuItem,
            this.dataBaseToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(556, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logInToolStripMenuItem1,
            this.changePasswordToolStripMenuItem,
            this.manageUsersToolStripMenuItem,
            this.toolStripMenuItem2,
            this.logOffToolStripMenuItem});
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.loginToolStripMenuItem.Text = "&Log In";
            // 
            // logInToolStripMenuItem1
            // 
            this.logInToolStripMenuItem1.Enabled = false;
            this.logInToolStripMenuItem1.Name = "logInToolStripMenuItem1";
            this.logInToolStripMenuItem1.Size = new System.Drawing.Size(176, 22);
            this.logInToolStripMenuItem1.Click += new System.EventHandler(this.logInToolStripMenuItem1_Click);
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // manageUsersToolStripMenuItem
            // 
            this.manageUsersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createNewAccountToolStripMenuItem,
            this.manageAdminToolStripMenuItem,
            this.manageStudentToolStripMenuItem});
            this.manageUsersToolStripMenuItem.Name = "manageUsersToolStripMenuItem";
            this.manageUsersToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.manageUsersToolStripMenuItem.Text = "Manage Users";
            // 
            // createNewAccountToolStripMenuItem
            // 
            this.createNewAccountToolStripMenuItem.Name = "createNewAccountToolStripMenuItem";
            this.createNewAccountToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.createNewAccountToolStripMenuItem.Text = "Create New Account";
            this.createNewAccountToolStripMenuItem.Click += new System.EventHandler(this.createNewAccountToolStripMenuItem_Click);
            // 
            // manageAdminToolStripMenuItem
            // 
            this.manageAdminToolStripMenuItem.Name = "manageAdminToolStripMenuItem";
            this.manageAdminToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.manageAdminToolStripMenuItem.Text = "Manage Admin";
            this.manageAdminToolStripMenuItem.Click += new System.EventHandler(this.manageAdminToolStripMenuItem_Click);
            // 
            // manageStudentToolStripMenuItem
            // 
            this.manageStudentToolStripMenuItem.Name = "manageStudentToolStripMenuItem";
            this.manageStudentToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.manageStudentToolStripMenuItem.Text = "Manage Student";
            this.manageStudentToolStripMenuItem.Click += new System.EventHandler(this.manageStudentToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(173, 6);
            // 
            // logOffToolStripMenuItem
            // 
            this.logOffToolStripMenuItem.Name = "logOffToolStripMenuItem";
            this.logOffToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.logOffToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.logOffToolStripMenuItem.Text = "Log Off";
            this.logOffToolStripMenuItem.Click += new System.EventHandler(this.logOffToolStripMenuItem_Click);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentToolStripMenuItem,
            this.studentMarksheetToolStripMenuItem});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // studentToolStripMenuItem
            // 
            this.studentToolStripMenuItem.Name = "studentToolStripMenuItem";
            this.studentToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.studentToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.studentToolStripMenuItem.Text = "Student Courses";
            this.studentToolStripMenuItem.Click += new System.EventHandler(this.studentToolStripMenuItem_Click_1);
            // 
            // studentMarksheetToolStripMenuItem
            // 
            this.studentMarksheetToolStripMenuItem.Name = "studentMarksheetToolStripMenuItem";
            this.studentMarksheetToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.studentMarksheetToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.studentMarksheetToolStripMenuItem.Text = "Student Marksheet";
            this.studentMarksheetToolStripMenuItem.Click += new System.EventHandler(this.studentMarksheetToolStripMenuItem_Click_1);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click_1);
            // 
            // dataBaseToolStripMenuItem
            // 
            this.dataBaseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchDBToolStripMenuItem,
            this.toolStripSeparator1,
            this.browseCourseDetailsToolStripMenuItem,
            this.browseMarkSheetToolStripMenuItem});
            this.dataBaseToolStripMenuItem.Name = "dataBaseToolStripMenuItem";
            this.dataBaseToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.dataBaseToolStripMenuItem.Text = "&DataBase";
            // 
            // searchDBToolStripMenuItem
            // 
            this.searchDBToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentToolStripMenuItem2,
            this.markSheetToolStripMenuItem});
            this.searchDBToolStripMenuItem.Name = "searchDBToolStripMenuItem";
            this.searchDBToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.searchDBToolStripMenuItem.Text = "Search DB";
            // 
            // studentToolStripMenuItem2
            // 
            this.studentToolStripMenuItem2.Name = "studentToolStripMenuItem2";
            this.studentToolStripMenuItem2.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.studentToolStripMenuItem2.Size = new System.Drawing.Size(210, 22);
            this.studentToolStripMenuItem2.Text = "Course Details";
            this.studentToolStripMenuItem2.Click += new System.EventHandler(this.studentToolStripMenuItem2_Click_1);
            // 
            // markSheetToolStripMenuItem
            // 
            this.markSheetToolStripMenuItem.Name = "markSheetToolStripMenuItem";
            this.markSheetToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift)
                        | System.Windows.Forms.Keys.S)));
            this.markSheetToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.markSheetToolStripMenuItem.Text = "MarkSheet";
            this.markSheetToolStripMenuItem.Click += new System.EventHandler(this.markSheetToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(195, 6);
            // 
            // browseCourseDetailsToolStripMenuItem
            // 
            this.browseCourseDetailsToolStripMenuItem.Name = "browseCourseDetailsToolStripMenuItem";
            this.browseCourseDetailsToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.browseCourseDetailsToolStripMenuItem.Text = "Browse Course Details";
            this.browseCourseDetailsToolStripMenuItem.Click += new System.EventHandler(this.browseCourseDetailsToolStripMenuItem_Click_1);
            // 
            // browseMarkSheetToolStripMenuItem
            // 
            this.browseMarkSheetToolStripMenuItem.Name = "browseMarkSheetToolStripMenuItem";
            this.browseMarkSheetToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.browseMarkSheetToolStripMenuItem.Text = "Browse MarkSheet";
            this.browseMarkSheetToolStripMenuItem.Click += new System.EventHandler(this.browseMarkSheetToolStripMenuItem_Click_1);
            // 
            // Form1
            // 
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 536);
            this.ControlBox = false;
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrator Menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem logInToolStripMenuItem1;
        public System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem studentToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem studentMarksheetToolStripMenuItem;
        public System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        public System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem dataBaseToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem searchDBToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem studentToolStripMenuItem2;
        public System.Windows.Forms.ToolStripMenuItem markSheetToolStripMenuItem;
        public System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        public System.Windows.Forms.ToolStripMenuItem browseCourseDetailsToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem browseMarkSheetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageUsersToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem logOffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createNewAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageAdminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageStudentToolStripMenuItem;
    }
}

