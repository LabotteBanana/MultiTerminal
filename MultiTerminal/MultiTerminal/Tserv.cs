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
    public class Tserv
    {
        MainForm main = null;
        public Socket server =null;
        public Socket client = null;
        Thread th= null; //Recv가능 쓰레드
        private string ip;
        private string client_ip;
        private int port;
        public NetworkInterface[] adapters = NetworkInterface.GetAllNetworkInterfaces();
        private NetworkStream ns = null;
        private StreamReader sr = null;
        private StreamWriter sw = null;
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
            

        public Tserv(MainForm Main,int Port) //서버로 만들때
        {
            main = Main;
            port = Port;
        }

        public Tserv(MainForm Main,string IP,int Port) //클라로 만들때
        {
            main = Main;
            port = Port;
            ip = IP;
        }

        public void ServerStart()
        {
            try
            {
                IPEndPoint ipep = new IPEndPoint(IPAddress.Any, port);
                server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                server.Bind(ipep);
                server.Listen(30);//30초대기

                client = server.Accept();

                IPEndPoint claIP = (IPEndPoint)client.RemoteEndPoint;
                client_ip = claIP.Address.ToString();

                ns = new NetworkStream(client);
                sr = new StreamReader(ns);
                sw = new StreamWriter(ns);

                th = new Thread(new ThreadStart(RecvMsg)); //상대 문자열 수신 쓰레드 가동
                th.Start();
            }
            catch(Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString());
            }
        }

        public string Get_MyIP()
        {
            IPHostEntry host = Dns.GetHostEntry(Dns.GetHostName());
            string myip = host.AddressList[0].ToString();
            return myip;
        }

        //채팅 서버와 연결 시도
        public bool Connect()
        {
            try
            {

                IPEndPoint ipep = new IPEndPoint(IPAddress.Parse(ip), port);
                client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                client.Connect(ipep);
                client_ip = ip;

                ns = new NetworkStream(client);
                sr = new StreamReader(ns);
                sw = new StreamWriter(ns);

                th = new Thread(new ThreadStart(RecvMsg));
                th.Start();

                return true;
            }
            catch(Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString());
                return false;
            }
        }

        //채팅 서버 프로그램 중지
        public void ServerStop()
        {
            try
            {
                if (ns != null) ns.Close();
                if (sw != null) sw.Close();
                if (sr != null) sr.Close();
                if (client != null) client.Close();
                if ((th != null) && (th.IsAlive)) th.Abort();

                server.Close();
            }
            catch(Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        //채팅 서버와의 연결 종료
        public void DisConnect()
        {
            try
            {
                if (client != null)
                {
                    if (client.Connected)
                    {
                        if (ns != null) ns.Close();
                        if (sw != null) sw.Close();
                        if (sr != null) sr.Close();
                        client.Close();

                        if (th.IsAlive)
                            th.Abort();
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        public void SendMsg(string msg)
        {
            try
            {
                if (client.Connected)
                {
                    sw.WriteLine(msg);
                    sw.Flush();
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("전송 실패");
                }
            }
            catch(Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString());

            }
        }
        public void RecvMsg()
        {
            try
            {
                while (client.Connected)
                {
                    string msg = sr.ReadLine();
                    main.richTextBox2.Text += "수신 : "+ msg + "\n";

                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
        public void GetState()
        {

        }
        public void SetState()
        {

        }
        public void SetDelay(int timer)
        {
            this.server.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.SendTimeout, timer);
        }

    }
}
