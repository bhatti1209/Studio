using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace KDC_Client
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ipadd = textBox1.Text;

            FileStream a = new FileStream("KDC\\KDC Client\\config.txt", FileMode.Create, FileAccess.Write);
            StreamWriter op = new StreamWriter(a);

            op.WriteLine(ipadd);
            op.Close();
            a.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string timeoutmin = textBox2.Text;
            string timeoutsec = textBox3.Text;

            string temp = timeoutmin + " " + timeoutsec;

            FileStream a = new FileStream("KDC\\KDC Client\\timeout.txt", FileMode.Create, FileAccess.Write);
            StreamWriter op = new StreamWriter(a);

            op.WriteLine(temp);
            op.Close();
            a.Close();
        }
    }
}