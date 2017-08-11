using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicLevel.Mapping;
using LogicLevel.Model;
using TransportLevel;
using TransportLevel.ChatServiceReference;
using TransportLevel.EventArg;

namespace LogicLevel
{
    public class MessageManager
    {
        private readonly IChatTransport _chatTransport;

        public event EventHandler<MessageReceivedEventArgs> MessageReceived
        {
            add { _chatTransport.MessageReceived += value; }
            remove { _chatTransport.MessageReceived -= value; }
        }

        public event EventHandler<UnreadMessagesEventArgs> UnreadMessagesReceived
        {
            add { _chatTransport.UnreadMessagesReceived += value; }
            remove { _chatTransport.UnreadMessagesReceived -= value; }
        }

        public MessageManager(IChatTransport chatTransport)
        {
            _chatTransport = chatTransport;
        }

        public void SendMessage(MessagePartialModel obj)
        {
            _chatTransport.SendMessage(obj.Mapping<MessagePartialTransportModel>());
        }
    }
}
