﻿using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Text;
using System.Threading;

namespace Server
{
    class InitializeConnect
    {
        public TcpListener TcpListener { get; set; }

        public List<TcpClient> TcpClientsList;

        public InitializeConnect(TcpListener tcpListener, List<TcpClient> tcpClientsList)
        {
            TcpListener = tcpListener;
            TcpClientsList = tcpClientsList;
        }

        public void Connect()
        {
            TcpListener.Start();
            Console.WriteLine("server connected");

            while (true)
            {
                TcpClient tcpClient = TcpListener.AcceptTcpClient();
                TcpClientsList.Add(tcpClient);
                GetMessageFromClient getMessageFromClient = new GetMessageFromClient(tcpClient);
                getMessageFromClient.ReadFromClient();
            }


        }
    }
}
