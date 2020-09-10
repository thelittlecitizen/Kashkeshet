using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Text;
using System.Threading;

namespace Server
{
    class InitializeListner
    {
        public TcpListener TcpListener { get; set; }
        public IPAddress IPAddress { get; set; }
        public int Port { get; set; }
        


        public InitializeListner(IPAddress iPAddress, int port)
        {
            IPAddress = iPAddress;
            Port = port;

            TcpListener = new TcpListener (iPAddress, port);

        }



    



}
}
