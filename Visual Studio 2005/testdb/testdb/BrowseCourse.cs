using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace testdb
{
    public partial class BrowseCourse : Form
    {
        public BrowseCourse()
        {
            InitializeComponent();
        }

        private void studentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.studentBindingSource.EndEdit();
            this.studentTableAdapter.Update(this.studentDBDataSet.Student);

        }

        private void BrowseCourse_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentDBDataSet.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.studentDBDataSet.Student);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            studentTableAdapter.DeleteRow(rollNumberTextBox.Text, semTextBox.Text);
            studentTableAdapter.Fill(studentDBDataSet.Student);
        }
    }
}