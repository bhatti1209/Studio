using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace testdb
{
    public partial class Marksheet : Form
    {
        int counter=0;

        public Marksheet()
        {
            InitializeComponent();
        }

        private void studentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.studentBindingSource.EndEdit();
            this.studentTableAdapter.Update(this.studentDBDataSet.Student);

        }

        private void Marksheet_Load(object sender, EventArgs e)
        {           

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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                counter = 1;
                sembox.ReadOnly = false;
            }
            else
            {
                counter = 0;
                sembox.ReadOnly = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            rollbox.Text = "";
            checkBox1.Checked = false;
            sembox.Text = "";

            firstNameTextBox.Text = "";
            lastNameTextBox.Text = "";
            rollNumberTextBox.Text = "";
            totalCreditTextBox.Text = "";
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

        private void button3_Click(object sender, EventArgs e)
        {
            marksheetTableAdapter.InsertMarks(rollNumberTextBox.Text, semTextBox.Text,
                gr1.Text, gr2.Text, gr3.Text, gr4.Text, gr5.Text, gr6.Text, gr7.Text, gr8.Text,
                sgpabox.Text);
        }

        int congrade(string temp)
        {
            int ans = 0;

            if (temp == "A+")
                ans=10;
            else if (temp == "A")
                ans=9;
            else if (temp == "B+")
                ans=8;
            else if (temp == "B")
                ans=7;
            else if (temp == "C+")
                ans=6;
            else if (temp == "C")
                ans=5;
            else if (temp == "D")
                ans=4;

            return ans;
        }

        void calcsgpa()
        {
            int t1,t2,t3,t4,t5,t6,t7,t8,total=0;

            t1 = congrade(gr1.Text);
            if (t1 != 0)
                total += t1 * (Convert.ToInt32(core1TextBox.Text));
            t2 = congrade(gr2.Text);
            if (t2 != 0)
                total += t2 * (Convert.ToInt32(core2TextBox.Text));
            t3 = congrade(gr3.Text);
            if (t3 != 0)
                total += t3 * (Convert.ToInt32(core3TextBox.Text));
            t4 = congrade(gr4.Text);
            if (t4 != 0)
                total += t4 * (Convert.ToInt32(core4TextBox.Text));

            t5 = congrade(gr5.Text);
            if (t5 != 0)
                total += t5 * (Convert.ToInt32(opt1TextBox.Text));
            t6 = congrade(gr6.Text);
            if (t6 != 0)
                total += t6 * (Convert.ToInt32(opt2TextBox.Text));
            t7 = congrade(gr7.Text);
            if (t7 != 0)
                total += t7 * (Convert.ToInt32(opt3TextBox.Text));
            t8 = congrade(gr8.Text);
            if (t8 != 0)
                total += t8 * (Convert.ToInt32(opt4TextBox.Text));

            double tc = Convert.ToDouble(totalCreditTextBox.Text);
            double sg = total / tc;
            sgpabox.Text = Convert.ToString(sg);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button3.Enabled = true;
            calcsgpa();
        }
    }
}