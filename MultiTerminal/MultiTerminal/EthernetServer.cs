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

    class EthernetServer
    {
        private TcpListener m_Server;
        private Thread listenThread;
        private int m_ClientCount = 0 ;
        ASCIIEncoding encoder = new ASCIIEncoding();
        NetworkStream Stream;
        private Queue<string> m_RecvQueue;
        public void Connect(int ipPort)
        {
           this.m_Server = new TcpListener(IPAddress.Loopback, ipPort);
            this.listenThread = new Thread(new ThreadStart(ListenForClients));
            this.listenThread.Start();
        }
        public void Disconnect()
        {
            listenThread.Abort();
            m_Server.Stop();
        }
        private void ListenForClients()
        {
            m_Server.Start();
            while(true)  //Never ends until server is closed
            {
                //block형 connect to handle communication
                TcpClient client = this.m_Server.AcceptTcpClient();
                m_ClientCount++;

                ///create a thread to handle communication
                Thread clientThread = new Thread(new ParameterizedThreadStart(HandleClientComm));
                m_RecvQueue = new Queue<string>();
                clientThread.Start(client);
            }
        }
        private void HandleClientComm(object client)
        {
            TcpClient tcpClient = (TcpClient)client;
            Stream = tcpClient.GetStream();

            byte[] message = new byte[4096];
            int bytesRead;

            while(true)
            {
                bytesRead = 0;
                try
                {
                    bytesRead = Stream.Read(message, 0, 4096);
                }
                catch
                {
                    tcpClient.SendTimeout = 5;
                    ///a socket erro has occured
                }

                if(bytesRead == 0)
                {
                    ///client disconnect from server
                    m_ClientCount--;
                    break;
                }
                ///success received

                ///byte to string
                string msg = encoder.GetString(message, 0, bytesRead);
                m_RecvQueue.Enqueue(msg);
            }
            tcpClient.Close();
        }
        public string RecvMessage()
        {
            string msg = m_RecvQueue.Dequeue();
            return msg;
        }
        public void SendMessage(string msg)
        {
            byte[] buffer = encoder.GetBytes(msg);

            Stream.Write(buffer, 0, buffer.Length);
            Stream.Flush();
        }
    };
}
