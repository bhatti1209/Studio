using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TextConversion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox2.Text = "";
            string input = richTextBox1.Text;
            char temp;
            Random a = new Random();

            for (int q = 0; q < input.Length; q++)
            {
                temp = input[q];

                if ((temp >= 65 && temp <= 90) || (temp >= 97 && temp <= 122))
                {
                    if (radioButton1.Checked == true)
                    {
                        if (q == 0)
                        {
                            if ((temp >= 97 && temp <= 122))
                            {
                                char t = Convert.ToChar(Convert.ToInt16(temp) - 32);
                                richTextBox2.Text += t;
                            }
                            else
                                richTextBox2.Text += temp;
                        }
                        else
                        {
                            char s = input[q - 1];

                            if (s == 32)
                            {
                                if ((temp >= 97 && temp <= 122))
                                {
                                    char t = Convert.ToChar(Convert.ToInt16(temp) - 32);
                                    richTextBox2.Text += t;
                                }
                                else
                                    richTextBox2.Text += temp;
                            }
                            else
                                richTextBox2.Text += temp;
                        }
                    }
                    else if (radioButton2.Checked == true)
                    {
                        int n = a.Next(1, 3);

                        if (n == 1) //small
                        {
                            if ((temp >= 65 && temp <= 90))
                            {
                                char t = Convert.ToChar(Convert.ToInt16(temp) + 32);
                                richTextBox2.Text += t;
                            }
                            else
                                richTextBox2.Text += temp;
                        }
                        else if (n == 2) //cap
                        {
                            if ((temp >= 97 && temp <= 122))
                            {
                                char t = Convert.ToChar(Convert.ToInt16(temp) - 32);
                                richTextBox2.Text += t;
                            }
                            else
                                richTextBox2.Text += temp;
                        }
                    }
                }
                else
                    richTextBox2.Text += temp;
            }
        }
    }
}
