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
    class udpClient
    {
        private UdpClient client;
        private IPEndPoint ep;
        private IPEndPoint sender;
        private bool m_isConnected = false;
        public void Connect(string IP,int port)
        {
            client = new UdpClient(IP, port);
            ep = new IPEndPoint(IPAddress.Any, 0);
        }
        public string RecvMessage()
        {
            byte[] data = new byte[1024];
            if (client != null)
                data = client.Receive(ref ep);
            string sendData = Encoding.Default.GetString(data);

            if (sendData.Length > 0)
            {
                return sendData;
            }
            else
            {
                return "받은메시지가 없습니다.";
            }
        }
        public void SendMessage(string sendMsg)
        {
            byte[] data = new byte[1024];

            data = Encoding.Default.GetBytes(sendMsg);

            if (sendMsg.Length == 0)
            {
                Debug.WriteLine("메시지를 적으세요");
            }
            if (sendMsg == "끝")
            {
                Debug.WriteLine("보내지않습니다.");
            }
            else
            {
                if(client!=null)
                client.Send(data,data.Length);
            }
        }
        public void DisConnect()
        {
            client.Close();
        }
        public bool isConnected()
        {
            if (client != null)
            {
                if (client.Client.Connected == true)
                    m_isConnected = true;
                else
                    m_isConnected = false;
            }
            else m_isConnected = false;
            return m_isConnected;
        }


    }
}
