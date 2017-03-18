using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;
using System.Net.NetworkInformation;

namespace MultiTerminal
{
    class Ucla
    {
        private Socket sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Udp);
        public NetworkInterface[] adapters = NetworkInterface.GetAllNetworkInterfaces();
        private byte[] data = new byte[1024];

        public bool Connect()
        {
            return true;
        }
        public bool DisConnect()
        {
            return true;

        }
        public string SendMsg()
        {
            return "Hello";
        }
        public string RecvMsg()
        {
            return "Bye";
        }
        public void GetState()
        {

        }
        public void SetState()
        {

        }


    }
}
