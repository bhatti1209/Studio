using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace testdb
{
    public partial class ChangePassAdmin : Form
    {
        public ChangePassAdmin()
        {
            InitializeComponent();
        }

        private void loginAdminBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.loginAdminBindingSource.EndEdit();
            this.loginAdminTableAdapter.Update(this.loginDataSet.LoginAdmin);

        }

        private void ChangePassAdmin_Load(object sender, EventArgs e)
        {
            loginIDTextBox.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (newpassbox.Text == renewpassbox.Text)
            {
                loginAdminTableAdapter.FillByConfirmPass(loginDataSet.LoginAdmin, logininbox.Text, oldpassbox.Text);

                if (loginIDTextBox.Text=="")
                    MessageBox.Show("Wrong Password Provided");
                else
                {
                    loginAdminTableAdapter.UpdateAdmin(newpassbox.Text, logininbox.Text);
                    MessageBox.Show("Password Changed");
                    this.Close();
                }
            }
            else
                MessageBox.Show("Re-Confirm Password Different");
        }
    }
}