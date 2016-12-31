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
        private string myMessage = "";
        private static TcpClient m_Client;
        private IPEndPoint DestinationEndPoint;
        private NetworkStream clientToserver;
        public void Connect(string ipAddres, int ipPort)
        {
            m_Client = new TcpClient();
            this.DestinationEndPoint = new IPEndPoint(IPAddress.Parse(ipAddres), ipPort);
            m_Client.Connect(DestinationEndPoint);
            clientToserver = m_Client.GetStream();
        }
        //private void RtbClientKeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyData != Keys.Enter || e.KeyData != Keys.Return)
        //    {
        //        myMessage += (char)e.KeyValue;
        //    }
        //    else
        //    {
        //        SendMessage(myMessage);
        //        myMessage = "";

        //    }
        //}

        public void SendMessage(string msg)
        {
            ASCIIEncoding encoder = new ASCIIEncoding();
            byte[] buffer = encoder.GetBytes(msg);

            clientToserver.Write(buffer, 0, buffer.Length);
            clientToserver.Flush();
        }
        public string RecvMessage()
        {

            Byte[] data = new byte[4096];

            string responseData = string.Empty;

            Int32 Bytes = clientToserver.Read(data, 0, data.Length);
            responseData = Encoding.ASCII.GetString(data, 0, Bytes);

            return responseData;
           
        }
        public void Disconnect()
        {
            m_Client.Close();
        }
    }
}
