using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace testdb
{
    public partial class SearchMS : Form
    {
        int counter;

        public SearchMS()
        {
            InitializeComponent();
        }

        private void marksheetBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.marksheetBindingSource.EndEdit();
            this.marksheetTableAdapter.Update(this.studentMarksheetDataSet.Marksheet);
        }

        private void SearchMS_Load(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            rollbox.Text = "";
            searchsem.Checked = false;
            sembox.Text = "";

            firstNameTextBox.Text = "";
            lastNameTextBox.Text = "";
            rollNumberTextBox.Text = "";
            semTextBox.Text = "";
            SGPATextBox.Text = "";

            sub1TextBox.Text = "";
            sub2TextBox.Text = "";
            sub3TextBox.Text = "";
            sub4TextBox.Text = "";
            sub5TextBox.Text = "";
            sub6TextBox.Text = "";
            sub7TextBox.Text = "";
            sub8TextBox.Text = "";
            sub1TextBox.Text = "";

            grade1TextBox.Text = "";
            grade2TextBox.Text = "";
            grade3TextBox.Text = "";
            grade4TextBox.Text = "";
            grade5TextBox.Text = "";
            grade6TextBox.Text = "";
            grade7TextBox.Text = "";
            grade8TextBox.Text = "";

            marksheetTableAdapter.FillBySearchMSRoll(studentMarksheetDataSet.Marksheet, rollbox.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (counter == 0)
            {
                marksheetTableAdapter.FillBySearchMSRoll(studentMarksheetDataSet.Marksheet, rollbox.Text);
            }
            else if (counter == 1)
            {
                marksheetTableAdapter.FillBySeachMSRollSem(studentMarksheetDataSet.Marksheet, rollbox.Text, sembox.Text);
            }
        }

        private void searchsem_CheckedChanged(object sender, EventArgs e)
        {
            if (searchsem.Checked == false)
            {
                counter = 0;
                sembox.ReadOnly = true;
            }
            else if (searchsem.Checked == true)
            {
                counter = 1;
                sembox.ReadOnly = false;
            }
        }

        private void rollNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            studentTableAdapter.FillBySearchMS(studentDBDataSet.Student, rollNumberTextBox.Text, semTextBox.Text);
        }
    }
}