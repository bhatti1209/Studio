using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KDC_Client
{
    public partial class GetIP : Form
    {
        ClientServer parent;
        Mainpage p1;
        int algoval;
        byte[] keyval;

        public GetIP(ClientServer a, Mainpage b, int algo, byte[] keyv)
        {
            InitializeComponent();
            parent = a;
            p1 = b;
            algoval = algo;
            keyval = keyv;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            parent.ipadd2 = textBox1.Text;

            //start the message exchange
            SessionKeyClient skc = new SessionKeyClient(textBox1.Text, algoval, keyval);
            skc.Show();
            skc.MdiParent = p1;

            this.Close();
        }
    }
}