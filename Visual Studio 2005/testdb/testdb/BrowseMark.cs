using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace testdb
{
    public partial class BrowseMark : Form
    {
        public BrowseMark()
        {
            InitializeComponent();
        }

        private void marksheetBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.marksheetBindingSource.EndEdit();
            this.marksheetTableAdapter.Update(this.studentMarksheetDataSet.Marksheet);

        }

        private void BrowseMark_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentDBDataSet.Student' table. You can move, or remove it, as needed.
            //this.studentTableAdapter.Fill(this.studentDBDataSet.Student);
            // TODO: This line of code loads data into the 'studentMarksheetDataSet.Marksheet' table. You can move, or remove it, as needed.
            this.marksheetTableAdapter.Fill(this.studentMarksheetDataSet.Marksheet);
            studentTableAdapter.FillByBrowsemarks(studentDBDataSet.Student, rollNumberTextBox.Text, semTextBox.Text);
        }

        private void rollNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            studentTableAdapter.FillByBrowsemarks(studentDBDataSet.Student, rollNumberTextBox.Text, semTextBox.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            marksheetTableAdapter.DeleteMarks(rollNumberTextBox.Text, semTextBox.Text);
            marksheetTableAdapter.Fill(studentMarksheetDataSet.Marksheet);
        }

        private void semTextBox_TextChanged(object sender, EventArgs e)
        {
            studentTableAdapter.FillByBrowsemarks(studentDBDataSet.Student, rollNumberTextBox.Text, semTextBox.Text);
        }
    }
}