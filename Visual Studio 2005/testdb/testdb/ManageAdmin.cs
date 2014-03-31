using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace testdb
{
    public partial class ManageAdmin : Form
    {
        public ManageAdmin()
        {
            InitializeComponent();
        }

        private void loginAdminBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.loginAdminBindingSource.EndEdit();
            this.loginAdminTableAdapter.Update(this.loginDataSet.LoginAdmin);

        }

        private void ManageAdmin_Load(object sender, EventArgs e)
        {
            loginIDTextBox.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            loginAdminTableAdapter.FillByDelADmin(loginDataSet.LoginAdmin, loginidbox.Text);

            if (loginidbox.Text == "")
                MessageBox.Show("Username Not Present");
            else
            {
                loginAdminTableAdapter.UpdateAdmin("hello123", loginidbox.Text);
                MessageBox.Show("Password Changed To : 'hello123'");
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loginAdminTableAdapter.FillByDelADmin(loginDataSet.LoginAdmin, usernamebox.Text);

            if (loginIDTextBox.Text == "")
                MessageBox.Show("Login Not Present");
            else
            {
                loginAdminTableAdapter.DeleteDelAdmin(usernamebox.Text);
                MessageBox.Show("User Deleted !!");
                this.Close();
            }
                
        }
    }
}