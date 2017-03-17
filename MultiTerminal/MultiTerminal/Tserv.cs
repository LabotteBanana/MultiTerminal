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
    class Tserv
    {
        public Socket server =null;
        public Socket client = null;
        Thread th= null;
        private string ip;
        private string client_ip;
        private int port;
        public NetworkInterface[] adapters = NetworkInterface.GetAllNetworkInterfaces();
        private byte[] data = new byte[1024];
        private NetworkStream ns = null;
        private StreamReader sr = null;
        private StreamWriter sw = null;
        public string Message;
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
            

        public Tserv(int Port) //순수 서버로 만들때
        {
            port = Port;
        }

        public Tserv(string IP,int Port) //순수 클라로 만들때
        {
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

                //Console.WriteLine("서버시작..대기중!");
                client = server.Accept();

                IPEndPoint claIP = (IPEndPoint)client.RemoteEndPoint;
                client_ip = claIP.Address.ToString();

                //ns = new NetworkStream(server);

                ns = new NetworkStream(client);
                sr = new StreamReader(ns);
                sw = new StreamWriter(ns);

                th = new Thread(new ThreadStart(RecvMsg)); //상대 문자열 수신
                th.Start();
            }
            catch(Exception ex)
            {
                //자꾸 이쪽으로 온다.
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
            //int total = 0;
            //int size = data.Length;
            //int left_data = size;
            //int send_data = 0;

            //// 전송할 데이터의 크기 전달
            //byte[] data_size = new byte[4];
            //data_size = BitConverter.GetBytes(size);
            //send_data = server.Send(data_size);
            ////동일한 내용?  //ns.Write(data, left_data, 4);

            ////실제 데이터 전송
            //while (total < size)
            //{
            //    send_data = server.Send(data, total, left_data, SocketFlags.None);
            //    total += send_data;
            //    left_data -= send_data;
            //}
        }
        public void RecvMsg()
        {
            try
            {
                while (client.Connected)
                {
                    string msg = sr.ReadLine();
                    Message = msg;
                    return;
                }
                //int total = 0;
                //int size = 0;
                //int left_data = 0;
                //int recv_data = 0;

                ////수신할 데이터 크기 알아내기
                //byte[] data_size = new byte[4];
                //recv_data = server.Receive(data_size, 0, 4, SocketFlags.None);
                ////동일한 내용? // ns.Read(data_size, left_data, 4);

                //size = BitConverter.ToInt32(data_size, 0);
                //left_data = size;

                //byte[] data = new byte[size];
                //while (total < size)
                //{
                //    recv_data = server.Receive(data, total, left_data, 0);
                //    if (recv_data == 0) break;
                //    total += recv_data;
                //    left_data -= recv_data;
                //}
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
