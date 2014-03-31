using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace testdb
{
    public partial class BrowseCourseStud : Form
    {
        public BrowseCourseStud(string temp)
        {
            InitializeComponent();
            studentTableAdapter.FillByBrowseCourseStud(studentDBDataSet.Student, temp); 
        }

        private void studentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.studentBindingSource.EndEdit();
            this.studentTableAdapter.Update(this.studentDBDataSet.Student);

        }

        private void BrowseCourseStud_Load(object sender, EventArgs e)
        {  
        }
    }
}