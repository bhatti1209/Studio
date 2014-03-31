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
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (loginnamebox.Text == "")
                MessageBox.Show("Please Enter Username");
            else
            {
                if (oldpassbox.Text == "")
                    MessageBox.Show("Please Enter Old Password");
                else
                {
                    if (passbox1.Text != passbox2.Text)
                        MessageBox.Show("Please Confirm The Entered Passwords");
                    else
                    {
                        if (radioButton1.Checked == true)  //admin
                        {
                            KDCDataSetTableAdapters.LoginAdminTableAdapter a1 = new KDC_Server.KDCDataSetTableAdapters.LoginAdminTableAdapter();
                            byte[] pass = Encoding.UTF8.GetBytes(oldpassbox.Text);
                            SHA1 sha1 = new SHA1CryptoServiceProvider();
                            byte[] hash = sha1.ComputeHash(pass);
                            int count = (int)a1.VerifyLogin(loginnamebox.Text, hash);

                            if (count == 1)
                            {
                                pass = Encoding.UTF8.GetBytes(passbox1.Text);
                                hash = sha1.ComputeHash(pass);
                                a1.ChangePassword(hash, loginnamebox.Text);

                                MessageBox.Show("Password Changed");
                            }
                            else
                                MessageBox.Show("Wrong Username/Password");
                        }
                        else if (radioButton2.Checked == true) //client
                        {
                            KDCDataSetTableAdapters.LoginClientTableAdapter a1 = new KDC_Server.KDCDataSetTableAdapters.LoginClientTableAdapter();
                            byte[] pass = Encoding.UTF8.GetBytes(oldpassbox.Text);
                            SHA1 sha1 = new SHA1CryptoServiceProvider();
                            byte[] hash = sha1.ComputeHash(pass);
                            int count = (int)a1.VerifyLogin(loginnamebox.Text, hash);

                            if (count == 1)
                            {
                                pass = Encoding.UTF8.GetBytes(passbox1.Text);
                                hash = sha1.ComputeHash(pass);
                                a1.ChangePassword(hash, loginnamebox.Text);

                                MessageBox.Show("Password Changed");
                            }
                            else
                                MessageBox.Show("Wrong Username/Password");
                        }
                    }
                }
            }
        }
    }
}