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
    public partial class ServerSettings : Form
    {
        public ServerSettings()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string server = servername.Text;

            FileStream a = new FileStream("settings.txt", FileMode.Create, FileAccess.Write);
            StreamWriter op = new StreamWriter(a);

            op.WriteLine(server);
            op.Close();
            a.Close();

            this.Close();
        }
    }
}