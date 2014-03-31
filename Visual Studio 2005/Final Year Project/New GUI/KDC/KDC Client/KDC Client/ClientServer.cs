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
    public partial class ClientServer : Form
    {
        Mainpage parent;
        string ipadd;
        public string ipadd2;
        int counterv = 0;

        public ClientServer(Mainpage temp)
        {
            InitializeComponent();
            //ipadd = "172.16.8.237";

            parent = temp;

            IPHostEntry HosyEntry = Dns.GetHostEntry((Dns.GetHostName()));
            if (HosyEntry.AddressList.Length > 0)
            {
                foreach (IPAddress ip in HosyEntry.AddressList)
                {
                    ipadd = ip.ToString();
                }
            }    
        }

        private TcpListener listener;
        private Socket connection; // Socket for accepting a connection      
        private Thread readThread; // Thread for processing incoming messages
        private NetworkStream socketStream; // network data stream           
        private BinaryReader reader;
        private BinaryWriter writer;
        string data="";
        byte[] databyte = new byte[128];
        byte[] datahash = new byte[128];
        private NetworkStream rd;

        private void ClientServer_Load(object sender, EventArgs e)
        {
            readThread = new Thread(new ThreadStart(RunServer));
            readThread.Start();
        }

        private void ClientServer_FormClosing(object sender, FormClosingEventArgs e)
        {
            //closeconnections();
        }

        private delegate void DisplayDelegate(string message);

        private void DisplayMessage(string message)
        {
            // if modifying displayTextBox is not thread safe
            if (displayTextBox.InvokeRequired)
            {
                // use inherited method Invoke to execute DisplayMessage
                // via a delegate                                       
                Invoke(new DisplayDelegate(DisplayMessage), new object[] { message });
            } // end if
            else // OK to modify displayTextBox in current thread
                displayTextBox.Text += message;
        } // end method DisplayMessage


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
                listener = new TcpListener(local, 50001);

                // Step 2: TcpListener waits for connection request
                listener.Start();

                // Step 3: establish connection upon client request
                while (true)
                {
                    DisplayMessage("Waiting for connection\r\n");

                    // accept an incoming connection     
                    connection = listener.AcceptSocket();
                    counterv = 1;
                    count = 0;
                    // create NetworkStream object associated with socket
                    socketStream = new NetworkStream(connection);

                    // create objects for transferring data across stream
                    writer = new BinaryWriter(socketStream);
                    reader = new BinaryReader(socketStream);
                    rd = socketStream;

                    DisplayMessage("Connection " + counter + " received.\r\n");

                    // inform client that connection was successfull  
                    writer.Write("Connection successful");

                    string theReply = "";
                    
                    // Step 4: read string data sent from client
                    do
                    {
                        try
                        {
                            if (count == 0)
                            {
                                // read the string sent to the server
                                theReply = reader.ReadString();

                                displayTextBox.Text += theReply;
                                data = theReply;
                                rd.Read(databyte, 0, 128);
                                count++;
                            }
                            else if (count == 1)
                            {
                                rd.Read(datahash, 0, 128);
                                count++;
                            }
                        } // end try
                        catch (Exception)
                        {
                            // handle exception if error reading data
                            break;
                        } // end catch
                    } while (theReply != "TERMINATE" && connection.Connected);

                    DisplayMessage("\r\nUser terminated connection\r\n");

                    // Step 5: close connection  
                    writer.Close();
                    reader.Close();
                    socketStream.Close();
                    connection.Close();
                    listener.Stop();

                    counter++;
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
                writer.Close();
                reader.Close();
                socketStream.Close();
                connection.Close();
                listener.Stop();
            }
            else
            {
                listener.Stop();
            }
        }

        private void ExtractDataButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = data;
        }

        private void DecryptButton_Click(object sender, EventArgs e)
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();

            //public and private RSA parameters for encrypt
            StreamReader reader = new StreamReader("KDC\\KDC Client\\KDCPublicPrivateKey.xml");
            string publicPrivateKeyXML = reader.ReadToEnd();
            rsa.FromXmlString(publicPrivateKeyXML);
            reader.Close();

            //read ciphertext, decrypt it to plaintext
            byte[] plaintext = rsa.Decrypt(databyte, false); //fOAEP needs high encryption pack

            char[] a = Encoding.UTF8.GetChars(plaintext);
            for (int q = 0; q < a.Length; q++)
                textBox2.Text += Convert.ToString(a[q]);
           
            //verification

            //get key from the KDC for the user who send the data
            string user = "";
            int counter = 12;
            string temp = textBox2.Text;

            while (temp[counter] != ' ')
            {
                char x = temp[counter];
                user += x;
                counter++;
            }

            KDCDataSetTableAdapters.KeyDirectoryTableAdapter b = new KDC_Client.KDCDataSetTableAdapters.KeyDirectoryTableAdapter();
            byte[] key = (byte[])b.GetUserKey(user);

            char[] keytemp = Encoding.UTF8.GetChars(key);
            string keyxml = "";
            for (int y = 0; y < keytemp.Length; y++)
                keyxml += Convert.ToString(keytemp[y]);

            StreamWriter writer = new StreamWriter("KDC\\KDC Client\\KDCSignPublicOnlyKey.xml");
            string publicOnlyKeyXML = keyxml;
            writer.Write(publicOnlyKeyXML);
            writer.Close();
            
            SHA1 sha1 = new SHA1CryptoServiceProvider();
            byte[] msghsh = Encoding.UTF8.GetBytes(textBox2.Text);

            byte[] hashbytes = sha1.ComputeHash(msghsh);
            
            //create RSA object using parameters from signing
            RSACryptoServiceProvider rsa1 = new RSACryptoServiceProvider();

            StreamReader reader1 = new StreamReader("KDC\\KDC Client\\KDCSignPublicOnlyKey.xml");
            string publicPrivateKeyXML1 = reader1.ReadToEnd();
            rsa1.FromXmlString(publicPrivateKeyXML1);

            //do verification on hash using OID for SHA-1
            bool match = rsa1.VerifyHash(hashbytes, "1.3.14.3.2.26", datahash);

            if (match == true)
                MessageBox.Show("Digital Signature Verified");
            else
                MessageBox.Show("Signature Not Verified"); 
        }

        private void ExchangemessageButton_Click(object sender, EventArgs e)
        {
            //extract key and iv from the text(data) recived
            string obtaineddata = textBox2.Text;
            string[] ary = obtaineddata.Split(' ');
            string algo = ary[3].ToString();
            string key = ary[5].ToString();

            int algoval = 0;
            if(algo=="DES")
                algoval = 1;
            else if(algo=="Rijndael")
                algoval = 2;
            else if(algo=="RC2")
                algoval = 3;
            else if(algo=="TripleDES")
                algoval = 4;

            byte[] keyval = Convert.FromBase64String(key);

            //get ip address of the sender
            GetIP ip = new GetIP(this, parent,algoval, keyval);
            ip.MdiParent = parent;
            ip.Show();
            this.Close();
        }
    }
}