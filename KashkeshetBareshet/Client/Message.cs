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
    public class Message
    {
       public  InitializeClient InitializeClient;
       public Guid ClientId;
       public string Text;

        public Message(InitializeClient initializeClient)
        {
            InitializeClient = initializeClient;
            ClientId = initializeClient.ClientId;
        }





    }
}
