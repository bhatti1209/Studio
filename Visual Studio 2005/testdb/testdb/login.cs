using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace testdb
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (selectuser.Text == "Administrator")
            {
                loginAdminTableAdapter.FillBySearchAdmin(loginDataSet.LoginAdmin, usernamebox.Text, passbox.Text);
                
                if (loginIDTextBox.Text == "")
                    MessageBox.Show("Wrong Username/Password");
                else 
                {
                    this.Hide();
                    Form1 admin = new Form1(usernamebox.Text);
                    admin.Show();
                }
            }
            else if (selectuser.Text == "Student")
            {
                loginStudentTableAdapter.FillBySearchStudent(loginDataSet.LoginStudent, usernamebox.Text, passbox.Text);
                if (loginIDTextBox1.Text == "")
                    MessageBox.Show("Wrong Username/Password");
                else
                {
                    this.Hide();
                    StudentMain stud = new StudentMain(usernamebox.Text);
                    stud.Show();
                }

            }
            else
                errordisplay.Text = "Please Select The Login Type";
        }

        private void loginAdminBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.loginAdminBindingSource.EndEdit();
            this.loginAdminTableAdapter.Update(this.loginDataSet.LoginAdmin);

        }

        private void login_Load(object sender, EventArgs e)
        {
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}