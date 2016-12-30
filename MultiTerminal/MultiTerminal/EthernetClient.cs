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
        private TcpClient m_Client = new TcpClient();
        private IPEndPoint DestinationEndPoint;
        public void Connect(string ipAddres, int ipPort)
        {
            this.DestinationEndPoint = new IPEndPoint(IPAddress.Parse(ipAddres), ipPort);
            m_Client.Connect(DestinationEndPoint);
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

        private void SendMessage(string msg)
        {
            NetworkStream clientStream = m_Client.GetStream();
            ASCIIEncoding encoder = new ASCIIEncoding();
            byte[] buffer = encoder.GetBytes(msg);

            clientStream.Write(buffer, 0, buffer.Length);
            clientStream.Flush();

            Byte[] data = new byte[256];

            string responseData = string.Empty;

            Int32 Bytes = clientStream.Read(data, 0, data.Length);
            responseData = Encoding.ASCII.GetString(data, 0, bytes);


           
        }
        private void Echo(string msg, ASCIIEncoding encoder, NetworkStream clientStream)
        {
            byte[] buffer = encoder.GetBytes(msg);

            clientStream.Write(buffer, 0, buffer.Length);
            clientStream.Flush();
        }

    }
}
