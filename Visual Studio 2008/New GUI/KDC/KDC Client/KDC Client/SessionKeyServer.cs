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
    public partial class SessionKeyServer : Form
    {  
        byte[] key;
        int nk;
        int algo;
        SymmetricAlgorithm sa;
        int counterv = 0;
        string ipadd;
        int mins;
        int secs;

        public SessionKeyServer(int algoval, byte[] key1)
        {
            InitializeComponent();

            IPHostEntry HosyEntry = Dns.GetHostEntry((Dns.GetHostName()));
            if (HosyEntry.AddressList.Length > 0)
            {
                foreach (IPAddress ip in HosyEntry.AddressList)
                {
                    ipadd = ip.ToString();
                }
            }    

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
            algo = algoval;
        }

        private TcpListener listener;
        private Socket connection; // Socket for accepting a connection      
        private Thread readThread; // Thread for processing incoming messages
        private Thread timer;
        private NetworkStream socketStream; // network data stream 
        private BinaryReader reader; // facilitates reading from the stream  
        private BinaryWriter writer;
        byte[] databyte = new byte[128];
        private NetworkStream rd;

        private void SessionKeyServer_Load(object sender, EventArgs e)
        {
            readThread = new Thread(new ThreadStart(RunServer));
            readThread.Start();
        }

        private void SessionKeyServer_FormClosing(object sender, FormClosingEventArgs e)
        {
            //closeconnections();
        }

        private delegate void DisplayDelegate(string message);

        private void DisplayMessage(string message)
        {
            // if modifying displayTextBox is not thread safe
            if (EncryptedIncommingMessageBox.InvokeRequired)
            {
                // use inherited method Invoke to execute DisplayMessage
                // via a delegate                                       
                Invoke(new DisplayDelegate(DisplayMessage), new object[] { message });
            } // end if
            else // OK to modify displayTextBox in current thread
                EncryptedIncommingMessageBox.Text += message;
        } // end method DisplayMessage

        public void countdown()
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
        }

        public void RunServer()
        {
            int counter = 1;
            int count = 0;

            // wait for a client connection and display the text
            // that the client sends
            try
            {
                // Step 1: create TcpListener                    
                IPAddress local = IPAddress.Parse(ipadd);
                listener = new TcpListener(local, 50002);

                // Step 2: TcpListener waits for connection request
                listener.Start();

                // Step 3: establish connection upon client request
                while (true)
                {
                    // accept an incoming connection     
                    connection = listener.AcceptSocket();
                    counterv = 1;
                    count = 0;

                    //start timer
                    timer = new Thread(new ThreadStart(countdown));
                    timer.Start();

                    // create NetworkStream object associated with socket
                    socketStream = new NetworkStream(connection);
                    reader = new BinaryReader(socketStream);
                    writer = new BinaryWriter(socketStream);

                    rd = socketStream;
                    string theReply = "";
                    nk = 0;

                    // Step 4: read string data sent from client
                    do
                    {
                        try
                        {
                            theReply = reader.ReadString();

                            if (theReply == "New Key")
                            {
                                nk = 1;                                
                                count = 0;
                                OutgoingMessageBox.ReadOnly = true;
                            }
                            else if (theReply == "End Session")
                            {
                                MessageBox.Show("Session Has Been Ended !!");
                                //this.Close();
                            }
                            else
                            {
                                if (nk == 0)
                                {
                                    EncryptedIncommingMessageBox.Text += theReply;
                                    EncryptedIncommingMessageBox.Text += "\r\n";

                                    databyte = Convert.FromBase64String(theReply);
                                    decryptincommingmessage(databyte);

                                    if (count == 0)
                                    {
                                        OutgoingMessageBox.ReadOnly = false;
                                        count++;
                                    }
                                }
                                else if (nk == 1)
                                {
                                    databyte = Convert.FromBase64String(theReply);
                                    decryptincommingmessage(databyte);
                                    nk = 0;
                                    count = 0;
                                    timer.Abort();
                                    timer = new Thread(new ThreadStart(countdown));
                                    timer.Start();
                                    MessageBox.Show("New Key Obtained !!");
                                }
                            }
                    
                        } // end try
                        catch (Exception)
                        {
                            // handle exception if error reading data
                            //break;
                        } // end catch
                    } while (theReply != "End Session" && connection.Connected);

                    // Step 5: close connection  
                    /*reader.Close();
                    writer.Close();
                    socketStream.Close();
                    connection.Close();
                    listener.Stop();
                    */
                    counter++;
                    this.Close();
                } // end while
            } // end try
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            } // end catch
        }
        // end method RunServer

        private void closeconnections()
        {
            if (counterv == 1)
            {
                socketStream.Close();
                reader.Close();
                writer.Close();
                connection.Close();
                listener.Stop();
            }
            else
            {
                listener.Stop();
            }
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

            //display encrypted message
            EncryptedOutgoingMessageBox.Text = temp;
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
            string val = "";
            for (int w = 0; w < plaintext.Length; w++)
                 val += Convert.ToString(plaintext[w]);

             if (nk == 0)
             {
                 DecryptedIncommingMessageBox.Text += val;
                 DecryptedIncommingMessageBox.Text += "\r\n";
             }

            if (nk == 1)
            {
                string t1 = "";

                if (algo == 1)
                {
                    for (int q = 0; q < 8; q++)
                        t1 += val[q].ToString();
                }
                else if (algo == 2)
                {
                    for (int q = 0; q < 32; q++)
                        t1 += val[q].ToString();
                }
                else if (algo == 3)
                {
                    for (int q = 0; q < 16; q++)
                        t1 += val[q].ToString();
                }
                else if (algo == 4)
                {
                    for (int q = 0; q < 24; q++)
                        t1 += val[q].ToString();
                }

                byte[] ty = new byte[t1.Length];
                for (int z = 0; z < t1.Length; z++)
                    ty[z] = Convert.ToByte(t1[z]);

                key = ty;
                sa.Key = key;
            }
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