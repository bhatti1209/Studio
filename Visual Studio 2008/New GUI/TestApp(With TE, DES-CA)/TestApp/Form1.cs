using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace TestApp
{
    public partial class Form1 : Form
    {
        string path;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("TextEncryption\\TextEncryption.exe");
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("DESAnalysis\\DESAnalysis.exe");
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("KDC\\KDC Server\\KDC Server.exe");
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("KDC\\KDC Client\\KDC Client.exe");
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("FileEncryption\\FileEncryption.exe");
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ServerSettings a = new ServerSettings();
            a.Show();
        }
    }
}