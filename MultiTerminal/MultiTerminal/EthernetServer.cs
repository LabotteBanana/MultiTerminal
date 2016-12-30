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

        public void Connect(string ipAddres, int ipPort)
        {
           this.m_Server = new TcpListener(IPAddress.Loopback, ipPort);
            this.listenThread = new Thread(new ThreadStart(ListenForClients));
            this.listenThread.Start();
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
                clientThread.Start(client);
            }
        }
        private void HandleClientComm(object client)
        {
            TcpClient tcpClient = (TcpClient)client;
            NetworkStream clientStream = tcpClient.GetStream();

            byte[] message = new byte[4096];
            string error;
            int bytesRead;

            while(true)
            {
                bytesRead = 0;
                try
                {
                    bytesRead = clientStream.Read(message, 0, 4096);
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
                ASCIIEncoding encoder = new ASCIIEncoding();

                ///byte to string
                string msg = encoder.GetString(message, 0, bytesRead);
                //통신을 통해서 받은 msg
                WriteMessage(msg);

                Echo(msg, encoder, clientStream);
            }
            tcpClient.Close();
        }
        private void WriteMessage(string msg)
        {
        }
        private void Echo(string msg, ASCIIEncoding encoder ,NetworkStream clientStream)
        {
            byte[] buffer = encoder.GetBytes(msg);

            clientStream.Write(buffer, 0, buffer.Length);
            clientStream.Flush();
        }
    };
}
