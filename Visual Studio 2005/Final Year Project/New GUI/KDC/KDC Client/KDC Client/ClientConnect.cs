using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Security.Cryptography;

namespace KDC_Client
{
    public partial class ClientConnect : Form
    {
        private TcpClient client;
        private NetworkStream output; // stream for receiving data           
        private BinaryWriter writer; // facilitates writing to the stream    
        private BinaryReader reader; // facilitates reading from the stream  
        private Thread readThread; // Thread for processing incoming messages
        string ipadd;
        private string message = "";
        string path;

        Mainpage parent;
        byte[] key;
        byte[] data1;
        byte[] data2;
        string datatosend;
        SymmetricAlgorithm sa;

        public ClientConnect(Mainpage mainpage)
        {
            parent = mainpage;
            InitializeComponent();
        }

        private void ClientConnect_Load(object sender, EventArgs e)
        {
            
        }

        private void ClientConnect_FormClosing(object sender, FormClosingEventArgs e)
        {
            //writer.Write("TERMINATE");
            closeconenctions();
        }

        public void RunClient()
        {
            // instantiate TcpClient for sending data to server
            try
            {
                //DisplayMessage("Attempting connection\r\n");

                // Step 1: create TcpClient and connect to server
                client = new TcpClient();
                client.Connect(ipadd, 50001);

                // Step 2: get NetworkStream associated with TcpClient
                output = client.GetStream();

                // create objects for writing and reading across stream
                writer = new BinaryWriter(output);
                reader = new BinaryReader(output);

                // loop until server signals termination
                do
                {
                    // Step 3: processing phase
                    try
                    {
                        // read message from server        
                        message = reader.ReadString();
                        if (message == "Connection successful")
                            groupBox2.Enabled = true;
                        else
                            MessageBox.Show("No Server Found");
                    } // end try
                    catch (Exception)
                    {
                        // handle exception if error in reading server data
                        //System.Environment.Exit(System.Environment.ExitCode);
                    } // end catch
                } while (message != "TERMINATE");

                // Step 4: close connection
                //closeconenctions();

                //Application.Exit();
            } // end try
            catch (Exception error)
            {
                // handle exception if error in establishing connection
                MessageBox.Show(error.ToString(), "Connection Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                //System.Environment.Exit(System.Environment.ExitCode);
            } // end catch

        } // end method RunClient

        private void closeconenctions()
        {
            writer.Close();
            reader.Close();
            output.Close();
            client.Close();
        }

        private void ConfigureClient_Click(object sender, EventArgs e)
        {
            ipadd = textBox1.Text;
            readThread = new Thread(new ThreadStart(RunClient));
            readThread.Start();
            groupBox3.Enabled = true;
        }

        private void connecttokdc_Click(object sender, EventArgs e)
        {
            KDCClient a = new KDCClient();
            a.MdiParent = parent;
            a.Show();
            groupBox1.Enabled = true;
        }

        SymmetricAlgorithm CreateSymmetricAlgorithm()
        {
            if (DESButton.Checked == true)
                return DES.Create();
            if (RijndaelButton.Checked == true)
                return Rijndael.Create();
            if (RC2Button.Checked == true)
                return RC2.Create();
            if (TDESButton.Checked == true)
                return TripleDES.Create();
            return null;
        }

        private void GenerateIV_Click(object sender, EventArgs e)
        {
            sa = CreateSymmetricAlgorithm();
            sa.Mode = CipherMode.ECB;
            sa.Padding = PaddingMode.PKCS7;

            sa.GenerateKey();

            key = sa.Key;

            //data to be send
            string keyval = Convert.ToBase64String(key, 0, key.Length);

            datatosend = "Datasendby: ";
            datatosend += parent.toolStripMenuItem2.Text;
            datatosend += " Algorithm: ";

            if (DESButton.Checked == true)
                datatosend += "DES";
            if (RijndaelButton.Checked == true)
                datatosend += "Rijndael";
            if (RC2Button.Checked == true)
                datatosend += "RC2";
            if (TDESButton.Checked == true)
                datatosend += "TripleDES";

            datatosend += " Key: ";
            for (int q1 = 0; q1 < keyval.Length; q1++)
                datatosend += Convert.ToString(keyval[q1]);

            data1 = Encoding.UTF8.GetBytes(datatosend);
            groupBox5.Enabled = true;
        }

        private void EncryptUsingPrivate_Click(object sender, EventArgs e)
        {
            //encrypt using private key
            groupBox6.Enabled = true;
        }

        private void EncryptUsingPublic_Click(object sender, EventArgs e)
        {
            //encrypt using clients public key            
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();

            //public only RSA parameters for encrypt of client
            StreamReader reader = new StreamReader("KDC\\KDC Client\\SavedPublicOnlyKey.xml");
            string publicOnlyKeyXML = reader.ReadToEnd();
            rsa.FromXmlString(publicOnlyKeyXML);
            reader.Close();

            //read plaintext, encrypt it to ciphertext
            data2 = rsa.Encrypt(data1, false); //fOAEP needs high encryption pack

            EncryptUsingPrivate.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //send encrypted data to client
            string senddata = "";
            for (int q = 0; q < data2.Length; q++)
            {
                char t = Convert.ToChar(data2[q]);
                senddata += Convert.ToString(t);
            }

            writer.Write(senddata);
            NetworkStream wr = client.GetStream();
            wr.Write(data2, 0, data2.Length);

            //hash of data to send
            SHA1 sha1 = new SHA1CryptoServiceProvider();
            byte[] msg = Encoding.UTF8.GetBytes(datatosend);
            byte[] hashbytes = sha1.ComputeHash(msg);

            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            StreamReader reader = new StreamReader("KDC\\KDC Client\\KDCPublicPrivateKey.xml");
            string publicPrivateKeyXML = reader.ReadToEnd();
            rsa.FromXmlString(publicPrivateKeyXML);

            byte[] rsasignaturebytes = rsa.SignHash(hashbytes, "1.3.14.3.2.26");
            
            //signed hash value export
            wr.Write(rsasignaturebytes, 0, rsasignaturebytes.Length);

            //exchangin messages
            int algoval = 0;

            if (DESButton.Checked == true)
                algoval = 1;
            if (RijndaelButton.Checked == true)
                algoval = 2;
            if (RC2Button.Checked == true)
                algoval = 3;
            if (TDESButton.Checked == true)
                algoval = 4;

            SessionKeyServer sks = new SessionKeyServer(algoval, sa.Key);
            sks.Show();
            sks.MdiParent = parent;
            this.Close();
        }
    }
}