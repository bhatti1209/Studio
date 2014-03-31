using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace testdb
{
    public partial class Form1 : Form
    {
        public Form1(string username)
        {
            InitializeComponent();
            logInToolStripMenuItem1.Text = username;
        }

        private void studentToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Student formstudent = new Student();
            formstudent.MdiParent = this;
            formstudent.Show();
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void browseCourseDetailsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            BrowseCourse formbrcor = new BrowseCourse();
            formbrcor.MdiParent = this;
            formbrcor.Show();
        }

        private void browseMarkSheetToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            BrowseMark formmark = new BrowseMark();
            formmark.MdiParent = this;
            formmark.Show();
        }

        private void studentToolStripMenuItem2_Click_1(object sender, EventArgs e)
        {
            SearchCD formsrcd = new SearchCD();
            formsrcd.MdiParent = this;
            formsrcd.Show();
        }

        private void studentMarksheetToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Marksheet formmark = new Marksheet();
            formmark.MdiParent = this;
            formmark.Show();
        }

        private void logInToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            login formlog = new login();
            formlog.MdiParent = this;
            formlog.Show();
        }

        private void markSheetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchMS formms = new SearchMS();
            formms.MdiParent = this;
            formms.Show();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePassAdmin formadminpasschg = new ChangePassAdmin();
            formadminpasschg.MdiParent = this;
            formadminpasschg.Show();
        }

        private void logOffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void createNewAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Adduser formadd = new Adduser();
            formadd.MdiParent = this;
            formadd.Show();
        }

        private void manageAdminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageAdmin a = new ManageAdmin();
            a.MdiParent = this;
            a.Show();
        }

        private void manageStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageStudent b = new ManageStudent();
            b.MdiParent = this;
            b.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}