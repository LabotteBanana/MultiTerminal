using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiTerminal
{
    class Ethernet
    {
        EthernetClient client = new EthernetClient();
        EthernetServer server = new EthernetServer();

        public void ServerOpen(int ipPort)
        {
            server.Connect(ipPort);
        }
        public void ClinetOpen(string ipAddres,int ipPort)
        {
            client.Connect(ipAddres, ipPort);
        }
        public string sendToServer(string msg)
        {
            client.SendMessage(msg);
            return msg;
        }
        public string sendToClient(string msg)
        {
            server.WriteMessage(msg);
            return msg;
        }
    }
}
