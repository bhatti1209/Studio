using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KDC_Server
{
    public partial class Mainpage : Form
    {
        Form1 login;
        string loginname;

        public Mainpage(Form1 a, string name)
        {
            InitializeComponent();
            login = a;
            toolStripMenuItem2.Text = name;
            loginname = name;
        }

        private void Mainpage_FormClosing(object sender, FormClosingEventArgs e)
        {
            login.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
            System.Environment.Exit(System.Environment.ExitCode);
        }

        private void newUserToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            NewUser a = new NewUser();
            a.MdiParent = this;
            a.Show();
        }

        private void newUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePassword a = new ChangePassword();
            a.MdiParent = this;
            a.Show();
        }

        private void runServerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KDCServer a = new KDCServer();
            a.MdiParent = this;
            a.WindowState = FormWindowState.Maximized;
            a.Show();
        }

        private void changeKeyPairsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeKeyPairs a = new ChangeKeyPairs(loginname);
            a.MdiParent = this;
            a.Show();
        }

        private void requestsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateKeys a = new UpdateKeys();
            a.MdiParent = this;
            a.Show();
        }
    }
}