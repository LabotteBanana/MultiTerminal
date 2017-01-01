using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiTerminal
{
    class Ethernet
    {
       static EthernetClient client = new EthernetClient();
       static EthernetServer server = new EthernetServer();
       public bool serverConnected()
        {
            if (server.isConnected() == true)
            {
                return true;
            }
            else return false;
        }
        public bool clientConnected()
        {
            if (client.isConnected() == true)
            {
                return true;
            }
            else return false;
        }

        //서버 열기
        public void ServerOpen(int ipPort)
        {
            server.Connect(ipPort);
        }
        //서버 닫기
        public void ServerClose()
        {
            server.Disconnect();
        }
        //클라이언트 열기
        public void ClinetOpen(string ipAddres,int ipPort)
        {
            client.Connect(ipAddres, ipPort);
        }
        //클라이언트 닫기
        public void ClientClose()
        {
            client.Disconnect();
        }

        //클라에서 서버로 보내기
        public string SendToServer(string msg)
        {
            client.SendMessage(msg);
            return msg;
        }
        //서버에서 클라로 보내기
        public string SendToClient(string msg)
        {
            server.SendMessage(msg);
            return msg;
        }

        //클라에서 받은 서버메시지
        public string RecvToServer()
        {
            string msg =  client.RecvMessage();
            return msg;
        }
        //서버에서 받은 클라메시지
        public string RecvToClient()
        {
            string msg = server.RecvMessage();
            return msg;
        }
    }
}
