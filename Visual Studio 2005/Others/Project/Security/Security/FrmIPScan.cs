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

        private delegate void AddTreeNode(TreeNode node);

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

                ParseData(byteData, nReceived);
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
                button1.Text = "Block";
                MessageBox.Show("IP is Allowed");

            }
            else
            {
                isblocked = true;
                button1.Text = "Allow";
                MessageBox.Show("IP is Blocked");
            }

            /*
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

            */
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
                    cmbInterfaces.Items.Add(myip);
                }
            }    
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (cmbInterfaces.Text == "")
            {
                MessageBox.Show("Select an Interface to capture the packets.", "Security",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                if (!bContinueCapturing)
                {
                    //Start capturing the packets...

                    btnStart.Text = "&Stop";

                    bContinueCapturing = true;

                    //For sniffing the socket to capture the packets has to be a raw socket, with the
                    //address family being of type internetwork, and protocol being IP
                    mainSocket = new Socket(AddressFamily.InterNetwork,
                        SocketType.Raw, ProtocolType.IP);

                    //Bind the socket to the selected IP address
                    mainSocket.Bind(new IPEndPoint(IPAddress.Parse(cmbInterfaces.Text), 0));
                    // mainSocket.EndReceiveFrom(IPAddress.Parse("192.168.1.4"),0);                    //Set the socket  options
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
                else
                {

                    btnStart.Text = "&Start";
                    bContinueCapturing = false;
                    //To stop capturing the packets close the socket
                    mainSocket.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "MJsniffer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ParseData(byte[] byteData, int nReceived)
        {
            TreeNode rootNode = new TreeNode();

            //Since all protocol packets are encapsulated in the IP datagram
            //so we start by parsing the IP header and see what protocol data
            //is being carried by it
            IPHeader ipHeader = new IPHeader(byteData, nReceived);

            TreeNode ipNode = MakeIPTreeNode(ipHeader);
            rootNode.Nodes.Add(ipNode);

            //Now according to the protocol being carried by the IP datagram we parse 
            //the data field of the datagram
            switch (ipHeader.ProtocolType)
            {
                case Protocol.TCP:

                    TCPHeader tcpHeader = new TCPHeader(ipHeader.Data,              //IPHeader.Data stores the data being 
                        //carried by the IP datagram
                                                        ipHeader.MessageLength);//Length of the data field                    

                    TreeNode tcpNode = MakeTCPTreeNode(tcpHeader);

                    rootNode.Nodes.Add(tcpNode);

                    //If the port is equal to 53 then the underlying protocol is DNS
                    //Note: DNS can use either TCP or UDP thats why the check is done twice
                    if (tcpHeader.DestinationPort == "53" || tcpHeader.SourcePort == "53")
                    {
                        TreeNode dnsNode = MakeDNSTreeNode(tcpHeader.Data, (int)tcpHeader.MessageLength);
                        rootNode.Nodes.Add(dnsNode);
                    }

                    break;

                case Protocol.UDP:

                    UDPHeader udpHeader = new UDPHeader(ipHeader.Data,              //IPHeader.Data stores the data being 
                        //carried by the IP datagram
                                                       (int)ipHeader.MessageLength);//Length of the data field                    

                    TreeNode udpNode = MakeUDPTreeNode(udpHeader);

                    rootNode.Nodes.Add(udpNode);

                    //If the port is equal to 53 then the underlying protocol is DNS
                    //Note: DNS can use either TCP or UDP thats why the check is done twice
                    if (udpHeader.DestinationPort == "53" || udpHeader.SourcePort == "53")
                    {

                        TreeNode dnsNode = MakeDNSTreeNode(udpHeader.Data,
                            //Length of UDP header is always eight bytes so we subtract that out of the total 
                            //length to find the length of the data
                                                           Convert.ToInt32(udpHeader.Length) - 8);
                        rootNode.Nodes.Add(dnsNode);
                    }

                    break;

                case Protocol.Unknown:
                    break;
            }

            AddTreeNode addTreeNode = new AddTreeNode(OnAddTreeNode);

            rootNode.Text = ipHeader.SourceAddress.ToString() + "-" +
                ipHeader.DestinationAddress.ToString();

            //Thread safe adding of the nodes
            treeView.Invoke(addTreeNode, new object[] { rootNode });
        }

        //Helper function which returns the information contained in the IP header as a
        //tree node
        private TreeNode MakeIPTreeNode(IPHeader ipHeader)
        {
            TreeNode ipNode = new TreeNode();

            ipNode.Text = "IP";
            ipNode.Nodes.Add("Ver: " + ipHeader.Version);
            ipNode.Nodes.Add("Header Length: " + ipHeader.HeaderLength);
            ipNode.Nodes.Add("Differntiated Services: " + ipHeader.DifferentiatedServices);
            ipNode.Nodes.Add("Total Length: " + ipHeader.TotalLength);
            ipNode.Nodes.Add("Identification: " + ipHeader.Identification);
            ipNode.Nodes.Add("Flags: " + ipHeader.Flags);
            ipNode.Nodes.Add("Fragmentation Offset: " + ipHeader.FragmentationOffset);
            ipNode.Nodes.Add("Time to live: " + ipHeader.TTL);
            switch (ipHeader.ProtocolType)
            {
                case Protocol.TCP:
                    ipNode.Nodes.Add("Protocol: " + "TCP");
                    break;
                case Protocol.UDP:
                    ipNode.Nodes.Add("Protocol: " + "UDP");
                    break;
                case Protocol.Unknown:
                    ipNode.Nodes.Add("Protocol: " + "Unknown");
                    break;
            }
            ipNode.Nodes.Add("Checksum: " + ipHeader.Checksum);
            ipNode.Nodes.Add("Source: " + ipHeader.SourceAddress.ToString());
            ipNode.Nodes.Add("Destination: " + ipHeader.DestinationAddress.ToString());

            return ipNode;
        }

        //Helper function which returns the information contained in the TCP header as a
        //tree node
        private TreeNode MakeTCPTreeNode(TCPHeader tcpHeader)
        {
            TreeNode tcpNode = new TreeNode();

            tcpNode.Text = "TCP";

            tcpNode.Nodes.Add("Source Port: " + tcpHeader.SourcePort);
            tcpNode.Nodes.Add("Destination Port: " + tcpHeader.DestinationPort);
            tcpNode.Nodes.Add("Sequence Number: " + tcpHeader.SequenceNumber);

            if (tcpHeader.AcknowledgementNumber != "")
                tcpNode.Nodes.Add("Acknowledgement Number: " + tcpHeader.AcknowledgementNumber);

            tcpNode.Nodes.Add("Header Length: " + tcpHeader.HeaderLength);
            tcpNode.Nodes.Add("Flags: " + tcpHeader.Flags);
            tcpNode.Nodes.Add("Window Size: " + tcpHeader.WindowSize);
            tcpNode.Nodes.Add("Checksum: " + tcpHeader.Checksum);

            if (tcpHeader.UrgentPointer != "")
                tcpNode.Nodes.Add("Urgent Pointer: " + tcpHeader.UrgentPointer);

            return tcpNode;
        }

        //Helper function which returns the information contained in the UDP header as a
        //tree node
        private TreeNode MakeUDPTreeNode(UDPHeader udpHeader)
        {
            TreeNode udpNode = new TreeNode();

            udpNode.Text = "UDP";
            udpNode.Nodes.Add("Source Port: " + udpHeader.SourcePort);
            udpNode.Nodes.Add("Destination Port: " + udpHeader.DestinationPort);
            udpNode.Nodes.Add("Length: " + udpHeader.Length);
            udpNode.Nodes.Add("Checksum: " + udpHeader.Checksum);

            return udpNode;
        }

        //Helper function which returns the information contained in the DNS header as a
        //tree node
        private TreeNode MakeDNSTreeNode(byte[] byteData, int nLength)
        {
            DNSHeader dnsHeader = new DNSHeader(byteData, nLength);

            TreeNode dnsNode = new TreeNode();

            dnsNode.Text = "DNS";
            dnsNode.Nodes.Add("Identification: " + dnsHeader.Identification);
            dnsNode.Nodes.Add("Flags: " + dnsHeader.Flags);
            dnsNode.Nodes.Add("Questions: " + dnsHeader.TotalQuestions);
            dnsNode.Nodes.Add("Answer RRs: " + dnsHeader.TotalAnswerRRs);
            dnsNode.Nodes.Add("Authority RRs: " + dnsHeader.TotalAuthorityRRs);
            dnsNode.Nodes.Add("Additional RRs: " + dnsHeader.TotalAdditionalRRs);

            return dnsNode;
        }

        private void OnAddTreeNode(TreeNode node)
        {
            treeView.Nodes.Add(node);
        }
    }

}