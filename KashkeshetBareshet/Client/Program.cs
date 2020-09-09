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
        //public static void PrintCoral()
        //{
        //    while(true)
        //        Console.WriteLine("Coral");
        //}
        static void Main(string[] args)
        {
           
            InitializeClient initializeClient = new InitializeClient("127.0.0.1",11000,1);
             GetMessageFromServer getMessageFromServer = new GetMessageFromServer(initializeClient.tcpClient);
            Thread t = new Thread(() => getMessageFromServer.Read());
            t.Start();
            try
            {
                InitializeConnect initializeConnect = new InitializeConnect(initializeClient.tcpClient);
                
                while (true)
                {
                    if (initializeConnect.TcpClient.Connected)
                    {
                       // initializeConnect.Connect();
                        GetClientMessage getClientMessage = new GetClientMessage(initializeConnect.TcpClient);
                        getClientMessage.Print();
                        //Thread thread = new Thread(getClientMessage.Print);
                        //thread.Start();
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

