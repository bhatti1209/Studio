using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;

namespace KDC_Server
{
    public partial class Form1 : Form
    {
        string servername;

        public Form1()
        {
            InitializeComponent();
        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
            string username = loginidbox.Text;
            byte[] mesg = Encoding.UTF8.GetBytes(passwordbox.Text);
            SHA1 sha1 = new SHA1CryptoServiceProvider();
            byte[] hash = sha1.ComputeHash(mesg);

            KDCDataSetTableAdapters.LoginAdminTableAdapter a = new KDC_Server.KDCDataSetTableAdapters.LoginAdminTableAdapter();
            int counter = (int)a.VerifyLogin(loginidbox.Text, hash);

            if (counter == 1)
            {
                Mainpage a1 = new Mainpage(this, username);
                a1.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Wrong Username/Password");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            StandAloneServer a = new StandAloneServer();
            a.Show();
            this.Hide();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
            System.Environment.Exit(System.Environment.ExitCode);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FileStream a = new FileStream("settings.txt", FileMode.OpenOrCreate, FileAccess.Read);
            int len = (int)a.Length;

            byte[] r = new byte[len];
            a.Read(r, 0, len);
            char[] t = Encoding.UTF8.GetChars(r);

            for (int q = 0; q < t.Length; q++)
                servername += Convert.ToString(t[q]);
            a.Close();

            KDC_Server.Properties.Settings.Default["KDCConnectionString"] = "Data Source=" + servername + ";Initial Catalog=KDC;User ID=bharat123;Password=asd";
        }
    }
}