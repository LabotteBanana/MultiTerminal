using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Diagnostics;
namespace MultiTerminal
{
    class udpServer
    {
        private IPEndPoint EP;
        private UdpClient server;
        private bool m_isConnected = false;
        public void Connect(int Port)
        {
            EP = new IPEndPoint(IPAddress.Any, Port);
            server = new UdpClient(EP);
        }
        public void SendMessage(string sendMsg)
        {
            byte[] data = new byte[1024];
            data = Encoding.UTF8.GetBytes(sendMsg);
            server.Send(data, data.Length, EP);
        }
        public string RecvMessage()
        {
            byte[] recv = new byte[1024];
            recv = server.Receive(ref EP);

            string recvMsg = Encoding.Default.GetString(recv);
            return recvMsg;
        }
        public void DisConnect()
        {
            server.Close();
        }
        public bool isConnected()
        {
            if (server.Client.Connected == true)
                m_isConnected = true;
            else
                m_isConnected = false;
            return m_isConnected;
        }


    }
}
