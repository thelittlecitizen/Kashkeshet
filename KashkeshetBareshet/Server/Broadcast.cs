using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Text;
using System.Threading;

namespace Server
{
    public class Broadcast
    {
        public List<TcpClient> TcpClientsList;

        public Broadcast(List<TcpClient> tcpClients)
        {
            TcpClientsList = tcpClients;
        }

        public void MessageBroadcast(string message, TcpClient excludeClient)
        {
            Console.WriteLine("check broadcast work");
            foreach (TcpClient client in TcpClientsList)
            {
                if (client != excludeClient)
                {
                    StreamWriter sWriter = new StreamWriter(client.GetStream());
                    sWriter.WriteLine(message);
                    sWriter.Flush();
                }
            }
            Console.WriteLine("check broadcast workend");
        }
       
    }
}
