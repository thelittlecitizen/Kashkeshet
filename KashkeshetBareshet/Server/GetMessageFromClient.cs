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
        public TcpClient TcpClient;
        public Broadcast Broadcast;


        public GetMessageFromClient(TcpClient tcpClient)
        {
            TcpClient = tcpClient;
            Broadcast = new Broadcast(new List<TcpClient>());
        }

        public void ReadFromClient()
        {
            Console.WriteLine("check if getmessagefromclient readfromclientwork");
            //broadcast connected message//
            StreamReader clientconnected = new StreamReader(TcpClient.GetStream());
            string messageclient = clientconnected.ReadLine();
           
            //broadcast disconnected message//
            StreamReader clientdisconnectesd = new StreamReader(TcpClient.GetStream());
            Broadcast.MessageBroadcast(messageclient, TcpClient);
            Console.WriteLine(messageclient);

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
                Console.WriteLine("check if getmessagefromclient readfromclient workend");

            }

        }

    }
}
