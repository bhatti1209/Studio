using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace KDC_Server
{
    public partial class NewUser : Form
    {
        public NewUser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (usernamebox.Text == "")
                MessageBox.Show("Please Enter Username");
            else
            {
                if (loginnamebox.Text == "")
                    MessageBox.Show("Please Enter Login ID");
                else
                {
                    if (passbox1.Text != passbox2.Text)
                        MessageBox.Show("Please Confirm The Password(s) Entered");
                    else
                    {
                        if (radioButton1.Checked == true)  //admin
                        {
                            KDCDataSetTableAdapters.LoginAdminTableAdapter a = new KDC_Server.KDCDataSetTableAdapters.LoginAdminTableAdapter();
                            byte[] pass = Encoding.UTF8.GetBytes(passbox1.Text);
                            SHA1 sha1 = new SHA1CryptoServiceProvider();
                            byte[] hash = sha1.ComputeHash(pass);

                            int count = (int)a.CheckLogin(loginnamebox.Text);

                            if (count == 0)
                            {
                                a.InsertAdmin(loginnamebox.Text, hash, usernamebox.Text);
                                MessageBox.Show("User Created");
                            }
                            else
                                MessageBox.Show("Login Name Taken, Enter Again");
                        }
                        else if (radioButton2.Checked == true) //client account
                        {
                            KDCDataSetTableAdapters.LoginClientTableAdapter b = new KDC_Server.KDCDataSetTableAdapters.LoginClientTableAdapter();
                            byte[] pass = Encoding.UTF8.GetBytes(passbox1.Text);
                            SHA1 sha1 = new SHA1CryptoServiceProvider();
                            byte[] hash = sha1.ComputeHash(pass);

                            int count = (int)b.CheckLogin(loginnamebox.Text);

                            if (count == 0)
                            {
                                b.InsertClient(loginnamebox.Text, hash, usernamebox.Text);
                                MessageBox.Show("User Created");
                            }
                            else
                                MessageBox.Show("Login Name Taken, Enter Again");
                        }
                    }
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (radioButton1.Checked == true)  //admin
            {
                KDCDataSetTableAdapters.LoginAdminTableAdapter a = new KDC_Server.KDCDataSetTableAdapters.LoginAdminTableAdapter();
                
                int count = (int)a.CheckLogin(loginnamebox.Text);

                if (count == 0)
                    MessageBox.Show("Login Name Available");
                else
                    MessageBox.Show("Login Name Taken");
            }
            else if (radioButton2.Checked == true) //client account
            {
                KDCDataSetTableAdapters.LoginClientTableAdapter b = new KDC_Server.KDCDataSetTableAdapters.LoginClientTableAdapter();
                
                int count = (int)b.CheckLogin(loginnamebox.Text);

                if (count == 0)
                    MessageBox.Show("Login Name Available");
                else
                    MessageBox.Show("Login Name Taken");
            }
        }
    }
}