using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
namespace Security
{
    public partial class FrmIPScan : Form
    {
        Boolean isblocked;
        private Socket mainSocket;                          //The socket which captures all incoming packets
        private byte[] byteData = new byte[4096];
        private bool bContinueCapturing = false;
        string myip;

        public FrmIPScan()
        {
            InitializeComponent();
        }

        private void OnReceive(IAsyncResult ar)
        {
            try
            {

                int nReceived = mainSocket.EndReceive(ar);

                //Analyze the bytes received...

                //ParseData(byteData, nReceived);
                IPHeader sourceip = new IPHeader(byteData, nReceived);
                //if(sourceip.SourceAddress.ToString
                //MessageBox.Show(sourceip.SourceAddress.ToString());
                if (sourceip.SourceAddress.ToString() == txtIP.Text)
                {
                    if (isblocked == true)
                    {
                        //mainSocket.Disconnect(true);
                        mainSocket.Close();
                    }

                }
                else
                {
                    if (bContinueCapturing)
                    {
                        byteData = new byte[4096];

                        //Another call to BeginReceive so that we continue to receive the incoming
                        //packets
                        mainSocket.BeginReceive(byteData, 0, byteData.Length, SocketFlags.None,
                            new AsyncCallback(OnReceive), null);
                    }
                }
            }
            catch (ObjectDisposedException)
            {
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "MJsniffer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        int checkip(string ip)
        {
            string temp;

            int l, l1;
            l = ip.Length;
            temp = ip.Replace(".", "");
            l1 = temp.Length;
            if (l - l1 == 3)
                return (1);
            else
                return (0);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtIP.Text.Length <= 0)
            {
                MessageBox.Show("Please Enter IP Address ");

                return;
            }
            else
            {
                int i;

                i = checkip(txtIP.Text.ToString());
                if (i == 0)
                {
                    MessageBox.Show("Invalid IP Address");
                    return;
                }

            }


            if (isblocked == true)
            {
                isblocked = false;
                button1.Text = "Allow";
                MessageBox.Show("IP is Allowed");

            }
            else
            {
                isblocked = true;
                button1.Text = "Block";
                MessageBox.Show("IP is Blocked");
            }

            //address family being of type internetwork, and protocol being IP
            mainSocket = new Socket(AddressFamily.InterNetwork,
                SocketType.Raw, ProtocolType.IP);

            //Bind the socket to the selected IP address
           //Put Your Computer IP Here Inplace of txtIP.text
            mainSocket.Bind(new IPEndPoint(IPAddress.Parse(myip), 0));
            
            //Set the socket  options
            mainSocket.SetSocketOption(SocketOptionLevel.IP,            //Applies only to IP packets
                                       SocketOptionName.HeaderIncluded, //Set the include the header
                                       true);                           //option to true

            byte[] byTrue = new byte[4] { 1, 0, 0, 0 };
            byte[] byOut = new byte[4];

            //Socket.IOControl is analogous to the WSAIoctl method of Winsock 2
            mainSocket.IOControl(IOControlCode.ReceiveAll,              //Equivalent to SIO_RCVALL constant
                //of Winsock 2
                                 byTrue,
                                 byOut);

            //Start receiving the packets asynchronously
            mainSocket.BeginReceive(byteData, 0, byteData.Length, SocketFlags.None,
                new AsyncCallback(OnReceive), null);


        }

        private void FrmIPScan_Load(object sender, EventArgs e)
        {
            string strIP = null;
            isblocked = false;
            IPHostEntry HosyEntry = Dns.GetHostEntry((Dns.GetHostName()));
            if (HosyEntry.AddressList.Length > 0)
            {
                foreach (IPAddress ip in HosyEntry.AddressList)
                {
                    strIP = ip.ToString();
                    myip = strIP;
                    this.Text = "My IP Address is : " + myip;
                }
            }    
        }
    }

}