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

namespace KDC_Server
{
    public partial class StandAloneServer : Form
    {
        string ipadd;

        public StandAloneServer()
        {
            InitializeComponent();
            //ipadd = "172.16.8.237";

            IPHostEntry HosyEntry = Dns.GetHostEntry((Dns.GetHostName()));
            if (HosyEntry.AddressList.Length > 0)
            {
                foreach (IPAddress ip in HosyEntry.AddressList)
                {
                    ipadd = ip.ToString();
                }
            }   
        }

        private Socket connection; // Socket for accepting a connection      
        private Thread readThread; // Thread for processing incoming messages
        private NetworkStream socketStream; // network data stream           
        private BinaryReader reader;
        private BinaryWriter writer;

        private void StandAloneServer_Load(object sender, EventArgs e)
        {
            readThread = new Thread(new ThreadStart(RunServer));
            readThread.Start();
        }

        private void StandAloneServer_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Environment.Exit(System.Environment.ExitCode);
            Application.Exit();
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

        private delegate void DisableInputDelegate(bool value);

        private void DisableInput(bool value)
        {
            // if modifying inputTextBox is not thread safe
            if (inputTextBox.InvokeRequired)
            {
                // use inherited method Invoke to execute DisableInput
                // via a delegate                                     
                Invoke(new DisableInputDelegate(DisableInput), new object[] { value });
            } // end if
            else // OK to modify inputTextBox in current thread
                inputTextBox.ReadOnly = value;
        } // end method DisableInput

        private void inputTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            // send the text to the client

            try
            {
                if (e.KeyCode == Keys.Enter && inputTextBox.ReadOnly == false)
                {
                    // if the user at the server signaled termination
                    // sever the connection to the client
                    if (inputTextBox.Text == "TERMINATE")
                        connection.Close();
                    inputTextBox.Clear(); // clear the user's input
                } // end if
            } // end try
            catch (SocketException)
            {
                displayTextBox.Text += "\nError writing object";
            } // end catch

        } // end method inputTextBox_KeyDown

        public void getkey(string theReply)
        {
            KDCDataSetTableAdapters.KeyDirectoryTableAdapter a = new KDC_Server.KDCDataSetTableAdapters.KeyDirectoryTableAdapter();
            byte[] publickey = (byte[])a.GetPublicKey(theReply);

            char[] temp = Encoding.UTF8.GetChars(publickey);
            string key = "";

            for (int q = 0; q < temp.Length; q++)
                key += temp[q];

            writer.Write(key);

            displayTextBox.Text += "\r\nSERVER>>> Public Key Of " + theReply + " Send To Client";
        }

        public void RunServer()
        {
            TcpListener listener;
            int counter = 1;

            // wait for a client connection and display the text
            // that the client sends
            try
            {
                // Step 1: create TcpListener                    
                IPAddress local = IPAddress.Parse(ipadd);
                listener = new TcpListener(local, 50000);

                // Step 2: TcpListener waits for connection request
                listener.Start();

                // Step 3: establish connection upon client request
                while (true)
                {
                    DisplayMessage("Waiting for connection\r\n");

                    // accept an incoming connection     
                    connection = listener.AcceptSocket();

                    // create NetworkStream object associated with socket
                    socketStream = new NetworkStream(connection);

                    // create objects for transferring data across stream
                    writer = new BinaryWriter(socketStream);
                    reader = new BinaryReader(socketStream);

                    DisplayMessage("Connection " + counter + " received.\r\n");

                    // inform client that connection was successfull  
                    //writer.Write("SERVER>>> Connection successful");

                    DisableInput(false); // enable inputTextBox

                    string theReply = "";

                    // Step 4: read string data sent from client
                    do
                    {
                        try
                        {
                            // read the string sent to the server
                            theReply = reader.ReadString();

                            KDCDataSetTableAdapters.KeyDirectoryTableAdapter a = new KDC_Server.KDCDataSetTableAdapters.KeyDirectoryTableAdapter();
                            int count = (int)a.CheckLogin(theReply);

                            if (count == 1)
                            {
                                //get the user public key
                                getkey(theReply);
                            }
                            else
                            {
                                if (theReply != "TERMINATE")
                                {
                                    writer.Write("Invalid User Please Enter Correct Username");
                                    displayTextBox.Text += "\r\nSERVER>>> Invalid User ..Enter Correct Username";
                                }
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

                    DisableInput(true); // disable InputTextBox
                    counter++;
                } // end while
            } // end try
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            } // end catch
        }
        // end method RunServer
    }
}