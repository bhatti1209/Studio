using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Security
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void proccessMonitorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProcessMonitor frm = new frmProcessMonitor();

            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
          
        }

        private void portScanerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPortScanner  frm = new FrmPortScanner ();

            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void packageFilteringToolStripMenuItem_Click(object sender, EventArgs e)
        {


            MJsnifferForm frm = new MJsnifferForm();

            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void firewallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Firewall frm = new Firewall();
            frm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Firewall frm = new Firewall();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MJsnifferForm frm = new MJsnifferForm();

            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            FrmPortScanner frm = new FrmPortScanner();

            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            frmProcessMonitor frm = new frmProcessMonitor();

            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
          
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FrmIPScan frm = new FrmIPScan();
            frm.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmIPScan frm = new FrmIPScan();
            frm.Show();
        }
    }
}