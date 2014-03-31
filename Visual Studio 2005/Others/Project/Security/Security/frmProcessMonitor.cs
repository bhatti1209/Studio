using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

using System.Diagnostics;

namespace Security
{
    public partial class frmProcessMonitor : Form
    {
        public frmProcessMonitor()
        {
            InitializeComponent();
        }

        private void frmProcessMonitor_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            fillprocess();
        }
        void fillprocess()
        {
            ListBox1.Items.Clear();
            foreach(Process proc in System.Diagnostics.Process.GetProcesses())
            {
                ListBox1.Items.Add(proc.ProcessName );
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
 foreach(Process proc   in Process.GetProcesses())
 {
     if (proc.ProcessName == ListBox1.Text)
     {
         proc.Kill();
         MessageBox.Show("Successfully Killed");
         fillprocess();
     }
 }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            for (int i = 1; i < ListBox1.Items.Count; i++)
            {

                ListBox1.SelectedIndex = i - 1;
                listBox2.Items.Add(ListBox1.Text);
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            ListBox1.Items.Clear();
            fillprocess();
            for (int i = 1; i < ListBox1.Items.Count; i++)
            {
                ListBox1.SelectedIndex = i - 1;
                if (listBox2.Items.Contains(ListBox1.Text) == false)
                {
                    MessageBox.Show("New Process has found : Named : " + ListBox1.Text + " At : " + DateTime.Now.ToString());
                }
            }
            
            
        }
    }
}