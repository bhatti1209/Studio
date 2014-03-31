using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace testdb
{
    public partial class BrowseMarkStud : Form
    {
        public BrowseMarkStud(string temp)
        {
            InitializeComponent();
            marksheetTableAdapter.FillByBrowseMarkStud(studentMarksheetDataSet.Marksheet, temp);   
        }

        private void studentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.studentBindingSource.EndEdit();
            this.studentTableAdapter.Update(this.studentDBDataSet.Student);

        }

        private void studentBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.studentBindingSource.EndEdit();
            this.studentTableAdapter.Update(this.studentDBDataSet.Student);

        }

        private void BrowseMarkStud_Load(object sender, EventArgs e)
        {
            studentTableAdapter.FillByBrowseMarkStud(studentDBDataSet.Student, rollNumberTextBox.Text, semTextBox.Text);
        }

        private void semTextBox_TextChanged(object sender, EventArgs e)
        {
            studentTableAdapter.FillByBrowseMarkStud(studentDBDataSet.Student, rollNumberTextBox.Text, semTextBox.Text);
        }
    }
}