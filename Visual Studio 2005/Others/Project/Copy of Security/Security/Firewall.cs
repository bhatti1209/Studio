using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace Security
{
    public partial class Firewall : Form
    {
        Int32 blockcount;
        public Firewall()
        {
            InitializeComponent();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
             ListBox1.Items.Add(TextBox1.Text);
             TextBox1.Text = "";
        }

        private void Button5_Click(object sender, EventArgs e)
        {
             ListBox1.Items.Remove(ListBox1.SelectedItem);
             ListBox1.Refresh();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            Timer1.Enabled = true;
        Button6.Enabled = false;
        Button7.Enabled = true;
        Label5.Text = " MONITORING ";
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            Timer1.Enabled = false;
        Button6.Enabled =false;
        Label5.Text = " NOT MONITORING";
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            Int32 i;
            string temp, pname;
            Process ps;
            Process processess;

            if (ListBox1.Items.Count == 0)
            {
                Timer1.Enabled = false;
                MessageBox.Show("Please Specify a Process to Block");
                
                //Windows.Forms.Application.DoEvents();
                Button6.Text = "Enable Firewall";
                Label5.Text = " NOT MONITORING ";
                Button6.Enabled = true;
                Button7.Enabled = false;

                return;
            }
            else

                for (i = 0; i < ListBox1.Items.Count; i++)
                {


                    ListBox1.SelectedIndex = i;
                    temp = ListBox1.Text.ToString();
                    foreach (Process proc in Process.GetProcesses())
                    {
                        if (proc.ProcessName == ListBox1.Text)
                        {
                            proc.Kill();
                            //       MessageBox.Show("Successfully Killed");
                            //     fillprocess();  
                            blockcount = blockcount + 1;
                        }
                    }


                 

                }
            Label4.Text = blockcount.ToString();

        }
    }
}