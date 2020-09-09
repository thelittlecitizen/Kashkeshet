using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Text;
using System.Threading;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TcpClient> tcpClientsList = new List<TcpClient>(); 
            InitializeListner initializeListner = new InitializeListner(IPAddress.Any, 11000);
            InitializeConnect initializeConnect = new InitializeConnect(initializeListner.TcpListener, tcpClientsList);
            
            initializeConnect.Connect();



    }
}
}
