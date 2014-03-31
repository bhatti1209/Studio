using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;

namespace KDC_Client
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

            KDCDataSetTableAdapters.LoginClientTableAdapter a = new KDC_Client.KDCDataSetTableAdapters.LoginClientTableAdapter();
            int counter = (int)a.VerifyLogin(loginidbox.Text, hash);

            if (counter == 1)
            {
                
                //loading the xml files for the logged in user
                KDCDataSetTableAdapters.KeyDirectoryTableAdapter b = new KDC_Client.KDCDataSetTableAdapters.KeyDirectoryTableAdapter();

                int count = (int)b.CheckUser(username);

                if (count == 1)
                {
                    byte[] data1 = (byte[])b.GetUserKey(username);
                    byte[] data2 = (byte[])b.GetPrivateKey(username);

                    char[] keytemp = Encoding.UTF8.GetChars(data1);
                    string keyxml = "";
                    for (int y = 0; y < keytemp.Length; y++)
                        keyxml += Convert.ToString(keytemp[y]);

                    StreamWriter writer = new StreamWriter("KDC\\KDC Client\\KDCPublicOnlyKey.xml");
                    string publicOnlyKeyXML = keyxml;
                    writer.Write(publicOnlyKeyXML);
                    writer.Close();

                    char[] keytemp1 = Encoding.UTF8.GetChars(data2);
                    string keyxml1 = "";
                    for (int y1 = 0; y1 < keytemp1.Length; y1++)
                        keyxml1 += Convert.ToString(keytemp1[y1]);

                    StreamWriter writer1 = new StreamWriter("KDC\\KDC Client\\KDCPublicPrivateKey.xml");
                    string publicOnlyKeyXML1 = keyxml1;
                    writer1.Write(publicOnlyKeyXML1);
                    writer1.Close();
                }
                else
                {
                    //erasing exsisting xml files if no key is availble
                    FileStream publiconlykeyfile = new FileStream("KDC\\KDC Client\\KDCPublicOnlyKey.xml", FileMode.Create, FileAccess.Write);
                    publiconlykeyfile.Close();
                    FileStream publicprivatekeyfile = new FileStream("KDC\\KDC Client\\KDCPublicPrivateKey.xml", FileMode.Create, FileAccess.Write);
                    publicprivatekeyfile.Close();
                }

                //open new form
                Mainpage a1 = new Mainpage(this, username);
                a1.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Wrong Username/Password");

            /*string username = "temp";

            Mainpage a = new Mainpage(this, username);
            a.Show();
            this.Hide();*/
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

            KDC_Client.Properties.Settings.Default["KDCConnectionString"] = "Data Source=" + servername + ";Initial Catalog=KDC;User ID=bharat123;Password=asd";
        }
    }
}