using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Text;
using System.Threading;

namespace Client
{
    class GetClientMessage
    {
        public TcpClient TcpClient;

        public GetClientMessage(TcpClient tcpClient)
        {
            TcpClient = tcpClient;
        }
        
        public void Print()
        {
            Console.WriteLine("check if getclientmessafe work");
            //Thread thread = new Thread(Print);
            //thread.Start();
            StreamWriter sWriter = new StreamWriter(TcpClient.GetStream());

            Console.WriteLine("please enter your message");
            string input = Console.ReadLine();
            
            sWriter.WriteLine($"Client write: {input}");
            sWriter.Flush();
            if (input == "bye")
            {

                sWriter.WriteLine($"Client disconnected");
                sWriter.Flush();

                Console.WriteLine("check if getclientmessafe workend");

            }
        }


    }
}
