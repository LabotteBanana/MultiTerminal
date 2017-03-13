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
    class Tserv
    {
        private Socket sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
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

        public bool Connect(int port)
        {
            try
            {
                IPEndPoint ipep = new IPEndPoint(IPAddress.Any, port);
                sock.Bind(ipep);
                sock.Listen(30);//30초대기
                //Console.WriteLine("서버시작..대기중!");
                Socket client = sock.Accept();
                IPEndPoint claIP = (IPEndPoint)client.RemoteEndPoint;

                //Console.WriteLine("{0}주소,{1}포트 접속", claIP.Address, claIP.Port);

                sock.Send(Encoding.ASCII.GetBytes("Hello Client!"));
                if( sock.Receive(data) != 0 )
                {
                    Console.WriteLine(Encoding.Default.GetString(data));
                }
                else
                {
                    Console.WriteLine("수신 메시지 없음");
                }
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
            finally
            {
                if (sock != null) sock.Close();
            }
        }
        public bool DisConnect()
        {
            sock.Close();
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
