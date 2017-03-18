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
using System.Threading;

namespace MultiTerminal
{
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {
        static int connectType = 1;
        static public int Chk_Hexa_Flag = 0;
        static Ethernet ethernet = new Ethernet();
        public Serial serial = new Serial();
        //public RichTextBox rich = new RichTextBox();
        private string[] SerialOpt = new string[6];
        Client client = new Client();

        
        
        
        public MainForm()
        {
            
            InitializeComponent();    
            //Application.Idle +=  new SerialDataReceivedEventHandler(serial.sPort_DataReceivedHandle);
        }

        private void MainForm_Load(object sender, EventArgs e)  // 폼 열렸을 때
        {
            this.Style = MetroFramework.MetroColorStyle.Yellow;

            //rich.KeyUp += Enter_Rich;
            //rich.Parent = this;
            

        }

       

        private void MainForm_Closed(object sender, FormClosedEventArgs e)  // 메인폼 닫혔을 때 
        {
            
            //serial.DisConSerial();
        }


        #region 버튼부분 입니당 ^-^         

        // 연결 방법 선택 1 ~ 6 및 박스 색깔 변경 //
        private void RF_Tile_Click(object sender, EventArgs e)
        {
            OptionSelect(1);
            this.RF_Tile.Style = MetroFramework.MetroColorStyle.Pink;
            this.UART_Tile.Style = MetroFramework.MetroColorStyle.Silver; // 클릭시 박스 색 변경
            this.WIFI_Tile.Style = MetroFramework.MetroColorStyle.Silver;
            this.Zigbee_Tile.Style = MetroFramework.MetroColorStyle.Silver;
            this.Server_Tile.Style = MetroFramework.MetroColorStyle.Silver;
            this.Client_Tile.Style = MetroFramework.MetroColorStyle.Silver;
        }

        private void UART_Tile_Click(object sender, EventArgs e)
        {
            OptionSelect(2);
            this.RF_Tile.Style = MetroFramework.MetroColorStyle.Silver;
            this.UART_Tile.Style = MetroFramework.MetroColorStyle.Pink; // 클릭시 박스 색 변경
            this.WIFI_Tile.Style = MetroFramework.MetroColorStyle.Silver;
            this.Zigbee_Tile.Style = MetroFramework.MetroColorStyle.Silver;
            this.Server_Tile.Style = MetroFramework.MetroColorStyle.Silver;
            this.Client_Tile.Style = MetroFramework.MetroColorStyle.Silver;
        }
        private void WIFI_Tile_Click(object sender, EventArgs e)
        {
            OptionSelect(3);
            this.RF_Tile.Style = MetroFramework.MetroColorStyle.Silver;
            this.UART_Tile.Style = MetroFramework.MetroColorStyle.Silver; // 클릭시 박스 색 변경
            this.WIFI_Tile.Style = MetroFramework.MetroColorStyle.Pink;
            this.Zigbee_Tile.Style = MetroFramework.MetroColorStyle.Silver;
            this.Server_Tile.Style = MetroFramework.MetroColorStyle.Silver;
            this.Client_Tile.Style = MetroFramework.MetroColorStyle.Silver;
        }
        private void Zigbee_Tile_Click(object sender, EventArgs e)
        {
            OptionSelect(4);
            this.RF_Tile.Style = MetroFramework.MetroColorStyle.Silver;
            this.UART_Tile.Style = MetroFramework.MetroColorStyle.Silver; // 클릭시 박스 색 변경
            this.WIFI_Tile.Style = MetroFramework.MetroColorStyle.Silver;
            this.Zigbee_Tile.Style = MetroFramework.MetroColorStyle.Pink;
            this.Server_Tile.Style = MetroFramework.MetroColorStyle.Silver;
            this.Client_Tile.Style = MetroFramework.MetroColorStyle.Silver;
        }
        private void Server_Tile_Click(object sender, EventArgs e)
        {
            OptionSelect(5);
            this.RF_Tile.Style = MetroFramework.MetroColorStyle.Silver;
            this.UART_Tile.Style = MetroFramework.MetroColorStyle.Silver; // 클릭시 박스 색 변경
            this.WIFI_Tile.Style = MetroFramework.MetroColorStyle.Silver;
            this.Zigbee_Tile.Style = MetroFramework.MetroColorStyle.Silver;
            this.Server_Tile.Style = MetroFramework.MetroColorStyle.Pink;
            this.Client_Tile.Style = MetroFramework.MetroColorStyle.Silver;
        }

        private void Client_Tile_Click(object sender, EventArgs e)
        {
            OptionSelect(6);
            this.RF_Tile.Style = MetroFramework.MetroColorStyle.Silver;
            this.UART_Tile.Style = MetroFramework.MetroColorStyle.Silver; // 클릭시 박스 색 변경
            this.WIFI_Tile.Style = MetroFramework.MetroColorStyle.Silver;
            this.Zigbee_Tile.Style = MetroFramework.MetroColorStyle.Silver;
            this.Server_Tile.Style = MetroFramework.MetroColorStyle.Silver;
            this.Client_Tile.Style = MetroFramework.MetroColorStyle.Pink;
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
                    {
                        connectType = 1;
                        this.SerialPanel.Visible = false;
                        this.metroPanel2.Visible = true;
                        break;
                    }
                case 2:
                    {
                        connectType = 2;
                        this.metroPanel2.Visible = false;   // 기존 패널 숨기고
                        this.SerialPanel.Visible = true;    // 시리얼 패널 보이기
                        Serial_Combo_Init();
                    }
                    break;
                case 3:
                    {
                        connectType = 3;
                        break;
                    }
                case 4:
                    {
                        connectType = 4;
                        break;
                    }
                case 5:
                    {
                        connectType = 5;
                        //ethernet.ServerOpen(Int32.Parse(this.metroTextBox2.Text));
                    }
                    break;
                case 6:
                    {
                        connectType = 6;
                        //client.StartClient(metroTextBox1.Text, Int32.Parse(this.metroTextBox2.Text));
                    }
                    break;
            }
        }

