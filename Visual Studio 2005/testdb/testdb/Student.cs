using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace testdb
{
    public partial class Student : Form
    {
        int totalcore;
        int total;

        public Student()
        {
            InitializeComponent();
        }

        private void studentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.studentBindingSource.EndEdit();
            this.studentTableAdapter.Update(this.studentDBDataSet.Student);

        }

        private void Student_Load(object sender, EventArgs e)
        {            

        }

        private void selectsem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (selectsem.Text == "I")
            {
                semTextBox.Text = selectsem.Text;

                totalcredits.Text = "";

                core1.Text = "5";
                core2.Text = "5";
                core3.Text = "4";
                core4.Text = "5";

                sub1.Text = "Maths";
                sub2.Text = "C Concpet";
                sub3.Text = "Phy.";
                sub4.Text = "Elec.";

                totalcore = 5 + 5 + 4 + 5;
                totalcredits.Text = Convert.ToString(totalcore);

                sub5.Hide();
                sub6.Hide();
                sub7.Hide();
                sub8.Hide();
                opt1.Text = "";
                opt2.Text = "";
                opt3.Text = "";
                opt4.Text = "";

                calctotal();
            }
            else if (selectsem.Text == "II")
            {
                semTextBox.Text = selectsem.Text;

                core1.Text = "5";
                core2.Text = "5";
                core3.Text = "4";
                core4.Text = "5";

                sub1.Text = "Maths I";
                sub2.Text = "C++";
                sub3.Text = "Phy. I";
                sub4.Text = "Elec. Sci.";

                totalcore = 5 + 5 + 4 + 5;
                totalcredits.Text = Convert.ToString(totalcore);

                sub5.Hide();
                sub6.Hide();
                sub7.Hide();
                sub8.Hide();
                opt1.Text = "";
                opt2.Text = "";
                opt3.Text = "";
                opt4.Text = "";

                calctotal();
            }
            else if (selectsem.Text == "III")
            {
                semTextBox.Text = selectsem.Text;

                core1.Text = "5";
                core2.Text = "3";
                core3.Text = "5";
                core4.Text = "4";

                sub1.Text = "Maths II";
                sub2.Text = "F.M.";
                sub3.Text = "D.S.";
                sub4.Text = "C.S.O.";

                totalcore = 5 + 3 + 5 + 4;
                totalcredits.Text = Convert.ToString(totalcore);

                sub5.Hide();
                sub6.Hide();
                sub7.Hide();
                sub8.Hide();
                opt1.Text = "";
                opt2.Text = "";
                opt3.Text = "";
                opt4.Text = "";

                calctotal();
            }
            else if (selectsem.Text == "IV")
            {
                semTextBox.Text = selectsem.Text;

                core1.Text = "5";
                core2.Text = "3";
                core3.Text = "4";
                core4.Text = "5";

                sub1.Text = "A.D.S.";
                sub2.Text = "M.E.";
                sub3.Text = "Num. Tech.";
                sub4.Text = "A.D.C.";

                totalcore = 5 + 3 + 4 + 5;
                totalcredits.Text = Convert.ToString(totalcore);

                sub5.Hide();
                sub6.Hide();
                sub7.Hide();
                sub8.Hide();
                opt1.Text = "";
                opt2.Text = "";
                opt3.Text = "";
                opt4.Text = "";

                calctotal();
            }
            else if (selectsem.Text == "V")
            {
                semTextBox.Text = selectsem.Text;

                core1.Text = "3";
                core2.Text = "5";
                core3.Text = "5";
                core4.Text = "5";

                sub1.Text = "Law";
                sub2.Text = "S.L.";
                sub3.Text = "Micro.";
                sub4.Text = "O.S.";

                totalcore = 3 + 5 + 5 + 5;
                totalcredits.Text = Convert.ToString(totalcore);

                sub5.Hide();
                sub6.Hide();
                sub7.Hide();
                sub8.Hide();
                opt1.Text = "";
                opt2.Text = "";
                opt3.Text = "";
                opt4.Text = "";

                calctotal();
            }
            else if (selectsem.Text == "VI")
            {
                semTextBox.Text = selectsem.Text;

                core1.Text = "5";
                core2.Text = "5";
                core3.Text = "4";
                core4.Text = "5";

                sub1.Text = "A.I.";
                sub2.Text = "S.E.";
                sub3.Text = "C.N.";
                sub4.Text = "C.D.";

                totalcore = 5 + 5 + 4 + 5;

                sub5.Show();
                sub6.Show();
                sub7.Show();
                sub8.Show();

                string[] additemVI1 = { "", "Wavelets", "C.G.", "AOT", "N.P." };
                string[] additemVI2 = { "", "Wavelets", "C.G.", "AOT", "N.P." };
                string[] additemVI3 = { "", "Wavelets", "C.G.", "AOT", "N.P." };
                string[] additemVI4 = { "", "Wavelets", "C.G.", "AOT", "N.P." };

                sub5.DataSource = additemVI1;
                sub6.DataSource = additemVI2;
                sub7.DataSource = additemVI3;
                sub8.DataSource = additemVI4;

                calctotal();
            }
            else if (selectsem.Text == "VII")
            {
                semTextBox.Text = selectsem.Text;

                core1.Hide();
                core2.Hide();
                core3.Hide();
                core4.Hide();

                sub1.Hide();
                sub2.Hide();
                sub3.Hide();
                sub4.Hide();

                totalcore = 0;

                sub5.Show();
                sub6.Show();
                sub7.Show();
                sub8.Show();

                string[] additemVI1 = { "", "D.S.P.", "Fuzzy", "AOT", "N.P.P" };
                string[] additemVI2 = { "", "D.S.P.", "Fuzzy", "AOT", "N.P.P" };
                string[] additemVI3 = { "", "D.S.P.", "Fuzzy", "AOT", "N.P.P" };
                string[] additemVI4 = { "", "D.S.P.", "Fuzzy", "AOT", "N.P.P" };

                sub5.DataSource = additemVI1;
                sub6.DataSource = additemVI2;
                sub7.DataSource = additemVI3;
                sub8.DataSource = additemVI4;

                calctotal();
            }
            else if (selectsem.Text == "VIII")
            {
                semTextBox.Text = selectsem.Text;

                core1.Hide();
                core2.Hide();
                core3.Hide();
                core4.Hide();

                sub1.Hide();
                sub2.Hide();
                sub3.Hide();
                sub4.Hide();

                totalcore = 0;

                sub5.Show();
                sub6.Show();
                sub7.Show();
                sub8.Show();

                string[] additemVI1 = { "", "C.M.", "H.R.", "T.O.C.", "D.I.P" };
                string[] additemVI2 = { "", "C.M.", "H.R.", "T.O.C.", "D.I.P" };
                string[] additemVI3 = { "", "C.M.", "H.R.", "T.O.C.", "D.I.P" };
                string[] additemVI4 = { "", "C.M.", "H.R.", "T.O.C.", "D.I.P" };

                sub5.DataSource = additemVI1;
                sub6.DataSource = additemVI2;
                sub7.DataSource = additemVI3;
                sub8.DataSource = additemVI4;

                calctotal();
            }
        }

        void calctotal()
        {
            int temp1 = 0;
            int temp2 = 0;
            int temp3 = 0;
            int temp4 = 0;

            if (opt1.Text != "")
                temp1 = Convert.ToInt32(opt1.Text);
            if (opt2.Text != "")
                temp2 = Convert.ToInt32(opt2.Text);
            if (opt3.Text != "")
                temp3 = Convert.ToInt32(opt3.Text);
            if (opt4.Text != "")
                temp4 = Convert.ToInt32(opt4.Text);

            total = totalcore + temp1 + temp2 + temp3 + temp4;
            totalcredits.Text = Convert.ToString(total);
        }

        private void sub5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sub5.Text == "Wavelets")
                opt1.Text = "4";
            if (sub5.Text == "C.G.")
                opt1.Text = "5";
            if (sub5.Text == "AOT")
                opt1.Text = "4";
            if (sub5.Text == "N.P.")
                opt1.Text = "2";
            if (sub5.Text == "D.S.P.")
                opt1.Text = "4";
            if (sub5.Text == "Fuzzy")
                opt1.Text = "3";
            if (sub5.Text == "N.P.P.")
                opt1.Text = "3";
            if (sub5.Text == "C.M.")
                opt1.Text = "4";
            if (sub5.Text == "H.R.")
                opt1.Text = "3";
            if (sub5.Text == "T.O.C.")
                opt1.Text = "3";
            if (sub5.Text == "D.I.P.")
                opt1.Text = "3";
            if (sub5.Text == "")
                opt1.Text = "";

            calctotal();
        }

        private void sub6_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sub6.Text == "Wavelets")
                opt2.Text = "4";
            if (sub6.Text == "C.G.")
                opt2.Text = "5";
            if (sub6.Text == "AOT")
                opt2.Text = "4";
            if (sub6.Text == "N.P.")
                opt2.Text = "2";
            if (sub6.Text == "D.S.P.")
                opt2.Text = "4";
            if (sub6.Text == "Fuzzy")
                opt2.Text = "3";
            if (sub6.Text == "N.P.P.")
                opt2.Text = "3";
            if (sub6.Text == "C.M.")
                opt2.Text = "4";
            if (sub6.Text == "H.R.")
                opt2.Text = "3";
            if (sub6.Text == "T.O.C.")
                opt2.Text = "3";
            if (sub6.Text == "D.I.P.")
                opt2.Text = "3";
            if (sub6.Text == "")
                opt2.Text = "";

            calctotal();
        }

        private void sub7_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sub7.Text == "Wavelets")
                opt3.Text = "4";
            if (sub7.Text == "C.G.")
                opt3.Text = "5";
            if (sub7.Text == "AOT")
                opt3.Text = "4";
            if (sub7.Text == "N.P.")
                opt3.Text = "2";
            if (sub7.Text == "D.S.P.")
                opt3.Text = "4";
            if (sub7.Text == "Fuzzy")
                opt3.Text = "3";
            if (sub7.Text == "N.P.P.")
                opt3.Text = "3";
            if (sub7.Text == "C.M.")
                opt3.Text = "4";
            if (sub7.Text == "H.R.")
                opt3.Text = "3";
            if (sub7.Text == "T.O.C.")
                opt3.Text = "3";
            if (sub7.Text == "D.I.P.")
                opt3.Text = "3";
            if (sub7.Text == "")
                opt3.Text = "";

            calctotal();
        }

        private void sub8_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sub8.Text == "Wavelets")
                opt4.Text = "4";
            if (sub8.Text == "C.G.")
                opt4.Text = "5";
            if (sub8.Text == "AOT")
                opt4.Text = "4";
            if (sub8.Text == "N.P.")
                opt4.Text = "2";
            if (sub8.Text == "D.S.P.")
                opt4.Text = "4";
            if (sub8.Text == "Fuzzy")
                opt4.Text = "3";
            if (sub8.Text == "N.P.P.")
                opt4.Text = "3";
            if (sub8.Text == "C.M.")
                opt4.Text = "4";
            if (sub8.Text == "H.R.")
                opt4.Text = "3";
            if (sub8.Text == "T.O.C.")
                opt4.Text = "3";
            if (sub8.Text == "D.I.P.")
                opt4.Text = "3";
            if (sub8.Text == "")
                opt4.Text = "";

            calctotal();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            studentTableAdapter.InsertData(firstNameTextBox.Text, lastNameTextBox.Text, rollNumberTextBox.Text, Convert.ToInt32(totalcredits.Text),
                emailTextBox.Text, semTextBox.Text, sub1.Text, core1.Text, sub2.Text, core2.Text,
                sub3.Text, core3.Text, sub4.Text, core4.Text, sub5.Text, opt1.Text,
                sub6.Text, opt2.Text, sub7.Text, opt3.Text, sub8.Text, opt4.Text);

        }
    }
}