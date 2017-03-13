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

        private string[] SerialOpt = new string[6];
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

        
        

        // 연결 방법 선택 1 ~ 6 및 박스 색깔 변경 //
        private void RF_Tile_Click(object sender, EventArgs e)
        {
            OptionSelect(1);
        }      

        private void UART_Tile_Click(object sender, EventArgs e)
        {
            this.UART_Tile.Style = MetroFramework.MetroColorStyle.Pink; // 클릭시 박스 색 변경
            OptionSelect(2);           
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
                        this.metroPanel2.Visible = false;   // 기존 패널 숨기고
                        this.SerialPanel.Visible = true;    // 시리얼 패널 보이기
                        Serial_Combo_Init();
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




        // 시리얼 설정 부분 선택지    
        private void Serial_Combo_Init()
        {
            this.Serial_Combo_Port.DropDownStyle = ComboBoxStyle.DropDown;
            this.Serial_Combo_Baud.DropDownStyle = ComboBoxStyle.DropDown;
            this.Serial_Combo_Data.DropDownStyle = ComboBoxStyle.DropDown;
            this.Serial_Combo_FlowCon.DropDownStyle = ComboBoxStyle.DropDown;
            this.Serial_Combo_Parity.DropDownStyle = ComboBoxStyle.DropDown;
            this.Serial_Combo_StopBit.DropDownStyle = ComboBoxStyle.DropDown;

            serialport = new SerialPort();
            List<string> data = new List<string>();
            foreach (string s in SerialPort.GetPortNames())
            {
                data.Add(s);
            }
            Serial_Combo_Port.Items.AddRange(data.Cast<object>().ToArray());
            Serial_Combo_Port.SelectedIndex = 0;

            List<string> data2 = new List<string>();
            string [] Baud = { "4800", "9600","14400","19200" };
            foreach (string s in Baud)
            {
                data2.Add(s);
            }       
            Serial_Combo_Baud.Items.AddRange(data2.Cast<object>().ToArray());
            Serial_Combo_Baud.SelectedIndex = 0;

            List<string> data3 = new List<string>();
            string[] Data = {"7","8" };
            foreach (string s in Data)
            {
                data3.Add(s);
            }
            Serial_Combo_Data.Items.AddRange(data3.Cast<object>().ToArray());
            Serial_Combo_Data.SelectedIndex = 0;

            List<string> data4 = new List<string>();
            string[] Parity = {"odd","even","mark","space" };
            foreach (string s in Parity)
            {
                data4.Add(s);
            }
            Serial_Combo_Parity.Items.AddRange(data4.Cast<object>().ToArray());
            Serial_Combo_Parity.SelectedIndex = 0;

            List<string> data5 = new List<string>();
            string[] Stopbit = {"none","1 bit","2 bit","1.5 bit" };
            foreach (string s in Stopbit)
            {
                data5.Add(s);
            }
            Serial_Combo_StopBit.Items.AddRange(data5.Cast<object>().ToArray());
            Serial_Combo_StopBit.SelectedIndex = 0;

            List<string> data6 = new List<string>();
            string[] FlowCon = {"Xon/Xoff","hardware","none" };
            foreach (string s in FlowCon)
            {
                data6.Add(s);
            }
            Serial_Combo_FlowCon.Items.AddRange(data6.Cast<object>().ToArray());
            Serial_Combo_FlowCon.SelectedIndex = 0;
        }  

        // 선택시 이벤트
        private void Serial_Combo_Port_SelectedIndexChanged(object sender, EventArgs e)
        {
            SerialOpt[0] = Serial_Combo_Port.Text;
        }

        private void Serial_Combo_Baud_SelectedIndexChanged(object sender, EventArgs e)
        {
            SerialOpt[1] = Serial_Combo_Baud.Text;
        }

        private void Serial_Combo_Data_SelectedIndexChanged(object sender, EventArgs e)
        {
            SerialOpt[2] = Serial_Combo_Data.Text;
        }

        private void Serial_Combo_Parity_SelectedIndexChanged(object sender, EventArgs e)
        {
            SerialOpt[3] = Serial_Combo_Parity.Text;
        }

        private void Serial_Combo_StopBit_SelectedIndexChanged(object sender, EventArgs e)
        {
            SerialOpt[4] = Serial_Combo_StopBit.Text;
        }

        private void Serial_Combo_FlowCon_SelectedIndexChanged(object sender, EventArgs e)
        {
            SerialOpt[5] = Serial_Combo_FlowCon.Text;
        }

        private void Serial_Btn_OK_Click(object sender, EventArgs e)    // 시리얼 오~픈~!!
        {
            serial.SerialOpen(SerialOpt[0], SerialOpt[1], SerialOpt[2], SerialOpt[3], SerialOpt[4], "500", "500");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            serial.SerialSend(richTextBox1.Text);
        }
    }
}
