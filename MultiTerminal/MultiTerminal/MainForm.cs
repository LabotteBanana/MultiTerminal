﻿using System;
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
        static Ethernet ethernet = new Ethernet();
        static Serial serial = new Serial();
        Client client = new Client();
        //private metroUserControl1 usercontrol1 = new metroUserControl1();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Style = MetroFramework.MetroColorStyle.Yellow;
            this.Blue_Tile.Style = MetroFramework.MetroColorStyle.Lime;
            //usercontrol1.Init();
            //this.Controls.Add(usercontrol1);
            //usercontrol1.Show();
        }

        private void MainForm_Closed(object sender, FormClosedEventArgs e)
        {
            serial.DisConSerial();
        }

        //[Docking(DockingBehavior.Ask)]
        //public class metroUserControl1 : MetroFramework.Controls.MetroUserControl
        //{
        //    public MetroFramework.Controls.MetroLabel metroLabel1;
        //    public MetroFramework.Controls.MetroTextBox metroTextBox1;
        //    public MetroFramework.Controls.MetroLabel metroLabel2;
        //    public MetroFramework.Controls.MetroTextBox metroTextBox2;
        //    public MetroFramework.Controls.MetroLabel metroLabel3;
        //    public MetroFramework.Controls.MetroTextBox metroTextBox3;
        //    public MetroFramework.Controls.MetroLabel metroLabel4;
        //    public MetroFramework.Controls.MetroTextBox metroTextBox4;
        //    public MetroFramework.Controls.MetroTextBox metroTextBox5;
        //    public MetroFramework.Controls.MetroButton metroButton1;

        //    private Size controlSize = new Size(30, 40);
        //    private Size controlSize2 = new Size(40, 40);
        //    public metroUserControl1()
        //    {

        //    }
        //    public void Init()
        //    {
        //        Theme = MetroFramework.MetroThemeStyle.Dark;
        //        Location = new System.Drawing.Point(3, 372);
        //        Name = "metroUserControl1";
        //        Size = new System.Drawing.Size(150, 150);
        //        TabIndex = 7;
        //        metroLabel1 = new MetroFramework.Controls.MetroLabel();
        //        metroLabel2 = new MetroFramework.Controls.MetroLabel();
        //        metroLabel3 = new MetroFramework.Controls.MetroLabel();
        //        metroLabel4 = new MetroFramework.Controls.MetroLabel();
        //        metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
        //        metroTextBox2 = new MetroFramework.Controls.MetroTextBox();
        //        metroTextBox3 = new MetroFramework.Controls.MetroTextBox();
        //        metroTextBox4 = new MetroFramework.Controls.MetroTextBox();
        //        metroTextBox5 = new MetroFramework.Controls.MetroTextBox();
        //        metroButton1 = new MetroFramework.Controls.MetroButton();

        //        metroButton1.Location = new Point(5, 10);
        //        metroTextBox1.Location = new Point(15, 10);
        //        metroTextBox2.Location = new Point(15, 30);
        //        metroTextBox3.Location = new Point(15, 70);
        //        metroTextBox4.Location = new Point(15, 110);
        //        metroTextBox5.Location = new Point(15, 150);
        //        metroTextBox1.Size = controlSize;
        //        metroTextBox2.Size = controlSize;
        //        metroTextBox3.Size = controlSize;
        //        metroTextBox4.Size = controlSize;
        //        metroTextBox5.Size = controlSize;
        //        this.Controls.Add(metroTextBox1);
        //        this.Controls.Add(metroTextBox2);
        //        this.Controls.Add(metroTextBox3);
        //        this.Controls.Add(metroTextBox4);
        //        this.Controls.Add(metroTextBox5);
        //        metroTextBox1.Show();
        //        metroTextBox2.Show();
        //        metroTextBox3.Show();
        //        metroTextBox4.Show();
        //        metroTextBox4.Text = "쒸발";
        //    }
        //}

        
        


        //연결 방법 선택 //
        private void Blue_Tile_Click(object sender, EventArgs e)
        {

            connectType = 0;
        }

        private void RF_Tile_Click(object sender, EventArgs e)
        {
            connectType = 1;
        }      

        private void UART_Tile_Click(object sender, EventArgs e)
        {
            connectType = 2;
        }

        private void WIFI_Tile_Click(object sender, EventArgs e)
        {
            connectType = 3;
        }

        private void Zigbee_Tile_Click(object sender, EventArgs e)
        {
            connectType = 4;
        }
        private void Server_Tile_Click(object sender, EventArgs e)
        {
            connectType = 5;
        }

        private void Client_Tile_Click(object sender, EventArgs e)
        {
            connectType = 6;
        }

        // UI 기능 함수

        private void Change_Color(int connectType)
        {

        }


        // 터미널 기능 버튼 //
        private void ConnectBtn_Click(object sender, EventArgs e)  // 연결 버튼
        {
            switch (connectType)
            {
                case 2:
                    {
                        this.UART_Tile.Style = MetroFramework.MetroColorStyle.Pink;
                        serial.SerialOpen(this.SeriPort.Text, this.BaudRate.Text);
                    }
                    break;
                case 5:
                    {
                        this.Server_Tile.Style = MetroFramework.MetroColorStyle.Black;
                        ethernet.ServerOpen(Int32.Parse(this.metroTextBox2.Text));
                    }
                    break;
                case 6:
                    {
                        this.Client_Tile.Style = MetroFramework.MetroColorStyle.White;
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


        private void SendBtn_Click(object sender, EventArgs e)
        {
            if (connectType == 2) //시리얼
            {
                string toserialmsg = serial.SerialSend(this.richTextBox1.Text);
                this.richTextBox1.Text += toserialmsg + "\n";
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

        private void ReceiveBtn_Click(object sender, EventArgs e)
        {

            if (connectType == 2)
            {
                this.richTextBox2.Text += serial.receivedata + "\n";
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
