﻿using ChatMessages;
using Pigeon;
using Pigeon.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatServer
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var system = ActorSystemSignalR.Create("Chat Server", "http://localhost:8090"))
            {
                var server = system.GetActor<ChatServerActor>();

                Console.ReadLine();
            }
        }
    }

    class ChatServerActor : TypedActor , 
        IHandle<SayRequest>,
        IHandle<ConnectRequest>,
        IHandle<NickRequest>,
        IHandle<Disconnect>,
        IHandle<ChannelsRequest>

    {
        public void Handle(SayRequest message)
        {
            
        }

        public void Handle(ConnectRequest message)
        {
            
        }

        public void Handle(NickRequest message)
        {
            
        }

        public void Handle(Disconnect message)
        {
            
        }

        public void Handle(ChannelsRequest message)
        {
            
        }
    }
}