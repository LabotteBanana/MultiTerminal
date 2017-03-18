using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Net.Sockets;
using System.Net;
using System.Diagnostics;

// State object for reading client data asynchronously
public class StateObject
{
    // Client  socket.
    public Socket workSocket = null;
    // Size of receive buffer.
    public const int BufferSize = 1024;
    // Receive buffer.
    public byte[] buffer = new byte[BufferSize];
    // Received data string.
    public StringBuilder sb = new StringBuilder();
}

/// <summary>
/// 블록킹되면 안됌
/// </summary>
namespace MultiTerminal
{
    class TCPServer
    {
        public static ManualResetEvent allDone = new ManualResetEvent(false);
        public Queue<string> m_ReceiveQueue = new Queue<string>();

        private Socket m_Server;

        public void Connect(int port)
        {
            // Data buffer for incoming data.
            byte[] bytes = new Byte[1024];
            IPEndPoint localEndPoint = new IPEndPoint(IPAddress.Any, port);

            // Create a TCP/IP socket.
            m_Server = new Socket(AddressFamily.InterNetwork,
                SocketType.Stream, ProtocolType.Tcp);
            m_Server.Blocking = false;
            try
            {
                m_Server.Bind(localEndPoint);
                m_Server.Listen(100);
                ///while()
                allDone.Reset();
                // Start an asynchronous socket to listen for connections.
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.ToString());
            }
        }

        public void Recv()
        {
            m_Server.BeginAccept(new AsyncCallback(AcceptCallback), m_Server);
            allDone.WaitOne();
        }

    public void AcceptCallback(IAsyncResult ar)
        {
            allDone.Set();
            Socket listener = (Socket)ar.AsyncState;
            Socket handler = listener.EndAccept(ar);

            StateObject state = new StateObject();
            state.workSocket = handler;
            handler.BeginReceive(state.buffer, 0, StateObject.BufferSize, 0,
                new AsyncCallback(ReadCallback), state);
        }

        private void ReadCallback(IAsyncResult ar)
        {
            String content = String.Empty;

            StateObject state = (StateObject)ar.AsyncState;
            Socket handler = state.workSocket;

            int bytesRead = handler.EndReceive(ar);

            if (bytesRead > 0)
            {
                state.sb.Append(Encoding.ASCII.GetString(
                    state.buffer, 0, bytesRead));

                content = state.sb.ToString();
                if (content.IndexOf("<EOF>") > -1)
                {
                    Debug.WriteLine("Read {0} bytes from socket. \n Data : {1}",
                        content.Length, content);
                    m_ReceiveQueue.Enqueue(content);
                    //Send(content);

                }
                else
                {
                    handler.BeginReceive(state.buffer, 0, StateObject.BufferSize, 0,
                    new AsyncCallback(ReadCallback), state);
                }
            }
        }

        public void Send(String data)
        {
            byte[] byteData = Encoding.ASCII.GetBytes(data);
            Socket handler = m_Server;
            handler.BeginSend(byteData, 0, byteData.Length, 0,
                new AsyncCallback(SendCallback), handler);
        }

        private void SendCallback(IAsyncResult ar)
        {
            try
            {
                Socket handler = (Socket)ar.AsyncState;

                int bytesSent = handler.EndSend(ar);
                Console.WriteLine("Sent {0} bytes to client.", bytesSent);

                handler.Shutdown(SocketShutdown.Both);
                handler.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
        public void Close()
        {
            m_Server.Shutdown(SocketShutdown.Both);
            m_Server.Close();

        }
    }
}
