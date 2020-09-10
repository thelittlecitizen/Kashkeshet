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

        public InitializeClient InitializeClient { get; set; }

        public InitializeConnect(InitializeClient initializeClient)
        {
            InitializeClient = initializeClient;
        }

        public void Connect()
        {
            StreamWriter sWriterclient = new StreamWriter(InitializeClient.TcpClient.GetStream());

            sWriterclient.WriteLine($"{InitializeClient.ClientId} connected");
            sWriterclient.Flush();

            
        }
    }
}
