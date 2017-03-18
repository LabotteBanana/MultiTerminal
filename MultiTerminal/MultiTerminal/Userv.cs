using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;
using System.Net.NetworkInformation;
using System.IO;

namespace MultiTerminal
{
    class Userv
    {
        private Socket sock = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
        private IPEndPoint ipep;
        public NetworkInterface[] adapters = NetworkInterface.GetAllNetworkInterfaces();
        private byte[] data = new byte[1024];
        private NetworkStream ns;
        private StreamReader sr;
        private StreamWriter sw;

        public bool Connect(int port)
        {
            ipep = new IPEndPoint(IPAddress.Any, port); //내 서버소켓주소
            sock.Bind(ipep);

            Console.WriteLine("서버시작..대기중!");


            ns = new NetworkStream(sock);
            sr = new StreamReader(ns);
            sw = new StreamWriter(ns);


            if (sock.Connected == true)
                return true;
            else
                return false;

        }
        public bool DisConnect()
        {
            return true;

        }
        public void SendMsg(byte[] data)
        {
            //for (int i = 0; i < 10; i++)
            //{
            //data = Encoding.Default.GetBytes("Send data: [" + i + "]");
            sock.SendTo(data, data.Length, SocketFlags.None, ipep);
            //}
            return;
        }
        public byte[] RecvMsg()
        {
            IPEndPoint sender = new IPEndPoint(IPAddress.Any, 0);
            EndPoint remote = (EndPoint)(sender); //보낼지점

            int recv_size = sock.ReceiveFrom(data, ref remote);
            Console.WriteLine("{0} : 수신데이터 : {1}", remote.ToString(), Encoding.Default.GetString(data, 0, recv_size));
            return data;
        }
        public void GetState()
        {

        }
        public void SetState()
        {

        }
        public void SetDelay(int timer)
        {
            this.sock.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.SendTimeout, timer);
        }

        //직렬화는 데이터들을 객체화하여 직접적인 사용가능(패킷형태로 묶을때 사용가능)
    }
}
