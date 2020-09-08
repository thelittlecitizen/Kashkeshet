using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Text;
using System.Threading;

namespace Client
{
    class InitializeClient
    {
        public string IpAddress { get; set; }
        public int Port { get; set; }
        public int ClientId { get; set; }
        public TcpClient tcpClient { get; set; }

        public InitializeClient(string ipAddress, int port, int clientId)
        {
            IpAddress = ipAddress;
            Port = port;
            ClientId = clientId;

            tcpClient = new TcpClient(ipAddress, port);

        }
    }
}
