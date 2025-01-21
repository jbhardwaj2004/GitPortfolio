using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
//using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Collections.Specialized;
using System.Net;
using System.Diagnostics;

namespace TAPChat
{
    public partial class Form1 : Form
    {        
        UdpClient udpSending;
        UdpClient udpRecieving;
        BindingSource bindingSource = new BindingSource();
        List<string> knownIPs = new List<string>();      
        Dictionary<string, string> IPNicknamePairs = new Dictionary<string, string>();
        

        public Form1()
        {
            InitializeComponent();

            string hostName = Dns.GetHostName();
            string hostIp = Dns.GetHostByName(hostName).AddressList[0].ToString();

            knownIPs.Add(hostIp);


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtMessage.KeyDown += new KeyEventHandler(MessageKeyDown);

            //UdpClient can throw a SocketException when binding, this allows us to debug should that occur.
            try
            {
                udpSending = new UdpClient();
                udpRecieving = new UdpClient(1666);
            }
            catch (SocketException sockExc) { Console.WriteLine(sockExc.ErrorCode); }
            
        }

        /// <summary>
        /// Event handler for the pressing of keys while in the message box.
        /// </summary>
        /// <param name="sender">The message box.</param>
        /// <param name="e">The data from the key being pressed.</param>
        private void MessageKeyDown(object sender, KeyEventArgs e)
        {
            //Send the message upon pressing Enter.
            if (e.KeyCode == Keys.Enter)
            {
                //Test code.
                string message = txtMessage.Text;
                lstMessageDisplay.Items.Add(message);
                txtMessage.Clear();
            }
        }

        //async Task<string> Listener()
        //{            
        //    await udpRecieving.ReceiveAsync();
            
        //}

        async Task SendAsync(string message, bool includeKnownIPs)
        {
            byte[] messageBytes = Encoding.UTF8.GetBytes(message);

            List<IPEndPoint> targets = new List<IPEndPoint>((IEnumerable<IPEndPoint>)knownIPs);

            if(IPAddress.TryParse(txtIpAddress.Text, out IPAddress targetIP))
            {
                targets.Add(new IPEndPoint(targetIP, 1666));
            }

            if(includeKnownIPs)
            {
                message += " | Known IPs: " + string.Join(",", knownIPs);
            }

            foreach(IPEndPoint target in targets)
            {
                try
                {
                    int bytesSent = await udpSending.SendAsync(messageBytes, messageBytes.Length, target);
                    Trace.WriteLine($"Sent {bytesSent} bytes to {target.Address}");
                }
                catch(Exception ex)
                {
                    Trace.WriteLine("Error sending message: " + ex.Message);
                }
            }
        }

    }

    //Class to decode our received JSON string into.
    public class JSONDecode
    {
        public string message { get; set; }
        public string nickname { get; set; }
        public List<string> ips { get; set; }

        public JSONDecode(string message, string nickname, List<string> ips)
        {
            this.message = message;
            this.nickname = nickname;
            this.ips = ips;
        }
    }
}
