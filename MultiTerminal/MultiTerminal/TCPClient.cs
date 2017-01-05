using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Net.Sockets;
using System.Net;

namespace MultiTerminal
{
    class TCPClient :  Object
    {
        public String m_IP;
        public int m_Port;
        public static Socket m_Server;
        public string Err;
        SocketAsyncEventArgs sockEvent = new SocketAsyncEventArgs();
        public void Connect(String ip, int port)
        {
            m_IP = ip;
            m_Port = port;
            try
            {
                m_Server = new Socket(SocketType.Stream, ProtocolType.Tcp);
                IPEndPoint ep = new IPEndPoint(IPAddress.Parse(ip), port);
                bool isBlock = m_Server.Blocking;
                m_Server.Bind(ep);
                m_Server.AcceptAsync(sockEvent);
            }
            catch(Exception e)
            {
                Err = e.ToString();
            }
        }
        private void SendCallBack(IAsyncResult ar)
        {

        }
        public static void SendMsg(string msg)
        {
            byte[]  buffer = new byte[1024];
            buffer = ASCIIEncoding.ASCII.GetBytes(msg);
            m_Server.BeginSend(buffer, 0, new AsyncCallback(SendCallBack), 0);
        }

    }
}
