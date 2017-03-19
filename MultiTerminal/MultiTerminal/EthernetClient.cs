using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace MultiTerminal
{
    class EthernetClient
    {
        private Thread m_ClientThread;
        private Queue<string> m_RecvQueue = new Queue<string>();
        private static TcpClient m_Client;
        public static bool m_isConnected =false;
        private IPEndPoint DestinationEndPoint;
        ASCIIEncoding encoder = new ASCIIEncoding();

        private NetworkStream Stream;
        public bool isConnected()
        {
            if (m_Client.Connected == true)
                m_isConnected = true;
            else
                m_isConnected = false;
            return m_isConnected;
        }
        public void Connect(string ipAddres, int ipPort)
        {
            m_Client = new TcpClient();
            this.DestinationEndPoint = new IPEndPoint(IPAddress.Parse(ipAddres), ipPort);
            m_ClientThread = new Thread(new ThreadStart(StartComm));
        }
        private void StartComm()
        {
                m_Client.Connect(DestinationEndPoint);
                Stream = m_Client.GetStream();
                Thread clientThread = new Thread(new ParameterizedThreadStart(HandleComm));
                clientThread.Start();
        }
        private void HandleComm(object client )
        {
            m_Client = (TcpClient)client;
            //clientToserver = m_Client.GetStream();

            byte[] message = new byte[1024];
            int bytesRead;
            while(true)
            {
                bytesRead = 0;
                try
                {
                    bytesRead = Stream.Read(message, 0, 1024);
                }
                catch
                {
                    m_Client.SendTimeout = 5;
                }
                if(bytesRead == 0)
                {
                    break;
                }
                string msg = encoder.GetString(message, 0, bytesRead);
                m_RecvQueue.Enqueue(msg);
            }
        }

        public void SendMessage(string msg)
        {
            byte[] buffer = encoder.GetBytes(msg);

            Stream.Write(buffer, 0, buffer.Length);
            Stream.Flush();
        }
        public string RecvMessage()
        {
            string msg = m_RecvQueue.Dequeue();
            return msg;
           
        }
        public void Disconnect()
        {
            m_Client.Close();
        }
    }
}
