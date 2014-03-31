using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace testdb
{
    public partial class ManageStudent : Form
    {
        public ManageStudent()
        {
            InitializeComponent();
        }

        private void loginStudentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.loginStudentBindingSource.EndEdit();
            this.loginStudentTableAdapter.Update(this.loginDataSet.LoginStudent);

        }

        private void ManageStudent_Load(object sender, EventArgs e)
        {
            loginIDTextBox.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loginStudentTableAdapter.FillByDelStudent(loginDataSet.LoginStudent, usernamebox.Text);

            if (loginIDTextBox.Text == "")
                MessageBox.Show("Username Not Present");
            else
            {
                loginStudentTableAdapter.DeleteStudent(usernamebox.Text);
                MessageBox.Show("User Deleted");
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            loginStudentTableAdapter.FillByDelStudent(loginDataSet.LoginStudent, loginidbox.Text);

            if (loginIDTextBox.Text == "")
                MessageBox.Show("Username Not Present");
            else
            {
                loginStudentTableAdapter.UpdateStudent("hello123", loginidbox.Text);
                MessageBox.Show("Password Changed To : 'hello123'");
                this.Close();
            }
        }
    }
}