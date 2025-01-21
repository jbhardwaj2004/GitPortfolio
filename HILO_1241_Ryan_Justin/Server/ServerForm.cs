using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Text.Json;
using JSONCode;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using System.Runtime.InteropServices;

namespace Server
{
    public partial class ServerForm : Form
    {
        Random random = new Random();

        int randNum;

        Socket _listener = null;
        Socket _client = null;

        Thread rxThread = null;
        public ServerForm()
        {
            InitializeComponent();

            
            Listener();
            
        }
        private void Listener()
        {
            try
            {
                if (_listener == null)
                {
                    _listener = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
                    _listener.Bind(new IPEndPoint(IPAddress.Any, 1666));
                    _listener.Listen(1);
                }

                // Start accepting connections
                _listener.BeginAccept(cbEndAccept, null);
            }
            catch (Exception ex)
            {
                MessageText(ex.ToString());
            }
        }
        private void cbEndAccept(IAsyncResult ar)
        {
            try
            {
                Socket client = _listener.EndAccept(ar);
                _client = client;
                _client.NoDelay = true;
                MessageText("Connected");
                randNum = random.Next(1, 1001);
                Invoke((MethodInvoker)(() => lblNum.Text = "Secret Number : " + randNum.ToString()));
                _listener?.Close();
                _listener = null;
                rxThread = new Thread(ReceiveGuesses)
                {
                    IsBackground = true
                };
                rxThread.Start(_client);


            }
            catch (Exception exc)
            {
                MessageText(exc.ToString());
            }

        }
        private void MessageText(string s)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => MessageText(s)));
                return;
            }
            Text = s;
        }
        private void ReceiveGuesses(object clientObj)
        {
            Socket client = clientObj as Socket;
            byte[] buffer = new byte[1024]; 
            int numBytes;

            while (true)
            {
                try
                {
                    numBytes = client.Receive(buffer);
                    if (numBytes == 0) // Client disconnected
                    {
                        client.Shutdown(SocketShutdown.Both);
                        client.Close();
                        _client = null;
                        Listener();
                        return;
                    }

                    var recieved = Encoding.UTF8.GetString(buffer, 0, numBytes);
                    GuessJSON newGuess;
     
                    newGuess = JsonConvert.DeserializeObject<GuessJSON>(recieved);

                    int guess = newGuess.guess;

                    GuessJSON response = ProcessGuess(guess);

                        string jsonResponse = JsonConvert.SerializeObject(response);
                        byte[] jsonBytes = Encoding.UTF8.GetBytes(jsonResponse);

                        client.Send(jsonBytes);

                        Invoke((MethodInvoker)(() => Text = $"Guess Recieved : {guess}"));

                        if (chkReplay.Checked == false)
                        {
                            if (response.response == 0)
                            {

                                if (_client != null && _client.Connected)
                                {
                                    _client.Shutdown(SocketShutdown.Both);
                                    _client.Close();
                                    _client = null;
                                    Listener();
                                return;
                                    
                                }
                                MessageText("Server - Disconnected");
                            }
                        }

                }
                catch (Exception exc)
                {
                    MessageText("Error receiving data: " + exc.Message);
                    
                }
            }
        }
        private GuessJSON ProcessGuess(int guess)
        {
            if(guess < randNum)
            {
                int response = (int)GuessJSON.GuessResponse.Low;
                return new GuessJSON
                {
                    response = response
                };
            }
            else if(guess > randNum)
            {
                int response = (int)GuessJSON.GuessResponse.High;
                return new GuessJSON
                {
                    response = response
                };
            }
            else if(guess == -2)
            {
                return new GuessJSON
                {
                    response = -2
                };
            }
            else 
            {
                int response = (int)GuessJSON.GuessResponse.Correct;

                if (chkReplay.Checked == true)
                {
                    randNum = random.Next(1, 1001); // Generate a new number

                    Invoke((MethodInvoker)(() => lblNum.Text = "Secret Number : " + randNum.ToString()));
                    

                }

                return new GuessJSON
                {
                    response = response
                    
                };
            }
            
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            try
            {
                rxThread?.Abort();
                rxThread = null;
                if (_client != null && _client.Connected)
                {
                    _client.Shutdown(SocketShutdown.Both);
                    _client.Close(); 
                    _client = null;
                    Listener();
                }
                MessageText("Server - Disconnected");
            }
            catch (Exception ex)
            {
                MessageText(ex.ToString());
            }
        }
    }
}