        private void DisConBtn_Click(object sender, EventArgs e)    // 연결 해제 버튼
        {
            if (connectType == 2) //시리얼
            {
                //serial.DisConSerial();
            }
        }


        private void SendBtn_Click(object sender, EventArgs e)      // 보내기 버튼
        {
            if (connectType == 2) //시리얼
            {
                //string toserialmsg = serial.SerialSend(this.SendWindowBox.Text); // 시리얼 값 받아오기
                //this.SendWindowBox.Text += toserialmsg + "\n";                   // 시리얼 텍스트박스에 표현
            }
            if (connectType == 5) //server측
            {
                string toclientmsg = ethernet.SendToClient(this.BaudRate.Text);
                this.SendWindowBox.Text += toclientmsg+"\n";

            }
            if (connectType == 6) //클라측
            {
                string toservermsg = client.Send(metroTextBox5.Text);
                this.SendWindowBox.Text += toservermsg + "\n";
                //string toservermsg = ethernet.SendToServer(this.metroTextBox5.Text);
                //this.richTextBox1.Text += toservermsg + "\n";
            }

        }

        private void ReceiveBtn_Click(object sender, EventArgs e)   // 받기 버튼
        {

            if (connectType == 2)
            {
                //this.ReceiveWindowBox.Text += serial.receivedata + "\n";       // 시리얼 전역변수에서 받아서 텍스트박스에 표현
            }
            if (connectType == 5)
            {
                string recvclientmsg = ethernet.RecvToClient();
                this.ReceiveWindowBox.Text += recvclientmsg + "\n";
            }
            if(connectType ==6)
            {
                string toservermsg = client.Receive();
                this.ReceiveWindowBox.Text += toservermsg + "\n";
            }
        }

        // 임시 보내기 버튼
        private void button2_Click(object sender, EventArgs e)
        {
            
            byte[] byteSendData = new byte[200];
            int SendCount = 0;
            try
            {
                if (true == Chk_Hexa.Checked)
                {
                    foreach (string s in SendWindowBox.Text.Split(' '))
                    {
                        if (s != null && s != "")
                        {
                            byteSendData[SendCount++] = Convert.ToByte(s, 16);
                        }
                    }
                    serial.SerialHexSend(byteSendData, 0, SendCount);
                    
                }
                else
                {
                    serial.SerialSend(this.SendWindowBox.Text);

                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Chk_Hexa_CheckedChanged(object sender, EventArgs e)
        {
            if (true == Chk_Hexa.Checked)
                Chk_Hexa_Flag = 1;
            else
                Chk_Hexa_Flag = 0;
            
        }

        #endregion

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
        
        #region 시리얼 설정 부분~!
        // 시리얼 설정 부분 선택지    
        private void Serial_Combo_Init()
        {

            // 시리얼 옵션 콤보박스 초기화
            this.Serial_Combo_Port.DropDownStyle = ComboBoxStyle.DropDown;
            this.Serial_Combo_Baud.DropDownStyle = ComboBoxStyle.DropDown;
            this.Serial_Combo_Data.DropDownStyle = ComboBoxStyle.DropDown;
            this.Serial_Combo_FlowCon.DropDownStyle = ComboBoxStyle.DropDown;
            this.Serial_Combo_Parity.DropDownStyle = ComboBoxStyle.DropDown;
            this.Serial_Combo_StopBit.DropDownStyle = ComboBoxStyle.DropDown;

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
            Serial_Combo_Data.SelectedIndex = 1;

            List<string> data4 = new List<string>();
            string[] Parity = {"none","odd","even","mark","space" };
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
            Serial_Combo_StopBit.SelectedIndex = 1;

            List<string> data6 = new List<string>();
            string[] FlowCon = { "none", "Xon/Xoff","hardware" };
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
            serial.sPort.DataReceived += new SerialDataReceivedEventHandler(UpdateWindowText);


        }
        #endregion


        #region 리치 텍스트 박스

        // 수신 텍스트박스 업데이트 이벤트
        public void UpdateWindowText(object sender, SerialDataReceivedEventArgs e)
        {
            
            Thread thread = new Thread(new ThreadStart(delegate ()
            {
                this.Invoke(new Action(() =>
                {
                    this.ReceiveWindowBox.Text = Global.globalVar;
                    this.ReceiveWindowBox.ScrollToCaret();
                }));
            }));
            thread.Start();
        }

        // 송신 텍스트박스 업데이트 이벤트
        private void Enter_Rich(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {              
                if (this.SendWindowBox.Text != null)
                {
                    serial.SerialSend(SendWindowBox.Text);           
                }
            }
        }




        #endregion

    }
}
