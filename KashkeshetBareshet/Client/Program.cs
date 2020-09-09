using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Text;
using System.Threading;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            InitializeClient initializeClient = new InitializeClient("127.0.0.1",11000,1);

            try
            {
                InitializeConnect initializeConnect = new InitializeConnect(initializeClient.tcpClient);
                while (true)
                {
                    if (initializeConnect.TcpClient.Connected)
                    {
                       
                        GetClientMessage getClientMessage = new GetClientMessage(initializeConnect.TcpClient);
                        getClientMessage.Print();
                    }
                }
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }

            Console.ReadKey();
        }
    }
    }

