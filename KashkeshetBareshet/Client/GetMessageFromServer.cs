using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Text;
using System.Threading;

namespace Client
{
    class GetMessageFromServer
    {
        public TcpClient TcpClient;

        public GetMessageFromServer(TcpClient tcpClient)
        {
            TcpClient = tcpClient;
        }
        
        public void Read()
        {
            Thread thread = new Thread(Read);
            thread.Start();
            StreamReader sReader = new StreamReader(TcpClient.GetStream());

            while (true)
            {
                try
                {
                    string message = sReader.ReadLine();
                    Console.WriteLine(message);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    break;
                }
            }
        }
    }
    
}
