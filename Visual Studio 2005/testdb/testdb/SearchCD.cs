using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace testdb
{
    public partial class SearchCD : Form
    {
        int counter = 0;

        public SearchCD()
        {
            InitializeComponent();
        }

        private void studentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.studentBindingSource.EndEdit();
            this.studentTableAdapter.Update(this.studentDBDataSet.Student);

        }

        private void SearchCD_Load(object sender, EventArgs e)
        {      

        }

        private void searchsem_CheckedChanged(object sender, EventArgs e)
        {
            if (searchsem.Checked == true)
            {
                sembox.ReadOnly = false;
                counter = 1;
            }
            else
            {
                counter = 0;
                sembox.ReadOnly = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (counter == 0)
            {
                studentTableAdapter.FillBySearchRoll(studentDBDataSet.Student, rollbox.Text);
            }
            else if (counter == 1)
            {
                studentTableAdapter.FillBySearchrollsem(studentDBDataSet.Student, rollbox.Text, sembox.Text);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            rollbox.Text = "";
            searchsem.Checked = false;
            sembox.Text = "";

            firstNameTextBox.Text = "";
            lastNameTextBox.Text = "";
            rollNumberTextBox.Text = "";
            totalCreditTextBox.Text = "";
            emailTextBox.Text = "";
            semTextBox.Text = "";

            sub1TextBox.Text = "";
            sub2TextBox.Text = "";
            sub3TextBox.Text = "";
            sub4TextBox.Text = "";
            sub5TextBox.Text = "";
            sub6TextBox.Text = "";
            sub7TextBox.Text = "";
            sub8TextBox.Text = "";
            sub1TextBox.Text = "";

            core1TextBox.Text = "";
            core2TextBox.Text = "";
            core3TextBox.Text = "";
            core4TextBox.Text = "";

            opt1TextBox.Text = "";
            opt2TextBox.Text = "";
            opt3TextBox.Text = "";
            opt4TextBox.Text = "";

            studentTableAdapter.FillBySearchRoll(studentDBDataSet.Student, rollbox.Text);
        }
    }
}