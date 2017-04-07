﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Windows.Forms;

namespace MultiTerminal
{

    public class Serial
    {
        
        public SerialPort sPort = null;
        public string receivedata = null;   // 시리얼 데이터 받기위한 임시 전역 변수...

        public Serial()
        {
          
        }

        public int IsOpen()
        {
            
            if (sPort.IsOpen) return 0;
            else return 1;
        }
        public void SerialOpen(String Port, String Baud, String Data, String parity, String stopbits, String RT, String WT)
        {

            try
            {
                if (null == sPort)
                {
                    sPort = new SerialPort();
                    sPort.DataReceived += new SerialDataReceivedEventHandler(sPort_DataReceivedHandle);   // 데이터 리시브 반응 이벤트 함수. 데이터가 들어올때마다 구동됨.
                                                                                                          //+= new SerialDataReceivedEventHandler(UpdateWindowText);
                    WT = "500";
                    RT = "500";

                    sPort.PortName = Port;
                    sPort.BaudRate = Convert.ToInt32(Baud);
                    sPort.DataBits = Convert.ToInt32(Data);

                    switch (parity)
                    {
                        case "none":
                            sPort.Parity = Parity.None;
                            break;
                        case "odd":
                            sPort.Parity = Parity.Odd;
                            break;
                        case "even":
                            sPort.Parity = Parity.Even;
                            break;
                        case "mark":
                            sPort.Parity = Parity.Mark;
                            break;
                        case "space":
                            sPort.Parity = Parity.Space;
                            break;
                    }

                    switch (stopbits)
                    {
                        case "1 bit":
                            sPort.StopBits = StopBits.One;
                            break;
                        case "1.5 bit":
                            sPort.StopBits = StopBits.OnePointFive;
                            break;
                        case "2 bit":
                            sPort.StopBits = StopBits.Two;
                            break;
                    }
                    sPort.ReadTimeout = Convert.ToInt32(RT);
                    sPort.WriteTimeout = Convert.ToInt32(WT);
                    sPort.Open();
                }

                if (sPort.IsOpen)   // 연결 성공
                {
                    MessageBox.Show("시리얼 포트를 연결했습니다.");
                }
                else
                {
                    MessageBox.Show("시리얼 포트 연결에 실패했습니다.");
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        // 시리얼이 들어올때마다 리치박스에 데이터 표현하기 위한 이벤트핸들러


        // MainForm에서 사용하는 데이터 송신 함수
        public void SerialSend(string msg)
        {
            byte[] aaa = Encoding.UTF8.GetBytes(msg);
            int aasize = aaa.Length;
            sPort.Write(Encoding.UTF8.GetBytes(msg), 0 , Encoding.UTF8.GetBytes(msg).Length);
        }

        public void SerialHexSend(byte[] bytesenddata, int msg, int count)
        {

            sPort.Write(bytesenddata, 0, count);
        }
        /*
        void sPort_DataReceivedHandle(object sender, SerialDataReceivedEventArgs e)
        {
            int intRecSize = sPort.BytesToRead; // 들어온 데이터의 크기에 따라 사이즈 초기화
            string strRecData;  // 최종 데이터 저장 변수


            if (intRecSize != 0)    // 들어온 데이터 사이즈가 0 이상이면...
            {
                strRecData = "";
                byte[] buff = new byte[intRecSize]; // 데이터 사이즈에 따른 버퍼 생성
                sPort.Read(buff, 0, intRecSize);    // buff에 시리얼 데이터 Read...!
                
                for (int iTemp = 0; iTemp < intRecSize; iTemp++)
                {
                    if ( MainForm.Chk_Hexa_Flag == 1)    // 16진수인 경우...
                    { strRecData += buff[iTemp].ToString("X2") + " "; }
                    else
                    { strRecData += Convert.ToChar(buff[iTemp]); }  // 최종 변수에 buff 내용 대입
                }

            }
        }
        */



        public void DisConSerial()  // 시리얼 연결 해제
        {
            if (null != sPort)
            {
                if (sPort.IsOpen)
                {
                    sPort.Close();
                    sPort.Dispose();
                    sPort = null;
                }
            }
        }


        public void sPort_DataReceivedHandle(object sender, SerialDataReceivedEventArgs e)
        {
            int intRecSize = sPort.BytesToRead; // 들어온 데이터의 크기에 따라 사이즈 초기화
            string strRecData;  // 최종 데이터 저장 변수


            if (intRecSize != 0)    // 들어온 데이터 사이즈가 0 이상이면...
            {
                strRecData = "";
                byte[] buff = new byte[intRecSize]; // 데이터 사이즈에 따른 버퍼 생성
                sPort.Read(buff, 0, intRecSize);    // buff에 시리얼 데이터 Read...!

                for (int iTemp = 0; iTemp < intRecSize; iTemp++)
                {
                    if (MainForm.Chk_Hexa_Flag == 1)    // 16진수인 경우...
                    { strRecData += buff[iTemp].ToString("X2") + ""; }
                }

                //receivedata += strRecData;
                if (MainForm.Chk_Hexa_Flag == 1 )
                { Global.globalVar += strRecData; }
                else
                { Global.globalVar += Encoding.UTF8.GetString(buff); }
                if (MainForm.CHK_AE_Flag == 1)
                { Global.globalVar +=  "\n"; }
                if (MainForm.Chk_AS_Flag == 1)
                { Global.globalVar += " "; }
                for (int iTemp = 0; iTemp < intRecSize; iTemp++)
                {
                    Console.Write(Convert.ToString(buff[iTemp], 2));
                    
                }
            Console.WriteLine();
            }

        }


    }
}
