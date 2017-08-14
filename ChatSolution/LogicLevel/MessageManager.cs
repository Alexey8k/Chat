﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicLevel.ChatServiceReference;
using LogicLevel.EventArg;
using LogicLevel.Mapping;
using LogicLevel.Model;

namespace LogicLevel
{
    public class MessageManager : IMessageManager
    {
        private readonly ChatTransport _chatTransport;

        public MessageManager(ChatTransport chatTransport)
        {
            _chatTransport = chatTransport;
        }

        public event EventHandler<MessageReceivedEventArgs> OnMessageReceived
        {
            add { _chatTransport.OnMessageReceived += value; }
            remove { _chatTransport.OnMessageReceived -= value; }
        }

        public event EventHandler<UnreadMessagesEventArgs> UnreadMessagesReceived
        {
            add { _chatTransport.UnreadMessagesReceived += value; }
            remove { _chatTransport.UnreadMessagesReceived -= value; }
        }

        public void SendMessage(MessagePartialModel obj)
        {
            _chatTransport.SendMessage(obj.Mapping<MessagePartialTransportModel>());
        }
    }
}
