using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace testdb
{
    public partial class ChangePassStudent : Form
    {
        public ChangePassStudent()
        {
            InitializeComponent();
        }

        private void loginStudentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.loginStudentBindingSource.EndEdit();
            this.loginStudentTableAdapter.Update(this.loginDataSet.LoginStudent);

        }

        private void ChangePassStudent_Load(object sender, EventArgs e)
        {
            loginIDTextBox.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (newpassbox.Text == renewpassbox.Text)
            {
                loginStudentTableAdapter.FillByConfirmPass(loginDataSet.LoginStudent, logininbox.Text, oldpassbox.Text);

                if (loginIDTextBox.Text == "")
                    MessageBox.Show("Wrong Password Provided");
                else
                {
                    loginStudentTableAdapter.UpdateStudent(newpassbox.Text, logininbox.Text);
                    MessageBox.Show("Password Changed");
                    this.Close();
                }
            }
            else
                MessageBox.Show("Re-Confirm Password Different");
        }
    }
}