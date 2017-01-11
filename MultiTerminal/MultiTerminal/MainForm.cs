using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
namespace MultiTerminal
{
   
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {
        static int connectType = 0;
        TCPServer sTCP = new TCPServer();
        TCPClient cTCP = new TCPClient();
        static Ethernet ethernet = new Ethernet();
        //private metroUserControl1 usercontrol1 = new metroUserControl1();
        Client client = new Client();
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Style = MetroFramework.MetroColorStyle.Yellow;
            this.metroTile1.Style = MetroFramework.MetroColorStyle.Lime;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            switch(connectType)
            {
                case 1:
                    {
                        sTCP.Connect(Int32.Parse(this.metroTextBox2.Text));
                    }
                    break;
                case 2:
                    {
                        cTCP.Connect(metroTextBox1.Text,Int32.Parse(this.metroTextBox2.Text));
                    }
                    break;

                case 3:
                    {
                        ethernet.uServerOpen(Int32.Parse(this.metroTextBox2.Text));
                    }break;
                case 4:
                    {
                        ethernet.uClinetOpen(metroTextBox1.Text, Int32.Parse(this.metroTextBox2.Text));
                    }break;
                case 5:
                    {
                        //ethernet.ServerOpen(Int32.Parse(this.metroTextBox2.Text));
                    }break;
                case 6:
                    {
                        //client.StartClient(metroTextBox1.Text, Int32.Parse(this.metroTextBox2.Text));

                        //ethernet.ClinetOpen(metroTextBox1.Text, Int32.Parse(this.metroTextBox2.Text));
                    }
                    break;
            }
        }

        private void metroTile6_Click(object sender, EventArgs e)
        {
            connectType = 5;
        }

        private void metroTile7_Click(object sender, EventArgs e)
        {
            connectType = 6;
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            if(connectType==1)
            { 
                sTCP.Send((this.metroTextBox4.Text));
            }
            if (connectType == 2)
            {
                cTCP.Send((this.metroTextBox4.Text));
            }


            if (connectType == 3) //server측
            {
                string toclientmsg = ethernet.uSendToClient(this.metroTextBox4.Text);
                this.richTextBox1.Text += toclientmsg + "\n";

            }
            if (connectType == 4) //client 측
            {
                string toclientmsg = ethernet.uSendToServer(this.metroTextBox4.Text);
                this.richTextBox1.Text += toclientmsg + "\n";
            }

            if (connectType == 5) //server측
            {
                string toclientmsg = ethernet.SendToClient(this.metroTextBox4.Text);
                this.richTextBox1.Text += toclientmsg+"\n";

            }
            if (connectType == 6) //클라측
            {
                string toservermsg = client.Send(metroTextBox5.Text);
                this.richTextBox1.Text += toservermsg + "\n";
                //string toservermsg = ethernet.SendToServer(this.metroTextBox5.Text);
                //this.richTextBox1.Text += toservermsg + "\n";
            }

        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            if (connectType == 1)
            {
                sTCP.Recv();
               string recv =  sTCP.m_ReceiveQueue.Dequeue();

            }
            if (connectType == 2)
            {
                cTCP.Receive();
                string recv = cTCP.m_ReceiveQueue.Dequeue();

            }


            if (connectType == 3)
            {
                string recvclientmsg = ethernet.uRecvToClient();
                this.richTextBox2.Text += recvclientmsg + "\n";
            }
            if (connectType == 4)
            {
                string toservermsg = ethernet.uRecvToServer();
                this.richTextBox2.Text += toservermsg + "\n";

                //string recvservmsg = ethernet.RecvToServer();
                //this.richTextBox2.Text += recvservmsg + "\n";

            }


            if (connectType == 5)
            {
                string recvclientmsg = ethernet.RecvToClient();
                this.richTextBox2.Text += recvclientmsg + "\n";
            }
            if(connectType ==6)
            {
                string toservermsg = client.Receive();
                this.richTextBox2.Text += toservermsg + "\n";

                //string recvservmsg = ethernet.RecvToServer();
                //this.richTextBox2.Text += recvservmsg + "\n";

            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (ethernet.userverConnected() == true)
            {
                ethernet.uServerClose();
            }
            else if (ethernet.uclientConnected() == true)
            {
                ethernet.uClientClose();
            }


            if (ethernet.serverConnected() == true)
            {
                ethernet.ServerClose();
            }
            else if(ethernet.clientConnected() == true)
            {
                ethernet.ClientClose();
            }
            Process currentProcess = Process.GetCurrentProcess();
            currentProcess.Kill();
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            connectType = 3;
        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
            connectType = 4;

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            if (connectType == 3) //server측
            {
                ethernet.uServerClose();

            }
            if (connectType == 4) //client 측
            {
                ethernet.uClientClose();
            }

            if (connectType == 5) //server측
            {
                ethernet.ServerClose();

            }
            if (connectType == 6) //클라측
            {
                ethernet.ClientClose();
            }
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
           connectType = 1; //server측

        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            connectType = 2; //client측

        }
    }
}
