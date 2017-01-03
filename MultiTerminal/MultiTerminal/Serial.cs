using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Windows.Forms;

namespace MultiTerminal
{
    class Serial
    {
        SerialPort sPort;

        public void SerialOpen(String Port, String Baud)
        {
            try
            {
                if (null == sPort)
                {
                    sPort = new SerialPort();
                    sPort.DataReceived += new SerialDataReceivedEventHandler(sPort_DataReceived);

                    sPort.PortName = Port;
                    sPort.BaudRate = Convert.ToInt32(Baud);
                    sPort.DataBits = (int)8;
                    sPort.Parity = Parity.None;
                    sPort.StopBits = StopBits.One;
                    sPort.ReadTimeout = (int)500;
                    sPort.WriteTimeout = (int)500;
                    sPort.Open();
                }

                if (sPort.IsOpen)   // 연결 성공
                {
                    MessageBox.Show("시리얼 포트를 연결했습니다.");
                }
                else
                {
                    MessageBox.Show("시리얼 포트를 연결했습니다.");
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public string SerialSend(string msg)
        {
            byte[] byteSendData = new byte[200];
            sPort.Write(msg);
            return msg;
        }

        void sPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            int intRecSize = sPort.BytesToRead;
            string strRecData;
            int chkRecHexa = 0;

            if (intRecSize != 0)
            {
                strRecData = "";
                byte[] buff = new byte[intRecSize];
                sPort.Read(buff, 0, intRecSize);

                for (int iTemp = 0; iTemp < intRecSize; iTemp++)
                {
                    if (chkRecHexa == 1)
                    { strRecData += buff[iTemp].ToString("X2") + " "; }
                    else
                    { strRecData += Convert.ToChar(buff[iTemp]); }
                }
                // txtRec.Text += strRecData;

            }
        }

        public void DisConSerial()
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


    }
}
