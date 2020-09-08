using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Text;
using System.Threading;

namespace Client
{
    class InitializeConnect
    {
        public TcpClient TcpClient { get; set; }
        InitializeClient initializeClient;

        public InitializeConnect(TcpClient tcpClient)
        {
            TcpClient = tcpClient;
        }

        public void Connect()
        {
            StreamWriter sWriterclient = new StreamWriter(TcpClient.GetStream());

            sWriterclient.WriteLine($"{initializeClient.ClientId} connected");
            sWriterclient.Flush();

        }
    }
}
