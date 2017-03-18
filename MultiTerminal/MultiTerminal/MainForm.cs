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
using System.Timers;
namespace MultiTerminal
{
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {
        public bool isServ = false;
        static int connectType = 1;
        public Tserv tserv = null;
        public Tserv tcla = null;
        static public int Chk_Hexa_Flag = 0;
        public Serial serial = new Serial();
        private string[] SerialOpt = new string[6];
        public System.Timers.Timer timer = null;
        public static System.Timers.Timer mactimer = null;
        private DateTime nowTime;



        public MainForm()
        {

            InitializeComponent();
            //Application.Idle +=  new SerialDataReceivedEventHandler(serial.sPort_DataReceivedHandle);
        }

        private void MainForm_Load(object sender, EventArgs e)  // 폼 열렸을 때
        {
            this.Style = MetroFramework.MetroColorStyle.Yellow;
            TcpPanel.Visible = false;
            UdpPanel.Visible = false;
            SerialPanel.Visible = false;
            timer = new System.Timers.Timer();
            mactimer = new System.Timers.Timer();
            timer.Interval = 0.0001; // 1000==>1초 0.0001==>1000만분의1

            timer.Enabled = true;
            mactimer.Enabled = false;

            timer.Elapsed += OnTimeEvent;
            mactimer.Elapsed += OnMacro;

            timer.AutoReset = true;
            mactimer.AutoReset = false;


        }

        #region Timer(타임스탬프)
        private void OnTimeEvent(Object source, System.Timers.ElapsedEventArgs e)
        {
            nowTime = e.SignalTime;
        }

        private  void OnMacro(Object soruce, System.Timers.ElapsedEventArgs e)
        {
            if (isServ == true && tserv.client.Connected == true)
            {
                tserv.SendMsg(textBox1.Text);
                SendWindowBox.Text += textBox1.Text;
                ReceiveWindowBox.Text += "송신 : " + GetTimer() + textBox1.Text + "\n";
            }
            if (isServ == false && tcla.client.Connected == true)
            {
                tcla.SendMsg(textBox1.Text);
                SendWindowBox.Text += textBox1.Text;
                ReceiveWindowBox.Text += "송신 : " + GetTimer() + textBox1.Text + "\n";
            }

        }
        public string GetTimer()
        {
            string now = null;
            now = "[ " + nowTime.Hour + "::" + nowTime.Minute + "::" + nowTime.Second + "::" + nowTime.Millisecond + "]";
            return now;
        }

        public void SetMacroTime(int perSec)
        {
            // 초당 10번이면 100/1000
            // 초당 5번 이면 50/1000
            bool btrue = true;
            mactimer.Interval = 10000000;
            if (btrue == false)
            {
                mactimer.Elapsed += OnMacro;
            }
                mactimer.Enabled = true;


        }
        #endregion

        private void MainForm_Closed(object sender, FormClosedEventArgs e)  // 메인폼 닫혔을 때 
        {

            //serial.DisConSerial();
            tserv.ServerStop();
            tcla.DisConnect();

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
            this.TCP_Tile.Style = MetroFramework.MetroColorStyle.Silver;
            this.UDP_Tile.Style = MetroFramework.MetroColorStyle.Silver;
        }

        private void UART_Tile_Click(object sender, EventArgs e)
        {
            OptionSelect(2);
            this.RF_Tile.Style = MetroFramework.MetroColorStyle.Silver;
            this.UART_Tile.Style = MetroFramework.MetroColorStyle.Pink; // 클릭시 박스 색 변경
            this.WIFI_Tile.Style = MetroFramework.MetroColorStyle.Silver;
            this.Zigbee_Tile.Style = MetroFramework.MetroColorStyle.Silver;
            this.TCP_Tile.Style = MetroFramework.MetroColorStyle.Silver;
            this.UDP_Tile.Style = MetroFramework.MetroColorStyle.Silver;
        }
        private void WIFI_Tile_Click(object sender, EventArgs e)
        {
            OptionSelect(3);
            this.RF_Tile.Style = MetroFramework.MetroColorStyle.Silver;
            this.UART_Tile.Style = MetroFramework.MetroColorStyle.Silver; // 클릭시 박스 색 변경
            this.WIFI_Tile.Style = MetroFramework.MetroColorStyle.Pink;
            this.Zigbee_Tile.Style = MetroFramework.MetroColorStyle.Silver;
            this.TCP_Tile.Style = MetroFramework.MetroColorStyle.Silver;
            this.UDP_Tile.Style = MetroFramework.MetroColorStyle.Silver;
        }
        private void Zigbee_Tile_Click(object sender, EventArgs e)
        {
            OptionSelect(4);
            this.RF_Tile.Style = MetroFramework.MetroColorStyle.Silver;
            this.UART_Tile.Style = MetroFramework.MetroColorStyle.Silver; // 클릭시 박스 색 변경
            this.WIFI_Tile.Style = MetroFramework.MetroColorStyle.Silver;
            this.Zigbee_Tile.Style = MetroFramework.MetroColorStyle.Pink;
            this.TCP_Tile.Style = MetroFramework.MetroColorStyle.Silver;
            this.UDP_Tile.Style = MetroFramework.MetroColorStyle.Silver;
        }
        private void TCP_Tile_Click(object sender, EventArgs e)
        {
            OptionSelect(5);
            isServ = false;

            this.RF_Tile.Style = MetroFramework.MetroColorStyle.Silver;
            this.UART_Tile.Style = MetroFramework.MetroColorStyle.Silver; // 클릭시 박스 색 변경
            this.WIFI_Tile.Style = MetroFramework.MetroColorStyle.Silver;
            this.Zigbee_Tile.Style = MetroFramework.MetroColorStyle.Silver;
            this.TCP_Tile.Style = MetroFramework.MetroColorStyle.Pink;
            this.UDP_Tile.Style = MetroFramework.MetroColorStyle.Silver;
        }
        private void CheckMacro()
        {
        }
        private void UDP_Tile_Click(object sender, EventArgs e)
        {
            OptionSelect(6);
            this.RF_Tile.Style = MetroFramework.MetroColorStyle.Silver;
            this.UART_Tile.Style = MetroFramework.MetroColorStyle.Silver; // 클릭시 박스 색 변경
            this.WIFI_Tile.Style = MetroFramework.MetroColorStyle.Silver;
            this.Zigbee_Tile.Style = MetroFramework.MetroColorStyle.Silver;
            this.TCP_Tile.Style = MetroFramework.MetroColorStyle.Silver;
            this.UDP_Tile.Style = MetroFramework.MetroColorStyle.Pink;
        }


        // UI 기능 함수
        private void Change_Color(int connectType)
        {

        }


        // 연결 번호에 따른 각기 다른 옵션패널 띄우는 함수 //
        private void OptionSelect(int OptionNumber)  // 연결 버튼
        {
            Point Loc = new Point(140, 6);
            switch (OptionNumber)
            {
                case 1:
                    {
                        connectType = 1;
                        this.SerialPanel.Visible = false;
                        break;
                    }
                case 2:
                    {
                        connectType = 2;
                        SerialPanel.Location = Loc;
                        this.SerialPanel.Visible = true;    // 시리얼 패널 보이기
                        TcpPanel.Visible = false;
                        UdpPanel.Visible = false;
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
                        TcpPanel.Location = Loc;
                        TcpPanel.Visible = true;
                        SerialPanel.Visible = false;
                        UdpPanel.Visible = false;
                    }
                    break;
                case 6:
                    {
                        connectType = 6;
                        UdpPanel.Location = Loc;
                        SerialPanel.Visible = false;
                        TcpPanel.Visible = false;
                        UdpPanel.Visible = true;
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

            }
            if (connectType == 6) //클라측
            {
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
            }
            if (connectType == 6)
            {
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
            string[] Baud = { "4800", "9600", "14400", "19200" };
            foreach (string s in Baud)
            {
                data2.Add(s);
            }
            Serial_Combo_Baud.Items.AddRange(data2.Cast<object>().ToArray());
            Serial_Combo_Baud.SelectedIndex = 0;

            List<string> data3 = new List<string>();
            string[] Data = { "7", "8" };
            foreach (string s in Data)
            {
                data3.Add(s);
            }
            Serial_Combo_Data.Items.AddRange(data3.Cast<object>().ToArray());
            Serial_Combo_Data.SelectedIndex = 1;

            List<string> data4 = new List<string>();
            string[] Parity = { "none", "odd", "even", "mark", "space" };
            foreach (string s in Parity)
            {
                data4.Add(s);
            }
            Serial_Combo_Parity.Items.AddRange(data4.Cast<object>().ToArray());
            Serial_Combo_Parity.SelectedIndex = 0;

            List<string> data5 = new List<string>();
            string[] Stopbit = { "none", "1 bit", "2 bit", "1.5 bit" };
            foreach (string s in Stopbit)
            {
                data5.Add(s);
            }
            Serial_Combo_StopBit.Items.AddRange(data5.Cast<object>().ToArray());
            Serial_Combo_StopBit.SelectedIndex = 1;

            List<string> data6 = new List<string>();
            string[] FlowCon = { "none", "Xon/Xoff", "hardware" };
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

        #region TCP UI
        private void button3_Click(object sender, EventArgs e)
        {
            //comboBox5 -> IP, comboBox6 -> Port
            if (checkBox1.Checked == true)
            {
                int port = Int32.Parse(comboBox1.Text);
                tserv = new Tserv(this, port);
                tserv.ServerStart();

            }
            else
            {
                int port = Int32.Parse(comboBox1.Text);
                string ip = comboBox2.Text;
                tcla = new Tserv(this, ip, port);
                tcla.Connect();
            }
        }
        #region TCP서버여부
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                comboBox2.Enabled = false;
                isServ = true;

            }
            else
            {
                comboBox2.Enabled = true;
                isServ = false;
            }

        }
        #endregion

        #region TCP 로그
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (isServ == true && tserv.client.Connected == true)
                {
                    if (e.KeyCode == Keys.Enter)
                    {
                        tserv.SendMsg(textBox1.Text);
                        SendWindowBox.Text += textBox1.Text;
                        ReceiveWindowBox.Text += "송신 : " + GetTimer() + textBox1.Text + "\n";
                    }
                }
                else if (isServ == false && tcla.client.Connected == true)
                {
                    if (e.KeyCode == Keys.Enter)
                    {
                        tcla.SendMsg(textBox1.Text);
                        SendWindowBox.Text += textBox1.Text;
                        ReceiveWindowBox.Text += "송신 : " + GetTimer() + textBox1.Text + "\n";
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        #endregion

        #endregion


        private void checkBox3_CheckedChanged_1(object sender, EventArgs e)
        {
            int value = Int32.Parse(textBox2.Text);
            Thread macroThread = new Thread(() => SetMacroTime(value));
            if (checkBox3.Checked == true)
            {
                if (macroThread.IsAlive == false)
                    macroThread.Start();
                else
                    macroThread.Resume();
            }
            else
            {
                if (macroThread.IsAlive == true)
                {
                    macroThread.Suspend();
                }
            }


        }
    } 
}
