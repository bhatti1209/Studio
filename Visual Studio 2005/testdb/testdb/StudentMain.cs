using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace testdb
{
    public partial class StudentMain : Form
    {
        public StudentMain(string username)
        {
            InitializeComponent();
            toolStripMenuItem2.Text = username;
        }

        private void StudentMain_Load(object sender, EventArgs e)
        {

        }

        private void logOffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePassStudent c = new ChangePassStudent();
            c.MdiParent = this;
            c.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void browseCoursesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BrowseCourseStud b = new BrowseCourseStud(toolStripMenuItem2.Text);
            b.MdiParent = this;
            b.Show();
        }

        private void browseMarkSheetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BrowseMarkStud n = new BrowseMarkStud(toolStripMenuItem2.Text);
            n.MdiParent = this;
            n.Show();
        }
    }
}