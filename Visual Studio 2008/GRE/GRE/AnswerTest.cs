using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace GRE
{
    public partial class AnswerTest : Form
    {
        int noq;
        string filename;
        string ans;
        int score;
        Thread clockstart;

        public AnswerTest(string t)
        {
            score = 0;
            filename = t;
            InitializeComponent();
        }

        private void submitbutton_Click(object sender, EventArgs e)
        {
            int counter = 0;

            for (int q1 = 1; q1 <= noq; q1++)
            {
                Control[] temp2 = this.Controls.Find("textbox" + q1.ToString(), true);

                if (temp2[0].Text == "")
                    counter = 1;
            }

            if (counter == 0)
            {
                clockstart.Abort();

                //check answers
                for (int q = 0; q < noq; q++)
                {
                    char temp = Convert.ToChar(ans[q]);

                    int val = q + 1;
                    Control[] temp2 = this.Controls.Find("textbox" + val.ToString(), true);
                    char ansval = Convert.ToChar(temp2[0].Text);

                    if (temp == ansval)
                    {
                        score++;
                        temp2[0].BackColor = Color.GreenYellow;
                    }
                    else
                    {
                        temp2[0].BackColor = Color.OrangeRed;
                        temp2[0].Text += " [" + temp + "] ";
                    }
                }

                //display score
                int scoreval = 0;

                if (noq == 30)
                {
                    if (score >= 0 && score <= 3)
                        scoreval = 200;
                    else if (score >= 4 && score <= 6)
                        scoreval = 240;
                    else if (score >= 7 && score <= 9)
                        scoreval = 310;
                    else if (score >= 10 && score <= 12)
                        scoreval = 390;
                    else if (score >= 13 && score <= 15)
                        scoreval = 450;
                    else if (score >= 16 && score <= 18)
                        scoreval = 500;
                    else if (score >= 19 && score <= 21)
                        scoreval = 590;
                    else if (score >= 22 && score <= 24)
                        scoreval = 650;
                    else if (score >= 25 && score <= 27)
                        scoreval = 720;
                    else if (score == 28)
                        scoreval = 760;
                    else if (score >= 29 && score <= 30)
                        scoreval = 800;
                }
                else if (noq == 28)
                {
                    if (score >= 0 && score <= 3)
                        scoreval = 200;
                    else if (score >= 4 && score <= 6)
                        scoreval = 270;
                    else if (score >= 7 && score <= 9)
                        scoreval = 350;
                    else if (score >= 10 && score <= 12)
                        scoreval = 430;
                    else if (score >= 13 && score <= 15)
                        scoreval = 500;
                    else if (score >= 16 && score <= 18)
                        scoreval = 560;
                    else if (score >= 19 && score <= 21)
                        scoreval = 630;
                    else if (score >= 22 && score <= 24)
                        scoreval = 700;
                    else if (score >= 25 && score <= 27)
                        scoreval = 770;
                    else if (score == 28)
                        scoreval = 800;
                }

                MessageBox.Show("Your Answered " + score.ToString() + " Questions Correctly !! \nYour Score Is : " + scoreval.ToString());
                scorebox.Text = scoreval.ToString();
            }
            else
                MessageBox.Show("Please Enter All The Options ....No Unfilled Option Should Be There !!");
        }

        private void AnswerTest_Load(object sender, EventArgs e)
        {
            //get answers from file
            FileStream a = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader sr = new StreamReader(a);

            int len = (int)a.Length;
            noq = len;

            ans = sr.ReadToEnd();

            sr.Close();
            a.Close();

            
            //intialize
            for (int q = 1; q <= noq; q++)
            {
                Control[] temp1 = this.Controls.Find("label" + q.ToString(), true);
                temp1[0].Visible = true;
                temp1[0].Text = q.ToString();

                Control[] temp2 = this.Controls.Find("textbox" + q.ToString(), true);
                temp2[0].Visible = true;
                temp2[0].TabIndex = q;
            }
        }

        private void startbutton_Click(object sender, EventArgs e)
        {
            for (int q = 1; q <= noq; q++)
            {
                Control[] temp2 = this.Controls.Find("textbox" + q.ToString(), true);
                temp2[0].Enabled = true;
            }

            startbutton.Enabled = false;
            submitbutton.Enabled = true;

            startclock();
        }

        private void startclock()
        {
            clockstart = new Thread(new ThreadStart(countdown));
            clockstart.Start();
        }

        private void tabbing(object sender, EventArgs e)
        {
            int num=0;
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
                Control[] a = this.Controls.Find("submitbutton", true);
                a[0].Focus();
            }
        }

        private void countdown()
        {
            int mins, secs;

            if (noq == 30)
            {
                mins = 29;
                secs = 59;

                DateTime last = DateTime.Now;
                DateTime now = last.AddSeconds(1);

                string time = mins.ToString() + ":" + secs.ToString();
                timerlabel.Text = time;

                while (mins >= 0 && secs > 0)
                {
                    last = DateTime.Now;

                    if (last.Second == now.Second)
                    {
                        secs--;

                        if (secs == 0)
                        {
                            if (mins == 0)
                                secs = 0;
                            else
                            {
                                secs = 59;
                                mins--;
                            }
                        }

                        now = last.AddSeconds(1);
                        time = mins.ToString() + ":" + secs.ToString();
                        timerlabel.Text = time;
                    }
                }

                if (mins == 0 && secs == 0)
                {
                    MessageBox.Show("You Are Out Of Time...Test Aborted !!");
                    clockstart.Abort();
                }
            }
            else if (noq == 28)
            {
                mins = 44;
                secs = 59;

                DateTime last = DateTime.Now;
                DateTime now = last.AddSeconds(1);
                while (mins != 0 && secs != 0)
                {
                    last = DateTime.Now;

                    if (last.Second == now.Second)
                    {
                        string time = mins.ToString() + ":" + secs.ToString();
                        timerlabel.Text = time;

                        secs--;

                        if (secs == 0)
                        {
                            secs = 59;
                            mins--;
                        }

                        now = last.AddSeconds(1);
                    }
                }
            }
        }

        private void AnswerTest_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (startbutton.Enabled == false)
                clockstart.Abort();

        }
    }
}
