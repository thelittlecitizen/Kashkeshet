using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Text;
using System.Threading;

namespace Server
{
    class GetMessageFromClient
    {
        public TcpClient TcpClient { get; set; }
        public Broadcast Broadcast { get; set; }
        public InitializeConnect InitializeConnect { get; set; }


        public GetMessageFromClient(TcpClient tcpClient, InitializeConnect initializeConnect)
        {
            TcpClient = tcpClient;
            InitializeConnect = initializeConnect;
            Broadcast = new Broadcast(InitializeConnect.TcpClientsList);
        }

        public void ReadFromClient()
        {
            //broadcast connected message//
            StreamReader clientconnected = new StreamReader(TcpClient.GetStream());
            string messageclient = clientconnected.ReadLine();
            Broadcast.MessageBroadcast(messageclient, TcpClient);
            Console.WriteLine(messageclient);
           
            //broadcast disconnected message//
            StreamReader clientdisconnectesd = new StreamReader(TcpClient.GetStream());
            

            StreamReader reader = new StreamReader(TcpClient.GetStream());

            while (true)
            {
                string message = reader.ReadLine();
                Broadcast.MessageBroadcast(message, TcpClient);
                Console.WriteLine(message);
                if (message == "bye")
                {
                    string messageclientdis = clientdisconnectesd.ReadLine();
                    Broadcast.MessageBroadcast(messageclientdis, TcpClient);
                    Console.WriteLine(messageclientdis);

                }

            }

        }

    }
}
