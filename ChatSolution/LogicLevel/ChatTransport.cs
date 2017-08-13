using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using LogicLevel.ChatServiceReference;
using LogicLevel.EventArg;
using LogicLevel.Mapping;
using LogicLevel.Model;

namespace LogicLevel
{
    public class ChatTransport
    {
        private readonly ChatServiceClient _proxyChat;
        private readonly ChatServiceCallback _chatServiceCallback;
        public ChatTransport()
        {
            _chatServiceCallback = new ChatServiceCallback();
            _proxyChat = new ChatServiceClient(new InstanceContext(_chatServiceCallback));
        }

        internal event EventHandler<UserJoinedEventArgs> OnUserJoined
        {
            add { _chatServiceCallback.OnUserJoined += value; }
            remove { _chatServiceCallback.OnUserJoined -= value; }
        }

        internal event EventHandler<UserLeavedEventArgs> OnUserLeave
        {
            add { _chatServiceCallback.OnUserLeave += value; }
            remove { _chatServiceCallback.OnUserLeave -= value; }
        }

        internal event EventHandler<MessageReceivedEventArgs> OnMessageReceived
        {
            add { _chatServiceCallback.OnMessageReceived += value; }
            remove { _chatServiceCallback.OnMessageReceived -= value; }
        }

        internal event EventHandler<OnlineUsersEventArgs> OnlineUsersReceived
        {
            add { _chatServiceCallback.OnlineUsersReceived += value; }
            remove { _chatServiceCallback.OnlineUsersReceived -= value; }
        }

        internal event EventHandler<CurrentUserEventArgs> CurrentUserReceived
        {
            add { _chatServiceCallback.CurrentUserReceived += value; }
            remove { _chatServiceCallback.CurrentUserReceived -= value; }
        }

        internal event EventHandler<UnreadMessagesEventArgs> UnreadMessagesReceived
        {
            add { _chatServiceCallback.UnreadMessagesReceived += value; }
            remove { _chatServiceCallback.UnreadMessagesReceived -= value; }
        }

        internal LoginResultTransportModel Login(LoginTransportModel obj)
        {
            return _proxyChat.Login(obj);
        }

        internal void Logout(LogoutTransportModel obj)
        {
            _proxyChat.Logout(obj);
        }

        internal RegistrationResultTransportModel Registration(RegistrationTransportModel obj)
        {
            return _proxyChat.Registration(obj);
        }

        internal void SendMessage(MessagePartialTransportModel obj)
        {
            _proxyChat.SendMessage(obj);
        }
    }
}
