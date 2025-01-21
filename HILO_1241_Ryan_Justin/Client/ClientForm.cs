using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConnLibrary;
using System.Threading;
using System.Net.Sockets;
using System.Text.Json;
using Newtonsoft.Json;
using JSONCode;
using ConnectionDialogLibrary;

namespace Client
{
    public partial class ClientForm : Form
    {
        Thread _rxThread = null;
        Socket _ConnectedSocket = null;
        int PreviousGuess = 0;
        public ClientForm()
        {
            InitializeComponent();
            DisableUI();
            trkGuess.Value = (trkGuess.Maximum + trkGuess.Minimum) / 2;
        }

        private void trkGuess_Scroll(object sender, EventArgs e)
        {
            lblCurrentValue.Text = trkGuess.Value.ToString();
        }
        private void DisableUI()
        {
            btnGuess.Enabled = false;
            btnDisconnect.Enabled = false;
            btnConnect1.Enabled = true;
            btnConnect2.Enabled = true;
        }
        private void EnableUI()
        {
            btnGuess.Enabled = true;
            btnDisconnect.Enabled = true;
            btnConnect1.Enabled = false;
            btnConnect2.Enabled = false;
        }
        private void btnConnect1_Click(object sender, EventArgs e)
        {
            using (Connection connectionDialog = new Connection(Connection.dlgLaunch.DefaultEdit, "localhost", 1666))
            {
                DialogResult result = connectionDialog.ShowDialog();
                
                if(result == DialogResult.OK)
                {
                    MessageTextConnect("Connection Successful");
                    EnableUI();
                    _ConnectedSocket = connectionDialog.ConnectedSocket;
                    _rxThread = new Thread(RxThread);
                    _rxThread.IsBackground = true;
                    _rxThread.Start(connectionDialog.ConnectedSocket);
                }
                else
                {
                    MessageTextConnect("Connection Failed or Canceled");
                }
            }
        }
        private void RxThread(object obj)
        {
            Socket client = obj as Socket;
            if (client == null) return;
            byte[] buff = new byte[1024];
            int numBytes = 0;

            while (true)// until, disco
            {
                try
                {
                    numBytes = client.Receive(buff, SocketFlags.None);
                }
                catch (SocketException exc)
                {
                    MessageTextConnect("RxThread:" + exc.Message);
                    Invoke(new Action(() => DisableUI()));
                    return;
                }
                catch (Exception exc)
                {
                    MessageTextConnect("RxThread:GenericException" + exc.Message);
                    Invoke(new Action(() => DisableUI()));
                    return;
                }
                // Got here ? it was successful, BUT it may be 0 bytes indicating
                // A Soft Disconnect.
                if (numBytes == 0) // Soft Disco ? What now ?
                {
                    MessageTextConnect("Soft Disco Encountered");
                    Invoke(new Action(() => DisableUI()));
                    client = null; // ? maybe
                    return; // Why stay ? Socket is disconnected
                }

                string jsonResponse = Encoding.UTF8.GetString(buff, 0, numBytes);

                try
                {
                    GuessJSON response = JsonConvert.DeserializeObject<GuessJSON>(jsonResponse);
                    string serverMessage = "";
                    if(response.response == -1)
                    {
                        Invoke(new Action(() => trkGuess.Minimum = PreviousGuess)); 
                        Invoke(new Action(() => lblTrackbarMin.Text = PreviousGuess.ToString()));

                        serverMessage = "Your guess was to low";
                    }
                    else if(response.response == 0)
                    {
                        serverMessage = "Your guess was correct";
                        if (_ConnectedSocket == null || !_ConnectedSocket.Connected)
                        {
                            MessageTextConnect("Connection lost during response handling.");
                            Invoke(new Action(() => DisableUI()));
                            
                        }
                        Invoke(new Action(() =>
                        {
                            trkGuess.Maximum = 1000;
                            trkGuess.Minimum = 1;
                            lblTrackbarMax.Text = "1000";
                            lblTrackbarMin.Text = "1";
                        }));


                    }
                    else if(response.response == 1)
                    {
                        //trkGuess.Maximum = PreviousGuess;
                        Invoke(new Action(() => trkGuess.Maximum = PreviousGuess));
                        Invoke(new Action(() => lblTrackbarMax.Text = PreviousGuess.ToString()));
                        serverMessage = "Your guess was to high";
                    }
                    if(response != null)
                    {
                        MessageText($"Server: {serverMessage}");

                    }

                    Invoke(new Action(() => trkGuess.Value = (trkGuess.Maximum + trkGuess.Minimum) / 2));
                    Invoke(new Action(() => lblCurrentValue.Text = trkGuess.Value.ToString()));
                }
                catch (Exception exc)
                {
                    MessageTextConnect("Error parsing JSON: " + exc.Message);
                }
            }
        }
        private void btnGuess_Click(object sender, EventArgs e)
        {
            if(_rxThread == null || !_rxThread.IsAlive)
            {
                MessageTextConnect("Not Connected");
                DisableUI();
                return;
            }
            PreviousGuess = trkGuess.Value;
            int guess = trkGuess.Value;
            GuessJSON serverMessage = new GuessJSON { guess = guess };
            string message = JsonConvert.SerializeObject(serverMessage);
            byte[] guessBytes = Encoding.UTF8.GetBytes(message);


            try
            {
                if(_ConnectedSocket != null && _ConnectedSocket.Connected)
                {
                    int numBytesSent = _ConnectedSocket?.Send(guessBytes, SocketFlags.None) ?? 0;

                }
                else
                {
                    Text = "Socket Not COnnected";
                }
            }
            catch (Exception exc)
            {
                MessageTextConnect("1Error");
            }
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            _rxThread?.Abort();
            _rxThread = null;
            if (_ConnectedSocket != null && _ConnectedSocket.Connected)
            {
                _ConnectedSocket.Shutdown(SocketShutdown.Both);
                _ConnectedSocket.Close();
                _ConnectedSocket = null; 
            }
            DisableUI();
            MessageTextConnect("Disconnected");
        }
        private void MessageText(string s)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => MessageText(s)));
                return;
            }
            txtMessage.Text = s;
        }
        private void MessageTextConnect(string s)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => MessageTextConnect(s)));
                return;
            }
            Text = s;
        }
        private void btnConnect2_Click(object sender, EventArgs e)
        {
            using (ConnectionDialog connectionDialog = new ConnectionDialog(ConnectionDialog.dlgLauncher.DefaultEdit, "localhost", 1666))
            {
                DialogResult result = connectionDialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    MessageTextConnect("Connection Successful");
                    _ConnectedSocket = connectionDialog.ConnectedSocket;
                    _rxThread = new Thread(RxThread);
                    _rxThread.IsBackground = true;
                    _rxThread.Start(connectionDialog.ConnectedSocket);
                    EnableUI();
                }
                else
                {
                    MessageTextConnect("Connection Failed or Canceled");
                }
            }
        }
    }
}
