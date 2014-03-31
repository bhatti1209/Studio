using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace GRE
{
    public partial class NewTest : Form
    {
        int noq;

        public NewTest()
        {
            InitializeComponent();
        }

        private void fillanswers_Click(object sender, EventArgs e)
        {
            if (noofques.Text == "")
                MessageBox.Show("Please enter the number of questions to answer !!");
            else if (Convert.ToInt32(noofques.Text) > 30)
                MessageBox.Show("Please enter less than 30 questions !!");
            else
            {
                noq = Convert.ToInt32(noofques.Text);

                for (int r = 1; r <= 30; r++)
                {
                    Control[] temp1 = this.Controls.Find("label" + r.ToString(), true);
                    temp1[0].Visible = false;

                    Control[] temp2 = this.Controls.Find("textbox" + r.ToString(), true);
                    temp2[0].Visible = false;
                }

                for (int q = 1; q <= noq; q++)
                {
                    Control[] temp1 = this.Controls.Find("label" + q.ToString(), true);
                    temp1[0].Visible = true;
                    temp1[0].Text = q.ToString();

                    Control[] temp2 = this.Controls.Find("textbox" + q.ToString(), true);
                    temp2[0].Visible = true;
                    temp2[0].TabIndex = q;
                }

                startbutton.Enabled = true;
            }
        }

        private void tabbing(object sender, EventArgs e)
        {
            int num = 0;
            TextBox temp = (System.Windows.Forms.TextBox)sender;

            int len = temp.Name.Length;

            if ((temp.Name[len - 1] >= '0' && temp.Name[len - 1] <= '9') && (temp.Name[len - 2] >= '0' && temp.Name[len - 2] <= '9'))
            {
                char no1 = temp.Name[len - 2];
                char no2 = temp.Name[len - 1];
                string t = Convert.ToString(no1) + Convert.ToString(no2);

                num = Convert.ToInt32(t);
                num++;
            }
            else if (temp.Name[len - 1] >= '0' && temp.Name[len - 1] <= '9')
            {
                char no = temp.Name[len - 1];
                string t = Convert.ToString(no);

                num = Convert.ToInt32(t);
                num++;
            }

            if (num <= noq)
            {
                string temp2 = "textbox" + Convert.ToString(num);
                Control[] a = this.Controls.Find(temp2, true);

                a[0].Focus();
            }
            else
            {
                Control[] a = this.Controls.Find("startbutton", true);
                a[0].Focus();
            }
        }

        private void startbutton_Click(object sender, EventArgs e)
        {
            DialogResult result = saveFileDialog1.ShowDialog();
            saveFileDialog1.RestoreDirectory = true;

            if (result == DialogResult.Cancel)
                return;

            string filename = saveFileDialog1.FileName;

            FileStream a = new FileStream(filename, FileMode.Create, FileAccess.Write);
            StreamWriter op = new StreamWriter(a);
            
            int noq = Convert.ToInt32(noofques.Text);

            for (int q = 1; q <= noq; q++)
            {
                Control[] temp1 = this.Controls.Find("textbox" + q.ToString(), true);
                op.Write(temp1[0].Text);
            }

            op.Close();
            a.Close();

            AnswerTest at = new AnswerTest(saveFileDialog1.FileName);
            at.MdiParent = (Form1)this.MdiParent;
            at.Show();

            this.Close();
        }
    }
}
