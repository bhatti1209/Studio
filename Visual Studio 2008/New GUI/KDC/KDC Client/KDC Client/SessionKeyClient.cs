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
    public partial class SessionKeyClient : Form
    {
        string ipadd;
        byte[] key;
        byte[] tempkey;
        SymmetricAlgorithm sa;
        byte[] databyte = new byte[128];

        int newkeyparam;
        bool conti;
        bool val;
        int mins;
        int secs;
        int resettimer = 0;

        private TcpClient client;
        private NetworkStream output; // stream for receiving data           
        private BinaryWriter writer; // facilitates writing to the stream    
        private BinaryReader reader; // facilitates reading from the stream  
        private Thread readThread; // Thread for processing incoming messages
        private Thread timer;
        private string message = "";

        public SessionKeyClient(string ip, int algoval, byte[] key1)
        {
            InitializeComponent();
            ipadd = ip;

            if (algoval == 1)
                sa = DES.Create();
            else if (algoval == 2)
                sa = Rijndael.Create();
            else if (algoval == 3)
                sa = RC2.Create();
            else if (algoval == 4)
                sa = TripleDES.Create();


            sa.Mode = CipherMode.ECB;
            sa.Padding = PaddingMode.PKCS7;
            sa.Key = key1;

            key = key1;
        }

        private void SessionKeyClient_Load(object sender, EventArgs e)
        {
            readThread = new Thread(new ThreadStart(RunClient));
            readThread.Start();
        }

        private void SessionKeyClient_FormClosing(object sender, FormClosingEventArgs e)
        {
            writer.Write("End Session");
            closeconenctions();
        }

        public void countdown()
        {
            do
            {
                //getting settings from the file
                FileStream a = new FileStream("KDC\\KDC Client\\timeout.txt", FileMode.OpenOrCreate, FileAccess.Read);
                int len = (int)a.Length;

                byte[] r = new byte[len];
                a.Read(r, 0, len);
                char[] t = Encoding.UTF8.GetChars(r);

                string tempval = "";
                for (int q = 0; q < t.Length; q++)
                    tempval += Convert.ToString(t[q]);
                a.Close();

                string[] s = tempval.Split(' ');
                mins = Convert.ToInt16(s[0]);
                secs = Convert.ToInt16(s[1]);

                //main timer starts here
                progressBar1.Maximum = (mins * 60) + secs + 1;
                progressBar1.Value = progressBar1.Maximum;
                DateTime future = DateTime.Now;
                future = future.AddMinutes(mins);
                future = future.AddSeconds(secs);

                int counter = 0;
                TimeSpan diff;
                int prev = 0;
                while (counter == 0)
                {
                    diff = future - DateTime.Now;

                    label5.Text = Convert.ToString(diff.Minutes + " : " + diff.Seconds);
                    if (prev != diff.Seconds)
                        progressBar1.Increment(-1);

                    if (diff.Minutes == 0 && diff.Seconds == 0)
                        counter = 1;
                    prev = diff.Seconds;
                }
                conti = false;

                DialogResult res = MessageBox.Show("Session Expired !! Press OK to get new Session Key, Cancel to Exit", "Warning", MessageBoxButtons.OKCancel);
                if (res == DialogResult.OK)
                {
                    writer.Write("New Key");
                    sa.GenerateKey();
                    tempkey = sa.Key;

                    sa.Key = key;

                    val = false;
                    newkeyparam = 1;
                    encryptkeyandsend();

                    sa.Key = tempkey;
                    key = tempkey;
                    conti = true;
                    resettimer = 1;
                }
                else if (res == DialogResult.Cancel)
                {
                    resettimer = 0;
                    message = "TERMINATE";
                    MessageBox.Show("End Of Session !!");
                    this.Close();
                }
            } while (resettimer == 1);
        }

        private bool checktimeout()
        {
            if (conti == true)
                return false;
            else
                return true;
        }

        public void RunClient()
        {
            // instantiate TcpClient for sending data to server
            try
            {
                //DisplayMessage("Attempting connection\r\n");

                // Step 1: create TcpClient and connect to server
                client = new TcpClient();
                client.Connect(ipadd, 50002);

                // Step 2: get NetworkStream associated with TcpClient
                output = client.GetStream();

                //get the starting time of communication
                conti = true;
                timer = new Thread(new ThreadStart(countdown));
                timer.Start();

                // create objects for writing and reading across stream
                writer = new BinaryWriter(output);
                reader = new BinaryReader(output);

                newkeyparam = 0;
                // loop until server signals termination
                do
                {
                    // Step 3: processing phase
                    try
                    {
                        val = checktimeout();

                        if (val == false) //when no timeout needed
                        {
                            // read message from server
                            message = reader.ReadString();
                            EncryptedIncommingMessageBox.Text += message;
                            EncryptedIncommingMessageBox.Text += "\r\n";

                            databyte = Convert.FromBase64String(message);
                            decryptincommingmessage(databyte);
                        }
                    } // end try
                    catch (Exception)
                    {
                        // handle exception if error in reading server data
                        //System.Environment.Exit(System.Environment.ExitCode);
                    } // end catch
                } while (message != "TERMINATE");

                // Step 4: close connection
                //closeconenctions();
                /*writer.Close();
                reader.Close();
                output.Close();
                client.Close();*/

                this.Close();

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

        private void encryptoutgoinmessage(string message)
        {
            byte[] r = Encoding.UTF8.GetBytes(message);
            MemoryStream ms = new MemoryStream();
            CryptoStream cs = new CryptoStream(ms, sa.CreateEncryptor(), CryptoStreamMode.Write);

            cs.Write(r, 0, r.Length);
            cs.Close();
            byte[] cipherbytes = ms.ToArray();
            ms.Close();

            //send encrypted data
            string temp = Convert.ToBase64String(cipherbytes);
            writer.Write(temp);

            if (newkeyparam == 0)
            {
                //display encrypted message
                EncryptedOutgoingMessageBox.Text = temp;
            }
            else
                newkeyparam = 0;
        }

        private void encryptkeyandsend()
        {
            string temp = "";
            for (int w = 0; w < tempkey.Length; w++)
            {
                char r1 = Convert.ToChar(tempkey[w]);
                temp += Convert.ToString(r1);
            }

            encryptoutgoinmessage(temp);
        }

        private void decryptincommingmessage(byte[] r1)
        {
            MemoryStream ms = new MemoryStream(r1);
            CryptoStream cs = new CryptoStream(ms, sa.CreateDecryptor(), CryptoStreamMode.Read);

            byte[] plainbyte = new Byte[r1.Length];
            cs.Read(plainbyte, 0, r1.Length);
            cs.Close();
            ms.Close();

            char[] plaintext = Encoding.UTF8.GetChars(plainbyte);
            for (int w = 0; w < plaintext.Length; w++)
                DecryptedIncommingMessageBox.Text += Convert.ToString(plaintext[w]);
            DecryptedIncommingMessageBox.Text += "\r\n";
        }

        private void OutgoingMessageBox_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter && OutgoingMessageBox.ReadOnly == false)
                {
                    encryptoutgoinmessage(OutgoingMessageBox.Text);
                    OutgoingMessageBox.Clear(); // clear the user's input
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
        }
    }
}