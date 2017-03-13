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
using System.IO.Ports;
using InTheHand.Net.Bluetooth;

namespace MultiTerminal
{
   
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {
        static int connectType = 0;
        static Ethernet ethernet = new Ethernet();
        //private metroUserControl1 usercontrol1 = new metroUserControl1();
        Client client = new Client();

        public SerialPort serialPort;

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
                case 5:
                    {
                        ethernet.ServerOpen(Int32.Parse(this.metroTextBox2.Text));
                    }break;
                case 6:
                    {
                        client.StartClient(metroTextBox1.Text, Int32.Parse(this.metroTextBox2.Text));
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
            if(ethernet.serverConnected() == true)
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

        //COMPortComboBox Data Load
        private void COMportComboBox_Load(object sender, EventArgs e)
        {
            COMportComboBox.DropDownStyle = ComboBoxStyle.DropDown;
            serialPort = new SerialPort();
            List<string> data = new List<string>();
            

            foreach (string s in SerialPort.GetPortNames())
            {
                data.Add(s);
            }
            COMportComboBox.Items.AddRange(data.Cast<object>().ToArray());
            COMportComboBox.SelectedIndex = 0;

        }

        private void metroTile2_Click(object sender, EventArgs e)
        {

        }
    }
}