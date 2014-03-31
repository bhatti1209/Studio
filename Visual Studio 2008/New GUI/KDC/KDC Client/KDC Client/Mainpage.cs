using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KDC_Client
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

        private void chaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePassword a = new ChangePassword();
            a.MdiParent = this;
            a.Show();
        }

        private void changeKeyPairsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeKeyPairs a = new ChangeKeyPairs(loginname);
            a.MdiParent = this;
            a.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
            System.Environment.Exit(System.Environment.ExitCode);
        }

        private void runClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientConnect a = new ClientConnect(this);
            a.MdiParent = this;
            a.Show();
        }

        private void clientServerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientServer a = new ClientServer(this);
            a.MdiParent = this;
            a.Show();
        }

        private void clientConfigurationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings a = new Settings();
            a.MdiParent = this;
            a.Show();
        }
    }
}