using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Net.Sockets;
using System.Net;
using System.Diagnostics;

namespace MultiTerminal
{

    public class StateObject
    {
        // Client socket.
        public Socket workSocket = null;
        // Size of receive buffer.
        public const int BufferSize = 256;
        // Receive buffer.
        public byte[] buffer = new byte[BufferSize];
        // Received data string.
        public StringBuilder sb = new StringBuilder();
    }

    class TCPClient
    {
        public static Socket m_Client;
        //SocketAsyncEventArgs sockEvent = new SocketAsyncEventArgs();
        public Queue<string> m_ReceiveQueue = new Queue<string>();

        private ManualResetEvent connectDone =
     new ManualResetEvent(false);
        private  ManualResetEvent sendDone =
            new ManualResetEvent(false);
        private  ManualResetEvent receiveDone =
            new ManualResetEvent(false);
        private static String response = String.Empty;
        public void Connect(string ip, int port)
        {
            try
            {
                IPEndPoint remoteEP = new IPEndPoint(IPAddress.Parse(ip), port);

                // Create a TCP/IP socket.
                m_Client = new Socket(AddressFamily.InterNetwork,
                    SocketType.Stream, ProtocolType.Tcp);

                // Connect to the remote endpoint.
                m_Client.BeginConnect(remoteEP,
                    new AsyncCallback(ConnectCallback), m_Client);
                connectDone.WaitOne();
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.ToString());
            }
        }
        public void Close()
        {
            m_Client.Shutdown(SocketShutdown.Both);
            m_Client.Close();
        }
        private void ConnectCallback(IAsyncResult ar)
        {
            try
            {
                // Retrieve the socket from the state object.
                Socket client = (Socket)ar.AsyncState;

                // Complete the connection.
                client.EndConnect(ar);

                Debug.WriteLine("Socket connected to {0}",
                    client.RemoteEndPoint.ToString());

                // Signal that the connection has been made.
                connectDone.Set();
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.ToString());
            }
        }

        public void Receive()
        {
            try
            {
                // Create the state object.
                StateObject state = new StateObject();
                state.workSocket = m_Client;

                // Begin receiving the data from the remote device.
                m_Client.BeginReceive(state.buffer, 0, StateObject.BufferSize, 0,
                    new AsyncCallback(ReceiveCallback), state);
                receiveDone.WaitOne();

            }
            catch (Exception e)
            {
                Debug.WriteLine(e.ToString());
            }
        }

        private void ReceiveCallback(IAsyncResult ar)
        {
            try
            {
                // Retrieve the state object and the client socket 
                // from the asynchronous state object.
                StateObject state = (StateObject)ar.AsyncState;
                Socket client = state.workSocket;

                // Read data from the remote device.
                int bytesRead = client.EndReceive(ar);

                if (bytesRead > 0)
                {
                    // There might be more data, so store the data received so far.
                    state.sb.Append(Encoding.ASCII.GetString(state.buffer, 0, bytesRead));
                    m_ReceiveQueue.Enqueue(state.sb.ToString());
                    // Get the rest of the data.
                    client.BeginReceive(state.buffer, 0, StateObject.BufferSize, 0,
                        new AsyncCallback(ReceiveCallback), state);
                }
                else
                {
                    // All the data has arrived; put it in response.
                    if (state.sb.Length > 1)
                    {
                        response = state.sb.ToString();
                    }
                    // Signal that all bytes have been received.
                    receiveDone.Set();
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.ToString());
            }
        }

        public void Send(String data)
        {
            // Convert the string data to byte data using ASCII encoding.
            byte[] byteData = Encoding.ASCII.GetBytes(data);

            // Begin sending the data to the remote device.
            m_Client.BeginSend(byteData, 0, byteData.Length, 0,
                new AsyncCallback(SendCallback), m_Client);
            sendDone.WaitOne();

        }

        private void SendCallback(IAsyncResult ar)
        {
            try
            {
                // Retrieve the socket from the state object.
                Socket client = (Socket)ar.AsyncState;

                // Complete sending the data to the remote device.
                int bytesSent = client.EndSend(ar);
                Debug.WriteLine("Sent {0} bytes to server.", bytesSent);

                // Signal that all bytes have been sent.
                sendDone.Set();
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.ToString());
            }
        }
    }
}