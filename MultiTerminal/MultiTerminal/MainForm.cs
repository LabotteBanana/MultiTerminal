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
        int ServiceType = 0;
        bool isServ = false;
        static int connectType = 0;
        //static Ucla ucla = new Ucla();
        private Tserv tcla=null;
        //static Userv userv = new Userv();
        private Tserv tserv= null;
        static Serial serial = new Serial();
        SerialPort serialport;

        //private metroUserControl1 usercontrol1 = new metroUserControl1();

        public MainForm()
        {
            InitializeComponent();
        }
        private void Application_Idle(Object sender, EventArgs e)
        {

            //MessageBox.Show("You are in the Application.Idle event.");

        }
        private void MainForm_Load(object sender, EventArgs e)  // 폼 열렸을 때
        {
            
            this.Style = MetroFramework.MetroColorStyle.Yellow;
            TcpPanel.Visible = false;
            UdpPanel.Visible = false;
            SerialPanel.Visible = false;

            //usercontrol1.Init();
            //this.Controls.Add(usercontrol1);
            //usercontrol1.Show();
        }

        private void MainForm_Closed(object sender, FormClosedEventArgs e)  // 메인폼 닫혔을 때 
        {
            serial.DisConSerial();
            tcla.DisConnect();
        }

        
        

        // 연결 방법 선택 1 ~ 6 //
        private void RF_Tile_Click(object sender, EventArgs e)
        {
            ServiceType = 1;
            OptionSelect(ServiceType);
        }      

        private void UART_Tile_Click(object sender, EventArgs e)
        {
            ServiceType = 2;

            OptionSelect(ServiceType);

            this.UART_Tile.Style = MetroFramework.MetroColorStyle.Pink; // 클릭시 박스 색 변경
        }
        private void WIFI_Tile_Click(object sender, EventArgs e)
        {
            ServiceType = 3;

            OptionSelect(ServiceType);

        }
        private void Zigbee_Tile_Click(object sender, EventArgs e)
        {
            ServiceType = 4;

            OptionSelect(ServiceType);

        }
        private void Server_Tile_Click(object sender, EventArgs e)
        {
            ServiceType = 5;

            OptionSelect(ServiceType);
            isServ = false;
            this.TCP_Tile.Style = MetroFramework.MetroColorStyle.Pink;
            this.UDP_Tile.Style = MetroFramework.MetroColorStyle.Silver;
        }

        private void Client_Tile_Click(object sender, EventArgs e)
        {
            ServiceType = 6;
            OptionSelect(ServiceType);
            isServ = false;

            this.UDP_Tile.Style = MetroFramework.MetroColorStyle.Pink;
            this.TCP_Tile.Style = MetroFramework.MetroColorStyle.Silver;

        }


        // UI 기능 함수 (패널을 숨기고, 타일 색상변경, 메뉴번호에 따라서 결정하기)
        private void Change_Color(int connectType)
        {

        }


        // 연결 번호에 따른 각기 다른 옵션패널 띄우는 함수 //
        private void OptionSelect(int OptionNumber)  // 연결 버튼
        {
            Point Loc = new Point(135,88);
            switch (OptionNumber)
            {
                case 1:

                    {
                        TcpPanel.Visible = false;
                        SerialPanel.Visible = false;
                        UdpPanel.Visible = false;

                    }
                    break;
                case 2:
                    {
                        SerialPanel.Location = Loc;
                        SerialPanel.Visible = true;

                        this.Serial_Combo_Port.DropDownStyle = ComboBoxStyle.DropDown;
                        serialport = new SerialPort();
                        List<string> data = new List<string>();
                        foreach (string s in SerialPort.GetPortNames())
                        {
                            data.Add(s);
                        }
                        Serial_Combo_Port.Items.AddRange(data.Cast<object>().ToArray());
                        Serial_Combo_Port.SelectedIndex = 0;

                        serial.SerialOpen(this.SeriPort.Text, this.BaudRate.Text);      // 시리얼 오픈
                        TcpPanel.Visible = false;
                        UdpPanel.Visible = false;

                    }
                    break;
                case 3:
                    {
                        TcpPanel.Visible = false;
                        SerialPanel.Visible = false;
                        UdpPanel.Visible = false;

                    }
                    break;
                case 4:
                    {
                        TcpPanel.Visible = false;
                        SerialPanel.Visible = false;
                        UdpPanel.Visible = false;


                    }
                    break;
                case 5:
                    {
                        TcpPanel.Location = Loc;

                        SerialPanel.Visible = false;
                        TcpPanel.Visible = true;
                        UdpPanel.Visible = false;
                    }
                    break;
                case 6:
                    {
                        UdpPanel.Location = Loc;

                        TcpPanel.Visible = false;
                        SerialPanel.Visible = false;
                        UdpPanel.Visible = true;
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

            }
            if (connectType == 6) //클라측
            {
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
            }
            if(connectType ==6)
            {
            }
        }





        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //IP주소 입력불가능하게
          if(checkBox1.Checked==true)
            {
                comboBox5.Enabled = false;
                isServ = true;

            }
            else
            {
                comboBox5.Enabled = true;
                isServ = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
        
            //comboBox5 -> IP, comboBox6 -> Port
            if(checkBox1.Checked==true) 
            {
                int port = Int32.Parse(comboBox6.Text);
                tserv = new Tserv(port);
                tserv.ServerStart();
               
            }
            else
            {
                int port = Int32.Parse(comboBox6.Text);
                string ip = comboBox5.Text;
                tcla = new Tserv(ip, port);
                tcla.Connect();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //파일 하나 만들어서 IP주소와 Port 저장(매크로기능)

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                comboBox1.Enabled = false;
                isServ = true;
            }
            else
            {
                comboBox1.Enabled = true;
                isServ = false;
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                if (isServ == true && tserv.client.Connected == true)
                {
                    tserv.SendMsg(textBox2.Text);
                    richTextBox1.Text += textBox2.Text;
                    richTextBox2.Text += "송신 : " + textBox2.Text + "\n";
                }
                else if (isServ == false && tcla.client.Connected == true)
                {
                    tcla.SendMsg(textBox2.Text);
                    richTextBox1.Text += textBox2.Text;
                    richTextBox2.Text += "송신 : " + textBox2.Text+"\n";

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {

                if (isServ == true && tserv.client.Connected == true)
                {
                    tserv.RecvMsg();
                    richTextBox2.Text += "수신 : " + tserv.Message + "\n";

                }
                else if (isServ == false && tcla.client.Connected == true)
                {
                    tcla.RecvMsg();
                    richTextBox2.Text += "수신 : " + tcla.Message + "\n";

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
