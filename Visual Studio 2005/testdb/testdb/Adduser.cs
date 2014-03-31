using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace testdb
{
    public partial class Adduser : Form
    {
        public Adduser()
        {
            InitializeComponent();
        }

        private void loginAdminBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.loginAdminBindingSource.EndEdit();
            this.loginAdminTableAdapter.Update(this.loginDataSet.LoginAdmin);
        }

        private void Adduser_Load(object sender, EventArgs e)
        {            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Administrator")
            {
                if (passbox1.Text == passbox2.Text)
                {
                    loginAdminTableAdapter.InsertAdmin(usernamebox.Text, passbox1.Text);
                    MessageBox.Show("Administrator Added");
                    this.Close();
                }
                else
                    MessageBox.Show("Please Re-Confirm The Passwords !!");
            }
            else if (comboBox1.Text == "Student")
            {
                if (passbox1.Text == passbox2.Text)
                {
                    loginStudentTableAdapter.InsertStudent(usernamebox.Text, passbox1.Text);
                    MessageBox.Show("Student Added");
                    this.Close();
                }
                else
                    MessageBox.Show("Please Re-Confirm The Passwords !!");
            }
            else
            {
                MessageBox.Show("Please Select The Group");
            }
        }
    }
}