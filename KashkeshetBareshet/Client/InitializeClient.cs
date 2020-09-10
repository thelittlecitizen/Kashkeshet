using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Text;
using System.Threading;

namespace Client

{
    [Serializable]
    public class InitializeClient
    {
        public string IpAddress { get; set; }
        public int Port { get; set; }
        public Guid ClientId { get; set; }
        public TcpClient TcpClient { get; set; }

        public InitializeClient(string ipAddress, int port, Guid clientId)
        {
            IpAddress = ipAddress;
            Port = port;
            ClientId = clientId;

            TcpClient = new TcpClient(ipAddress, port);

        }
    }
}
