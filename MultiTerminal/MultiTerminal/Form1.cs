using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// 블루투스 
using System.IO.Ports;


namespace MultiTerminal
{
    public partial class Form1 : Form
    {
        private SerialPort arduSerialPort = new SerialPort();
        public Form1()
        {
            InitializeComponent();
            arduSerialPort.PortName = "COM15";    //아두이노가 연결된 시리얼 포트 번호 지정
            arduSerialPort.BaudRate = 9600;       //시리얼 통신 속도 지정
            arduSerialPort.Open();                //포트 오픈
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string textbox1;
            textbox1 = T1.Text;
            arduSerialPort.Write(textbox1);
        }
    }
}
