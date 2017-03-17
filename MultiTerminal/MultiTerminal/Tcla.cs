using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Net.Sockets;
using System.Net;
using System.Net.NetworkInformation;
using System.IO;
namespace MultiTerminal
{
    class Tcla
    {
        public Socket client;
        private NetworkStream ns;
        private StreamReader sr;
        private StreamWriter sw;

        //clientThread.Start();

        //clientThread.IsAlive == true -> clientThread.Abort();

        public NetworkInterface[] adapters = NetworkInterface.GetAllNetworkInterfaces();

        private byte[] data = new byte[1024];
        public void DisplayNetworkInfo()
        {
            foreach (NetworkInterface adapter in adapters)
            {
                IPInterfaceProperties adapterProperties = adapter.GetIPProperties();
                GatewayIPAddressInformationCollection Gatewayaddress = adapterProperties.GatewayAddresses;
                IPAddressCollection dhcpServers = adapterProperties.DhcpServerAddresses;
                IPAddressCollection dnsServers = adapterProperties.DnsAddresses;

                /*
                Console.WriteLine("네트워크 카드 : "+adapter.Description);   //하드웨어 타입
                Console.WriteLine("Physical Address : "+adapter.GetPhysicalAddress()); //피지컬 주소
                Console.WriteLine("IP Address : " + Get_MyIP()); // 내 IP주소
                */

                if (Gatewayaddress.Count > 0)
                {
                    foreach (GatewayIPAddressInformation address in Gatewayaddress)
                    {
                        Console.WriteLine("GateWay Address :" + address.Address.ToString()); //게이트웨이 주소
                    }
                }
                if (dhcpServers.Count > 0)
                {
                    foreach (IPAddress dhcp in dhcpServers)
                    {
                        Console.WriteLine("DHCP Servers : " + dhcp.ToString()); //DHCP 주소
                    }
                }
                if (dnsServers.Count > 0)
                {
                    foreach (IPAddress dns in dnsServers)
                    {
                        Console.WriteLine("DNS Servers : " + dns.ToString()); //DNS 주소
                    }
                }

            }
        }
        public string Get_MyIP()
        {
            IPHostEntry host = Dns.GetHostEntry(Dns.GetHostName());
            string myip = host.AddressList[0].ToString();
            return myip;
        }

        public bool Connect(string ip, int port)
        {
            try
            {
                IPAddress host = IPAddress.Parse(ip);
                IPEndPoint ipep = new IPEndPoint(host, port);
                //ns = new NetworkStream(sock);

                //sr = new StreamReader(ns);
                //sw = new StreamWriter(ns);
                Socket sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                sock.Connect(ipep);
                //sock.Send(Encoding.ASCII.GetBytes("Hello Server!"));
                //sock.Receive(data);
                client = sock;
                if (sock.Connected == true)
                    return true;
                else
                    return false;
            }
            catch (SocketException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
        public bool DisConnect()
        {
            client.Close();
            return true;
        }
        public bool SendMsg(byte[] data)
        {
            try
            {
                int total = 0;
                int size = data.Length;
                int left_data = size;
                int send_data = 0;

                // 전송할 데이터의 크기 전달
                byte[] data_size = new byte[4];
                data_size = BitConverter.GetBytes(size);
                send_data = client.Send(data_size);
                //동일한 내용?  //ns.Write(data, left_data, 4);
                //실제 데이터 전송
                while (total < size)
                {
                    send_data = client.Send(data, total, left_data, SocketFlags.None);
                    total += send_data;
                    left_data -= send_data;
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
        public byte[] RecvMsg()
        {
            try
            {
                int total = 0;
                int size = 0;
                int left_data = 0;
                int recv_data = 0;

                //수신할 데이터 크기 알아내기
                byte[] data_size = new byte[4];
                recv_data = client.Receive(data_size, 0, 4, SocketFlags.None);
                //동일한 내용? // ns.Read(data_size, left_data, 4);
                size = BitConverter.ToInt32(data_size, 0);
                left_data = size;

                byte[] data = new byte[size];
                while (total < size)
                {
                    recv_data = client.Receive(data, total, left_data, 0);
                    if (recv_data == 0) break;
                    total += recv_data;
                    left_data -= recv_data;
                }
                return data;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }

        }
        public void GetState()
        {

        }
        public void SetDelay(int timer)
        {
            this.client.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.SendTimeout, timer);
        }
    }
}
