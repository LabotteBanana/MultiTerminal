using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Net.Sockets;
namespace MultiTerminal
{
    class TerminalTimer
    {
        delegate void TimerEventFiredDelegate(object sock);

        public string m_RepeatMsg;
        public Timer m_Timer = new Timer();
        private System.Windows.Forms.Control m_Sender;
        private object m_Sock;
        public void StartTimer(int sec,string msg,object networkType)
        {
            m_Timer.Interval = 1000*sec;        //1초
            m_Timer.Elapsed += new ElapsedEventHandler(timer_Elapse);
            m_Timer.Start();
            m_RepeatMsg = msg;
            m_Sock = networkType;
        }
        void timer_Elapse(object sender,ElapsedEventArgs e)
        {
           m_Sender  = (System.Windows.Forms.Control)sender;
            m_Sender.BeginInvoke(new TimerEventFiredDelegate(Work), m_Sock);
        }
        private void Work(object sock)
        {
            //실제 처리할 작업 -->메시지 보내기
            if(sock == TCPClient.m_Server)
            {
                TCPClient.SendMsg(m_RepeatMsg);
            }
        }
        public void EndTimer()
        {
            m_Timer.Stop();
        }
        public void NowTime()
        {
            m_Timer.Interval = 1;
        }
        public long GetNowTime()
        {
        }
    }
}
