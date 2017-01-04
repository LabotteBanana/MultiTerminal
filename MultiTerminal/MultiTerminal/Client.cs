using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Diagnostics;
namespace MultiTerminal
{
    /// <summary>
    /// Async 비동기식 클라이언트
    /// </summary>
    class Client
    {
        private static ManualResetEvent ConnectDone = new ManualResetEvent(false);
        private static ManualResetEvent SendDone = new ManualResetEvent(false);
        private static ManualResetEvent ReceivceDone = new ManualResetEvent(false);


        public static Socket client;
        public static Queue<string> m_ReceiveQueue = new Queue<string>();
        private string serverAddress = string.Empty;
        private int serverPort = 0;
        private static String response = String.Empty;

        public  void StartClient(string ipAddress, int Port)
        {
            try
            {
                serverAddress = ipAddress;
                serverPort = Port;
                client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                Connect();
            }
            catch (Exception e)
            {
               Debug.WriteLine(e.ToString());
            }
        }
        public void Connect()
        {
            IPEndPoint DesetionEndPoint = new IPEndPoint(IPAddress.Parse(serverAddress), serverPort);

            client.BeginConnect(DesetionEndPoint, new AsyncCallback(ConnectCallback), client);

        }

        private void ConnectCallback(IAsyncResult ar)
        {
            try
            {
                client = (Socket)ar.AsyncState;

                client.EndConnect(ar);

                Debug.WriteLine("Socket Connected to {0}", client.RemoteEndPoint.ToString());

                ConnectDone.Set();
            }
            catch(Exception e)
            {
                Debug.WriteLine(e.ToString());
            }
        }

        public string Receive()
        {
            byte []buffer = new byte[1024];
            try
            {
                client.BeginReceive(buffer, 0, buffer.Length, 0, new AsyncCallback(ReceiveCallback),client);
                ASCIIEncoding encoder = new ASCIIEncoding();
                string responseData = encoder.GetString(buffer, 0, buffer.Length);
                m_ReceiveQueue.Enqueue(responseData);
                return m_ReceiveQueue.Dequeue();

            }
            catch (Exception e)
            {
                Debug.WriteLine(e.ToString());
                return e.ToString();
            }
        }
        private void ReceiveCallback(IAsyncResult ar)
        {
            try
            {
                client = (Socket)ar.AsyncState;

                int byteReceive = client.EndReceive(ar);
                ReceivceDone.Set();
            }
            catch (SocketException se)
            {
                if (se.SocketErrorCode == SocketError.ConnectionReset)
                {
                    Connect();
                }

                    else
                {
                    Debug.WriteLine(se.ToString());
                }
            }
        }

        public string Send(String data)
        {

            byte[] byteData = Encoding.ASCII.GetBytes(data);
            try
            {
                client.BeginSend(byteData, 0, byteData.Length, 0, new AsyncCallback(SendCallback), client);
                ASCIIEncoding encoder = new ASCIIEncoding();
                string responseData = encoder.GetString(byteData,0,byteData.Length);
                return responseData;
            }
            catch(Exception e)
            {
                Debug.WriteLine(e.ToString());
                return e.ToString();
            }
         }


        private void SendCallback(IAsyncResult ar)
        {
            try
            {
                Socket client = (Socket)ar.AsyncState;

                int byteSent = client.EndSend(ar);

                SendDone.Set();
            }
            catch(Exception e)
            {
                Debug.WriteLine(e.ToString());
            }
        }
    }
}
