using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GRE
{
    public partial class Form1 : Form
    {
        AnswerTest at;

        public Form1()
        {
            InitializeComponent();
        }

        private void newTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewTest a = new NewTest();
            a.MdiParent = this;
            a.Show();
        }

        private void loadTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult res = openFileDialog1.ShowDialog();
            
            if (res == DialogResult.Cancel)
                return;
            else
            {
                at = new AnswerTest(openFileDialog1.FileName);
                at.MdiParent = this;
                at.Show();
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (at != null)
            {
                if (!at.IsDisposed)
                    at.Close();
            }
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
