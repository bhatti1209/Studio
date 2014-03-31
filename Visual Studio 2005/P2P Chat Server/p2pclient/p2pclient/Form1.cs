﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using System.Net.Sockets;

namespace p2pclient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private NetworkStream output; // stream for receiving data           
        private BinaryWriter writer; // facilitates writing to the stream    
        private BinaryReader reader; // facilitates reading from the stream  
        private Thread readThread; // Thread for processing incoming messages
        private string message = "";

        private void Form1_Load(object sender, EventArgs e)
        {
            readThread = new Thread( new ThreadStart( RunClient ) );
            readThread.Start();                                     
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Environment.Exit(System.Environment.ExitCode);
        }

        private delegate void DisplayDelegate(string message);  

        private void DisplayMessage( string message )
        {
            // if modifying displayTextBox is not thread safe
            if ( displayTextBox.InvokeRequired )
            {
                 // use inherited method Invoke to execute DisplayMessage
                 // via a delegate                                       
                 Invoke( new DisplayDelegate( DisplayMessage ),new object[] { message } );                          
            } // end if
            else // OK to modify displayTextBox in current thread
                displayTextBox.Text += message;
        } // end method DisplayMessage

        private delegate void DisableInputDelegate(bool value);

        private void DisableInput( bool value )
        {
            if ( inputTextBox.InvokeRequired )
            {
                // use inherited method Invoke to execute DisableInput
                // via a delegate                                     
                Invoke( new DisableInputDelegate( DisableInput ),new object[] { value } );                          
            } // end if
            else // OK to modify inputTextBox in current thread
                inputTextBox.ReadOnly = value;
        } // end method DisableInput

        private void inputTextBox_KeyDown( object sender, KeyEventArgs e )
        {
            try
            {
                if ( e.KeyCode == Keys.Enter && inputTextBox.ReadOnly == false )
                {
                    writer.Write( "CLIENT>>> " + inputTextBox.Text );
                    displayTextBox.Text += "\r\nCLIENT>>> " + inputTextBox.Text;
                    inputTextBox.Clear();
                } // end if
            } // end try
            catch ( SocketException )
            {
                displayTextBox.Text += "\nError writing object";
            } // end catch
        } // end method inputTextBox_KeyDown

        public void RunClient()
        {
            TcpClient client;

            // instantiate TcpClient for sending data to server
            try
            {
                DisplayMessage( "Attempting connection\r\n" );

                // Step 1: create TcpClient and connect to server
                client = new TcpClient();
                client.Connect("172.16.8.225", 50000);            

                // Step 2: get NetworkStream associated with TcpClient
                output = client.GetStream();                          

                // create objects for writing and reading across stream
                writer = new BinaryWriter( output );                   
                reader = new BinaryReader( output );                   

                DisplayMessage( "\r\nGot I/O streams\r\n" );
                DisableInput( false ); // enable inputTextBox

                // loop until server signals termination
                do
                {
                    // Step 3: processing phase
                    try
                    {
                       // read message from server        
                       message = reader.ReadString();     
                       DisplayMessage( "\r\n" + message );
                    } // end try
                    catch ( Exception )
                    {
                       // handle exception if error in reading server data
                       System.Environment.Exit( System.Environment.ExitCode );
                    } // end catch
                } while ( message != "SERVER>>> TERMINATE" );

                // Step 4: close connection
                 writer.Close();            
                 reader.Close();            
                 output.Close();            
                 client.Close();            

                Application.Exit();
            } // end try
            catch ( Exception error )
            {
                // handle exception if error in establishing connection
                MessageBox.Show( error.ToString(), "Connection Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error );
                System.Environment.Exit( System.Environment.ExitCode );
            } // end catch

        } // end method RunClient
    }
}