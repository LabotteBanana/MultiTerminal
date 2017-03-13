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

namespace MultiTerminal
{
   
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {
        static int connectType = 0;
        static Ethernet ethernet = new Ethernet();
        static Serial serial = new Serial();
        SerialPort serialport;

        Client client = new Client();
        //private metroUserControl1 usercontrol1 = new metroUserControl1();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)  // 폼 열렸을 때
        {
            this.Style = MetroFramework.MetroColorStyle.Yellow;
            //usercontrol1.Init();
            //this.Controls.Add(usercontrol1);
            //usercontrol1.Show();
        }

        private void MainForm_Closed(object sender, FormClosedEventArgs e)  // 메인폼 닫혔을 때 
        {
            serial.DisConSerial();
        }

        
        

        // 연결 방법 선택 1 ~ 6 //
        private void RF_Tile_Click(object sender, EventArgs e)
        {
            OptionSelect(1);
        }      

        private void UART_Tile_Click(object sender, EventArgs e)
        {
            OptionSelect(2);
            this.UART_Tile.Style = MetroFramework.MetroColorStyle.Pink; // 클릭시 박스 색 변경
        }
        private void WIFI_Tile_Click(object sender, EventArgs e)
        {
            OptionSelect(3);
        }
        private void Zigbee_Tile_Click(object sender, EventArgs e)
        {
            OptionSelect(4);
        }
        private void Server_Tile_Click(object sender, EventArgs e)
        {
            OptionSelect(5);
            this.Server_Tile.Style = MetroFramework.MetroColorStyle.Black;
        }

        private void Client_Tile_Click(object sender, EventArgs e)
        {
            OptionSelect(6);
            this.Client_Tile.Style = MetroFramework.MetroColorStyle.White;
        }


        // UI 기능 함수
        private void Change_Color(int connectType)
        {

        }


        // 연결 번호에 따른 각기 다른 옵션패널 띄우는 함수 //
        private void OptionSelect(int OptionNumber)  // 연결 버튼
        {
            switch (OptionNumber)
            {
                case 1:
                    break;
                case 2:
                    {

                        this.Serial_Combo_Port.DropDownStyle = ComboBoxStyle.DropDown;
                        serialport = new SerialPort();
                        List<string> data = new List<string>();
                        foreach (string s in SerialPort.GetPortNames())
                        {
                            data.Add(s);
                        }
                        Serial_Combo_Port.Items.AddRange(data.Cast<object>().ToArray());
                        Serial_Combo_Port.SelectedIndex = 0;

                        //serial.SerialOpen(this.SeriPort.Text, this.BaudRate.Text);      // 시리얼 오픈
                    }
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    {                       
                        ethernet.ServerOpen(Int32.Parse(this.metroTextBox2.Text));
                    }
                    break;
                case 6:
                    {                       
                        client.StartClient(metroTextBox1.Text, Int32.Parse(this.metroTextBox2.Text));
                    }
                    break;
            }
        }

        private void DisConBtn_Click(object sender, EventArgs e)    // 연결 해제 버튼
        {
            if (connectType == 2) //시리얼
            {
                serial.DisConSerial();
            }
        }


        private void SendBtn_Click(object sender, EventArgs e)      // 보내기 버튼
        {
            if (connectType == 2) //시리얼
            {
                string toserialmsg = serial.SerialSend(this.richTextBox1.Text); // 시리얼 값 받아오기
                this.richTextBox1.Text += toserialmsg + "\n";                   // 시리얼 텍스트박스에 표현
            }
            if (connectType == 5) //server측
            {
                string toclientmsg = ethernet.SendToClient(this.BaudRate.Text);
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

        private void ReceiveBtn_Click(object sender, EventArgs e)   // 받기 버튼
        {

            if (connectType == 2)
            {
                this.richTextBox2.Text += serial.receivedata + "\n";       // 시리얼 전역변수에서 받아서 텍스트박스에 표현
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

        
    }
}
