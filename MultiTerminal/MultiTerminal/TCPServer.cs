using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Net.Sockets;
using System.Net;
using System.Diagnostics;
/// <summary>
/// 블록킹되면 안됌
/// </summary>
namespace MultiTerminal
{
    class TCPServer
    {
        private static ManualResetEvent ConnectDone = new ManualResetEvent(false);
        private static ManualResetEvent SendDone = new ManualResetEvent(false);
        private static ManualResetEvent ReceivceDone = new ManualResetEvent(false);
        private static ManualResetEvent AcceptDone = new ManualResetEvent(false);
        public static Queue<string> m_ReceiveQueue = new Queue<string>();

        public int m_Port;
        private Socket m_Server;
        public void Connect(int port)
        {
            m_Port = port;

            m_Server = new Socket(AddressFamily.InterNetwork,SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint ep = new IPEndPoint(IPAddress.Any, port);
            m_Server.Blocking= false;
            m_Server.Bind(ep);
            m_Server.Listen(100);
            m_Server.BeginAccept(new AsyncCallback(AcceptCallback), m_Server);
        }
        private void AcceptCallback(IAsyncResult ar)
        {
            AcceptDone.Set();

            Socket listener = (Socket)ar.AsyncState;
            Socket handler = listener.EndAccept(ar);

            m_Server = handler;
            handler.BeginReceive(buffer, 0, buffer.length, new AsyncCallback(ReceiveCallback), 0); 
        }
        private void ConnectCallback(IAsyncResult ar)
        {
            try
            {
                m_Server = (Socket)ar.AsyncState;

                m_Server.EndConnect(ar);

                Debug.WriteLine("Socket Connected to {0}", m_Server.RemoteEndPoint.ToString());

                ConnectDone.Set();
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.ToString());
            }
        }

        public string Receive()
        {
            byte[] buffer = new byte[1024];
            try
            {
                m_Server.BeginReceive(buffer, 0, buffer.Length, 0, new AsyncCallback(ReceiveCallback), 0);
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
                m_Server = (Socket)ar.AsyncState;

                int byteReceive = m_Server.EndReceive(ar);
                ReceivceDone.Set();
            }
            catch (SocketException se)
            {
                    Debug.WriteLine(se.ToString());
            }
        }

        public string Send(String data)
        {

            byte[] byteData = Encoding.ASCII.GetBytes(data);
            try
            {
                m_Server.BeginSend(byteData, 0, byteData.Length, 0, new AsyncCallback(SendCallback), 0);
                ASCIIEncoding encoder = new ASCIIEncoding();
                string responseData = encoder.GetString(byteData, 0, byteData.Length);
                return responseData;
            }
            catch (Exception e)
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
                client.Shutdown(SocketShutdown.Both);
                client.Close();
                SendDone.Set();
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.ToString());
            }
        }
    }
}
