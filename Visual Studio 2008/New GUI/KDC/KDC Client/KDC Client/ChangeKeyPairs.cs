using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;

namespace KDC_Client
{
    public partial class ChangeKeyPairs : Form
    {
        RSACryptoServiceProvider rsa;
        string loginname;
        string path;

        public ChangeKeyPairs(string login)
        {
            InitializeComponent();
            loginname = login;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rsa = new RSACryptoServiceProvider();

            string publicPrivateKeyXML = rsa.ToXmlString(true);

            //provide public only RSA params
            string publicOnlyKeyXML = rsa.ToXmlString(false);

            parameterdeatils.Text = publicPrivateKeyXML;
            button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //writing the key pairs to xml file

            StreamWriter writer = new StreamWriter("KDC\\KDC Client\\KDCPublicPrivateKey.xml");
            string publicPrivateKeyXML = rsa.ToXmlString(true);
            writer.Write(publicPrivateKeyXML);
            writer.Close();

            //provide public only RSA params
            writer = new StreamWriter("KDC\\KDC Client\\KDCPublicOnlyKey.xml");
            string publicOnlyKeyXML = rsa.ToXmlString(false);
            writer.Write(publicOnlyKeyXML);
            writer.Close();

            //writin the data to the db (update table)
            KDCDataSetTableAdapters.UpdateRequestsTableAdapter a = new KDC_Client.KDCDataSetTableAdapters.UpdateRequestsTableAdapter();
            byte[] data = Encoding.UTF8.GetBytes(publicOnlyKeyXML);
            byte[] data2 = Encoding.UTF8.GetBytes(publicPrivateKeyXML);
            a.InsertData(loginname, data, data2, DateTime.Today);

            MessageBox.Show("Update Registered");
        }
    }
}