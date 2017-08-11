using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using LogicLevel.ChatServiceReference;
using LogicLevel.EventArg;

namespace LogicLevel
{
    public class ChatTransport : IChatTransport, IChatServiceCallback
    {
        private readonly ChatServiceClient _proxyChat;

        public ChatTransport()
        {
            _proxyChat = new ChatServiceClient(new InstanceContext(this));
        }

        //public event EventHandler<UserJoinedEventArgs> UserJoined
        //{
        //    add { _callbackChatService.EventUserJoined += value; }
        //    remove { _callbackChatService.EventUserJoined -= value; }
        //}

        //public event EventHandler<UserLeavedEventArgs> UserLeaved
        //{
        //    add { _callbackChatService.EventUserLeaved += value; }
        //    remove { _callbackChatService.EventUserLeaved -= value; }
        //}

        //public event EventHandler<MessageReceivedEventArgs> MessageReceived
        //{
        //    add { _callbackChatService.EventMessageReceived += value; }
        //    remove { _callbackChatService.EventMessageReceived -= value; }
        //}

        //public event EventHandler<OnlineUsersEventArgs> OnlineUsersReceived
        //{
        //    add { _callbackChatService.OnlineUsersReceived += value; }
        //    remove { _callbackChatService.OnlineUsersReceived -= value; }
        //}

        //public event EventHandler<CurrentUserEventArgs> CurrentUserReceived
        //{
        //    add { _callbackChatService.CurrentUserReceived += value; }
        //    remove { _callbackChatService.CurrentUserReceived -= value; }
        //}

        //public event EventHandler<UnreadMessagesEventArgs> UnreadMessagesReceived
        //{
        //    add { _callbackChatService.UnreadMessagesReceived += value; }
        //    remove { _callbackChatService.UnreadMessagesReceived -= value; }
        //}

        #region IChatTransport

        public event EventHandler<UserJoinedEventArgs> EventUserJoined;

        public event EventHandler<UserLeavedEventArgs> EventUserLeaved;

        public event EventHandler<MessageReceivedEventArgs> EventMessageReceived;

        public event EventHandler<OnlineUsersEventArgs> OnlineUsersReceived;

        public event EventHandler<CurrentUserEventArgs> CurrentUserReceived;

        public event EventHandler<UnreadMessagesEventArgs> UnreadMessagesReceived;

        public LoginResultTransportModel Login(LoginTransportModel obj)
        {
            return _proxyChat.Login(obj);
        }

        public void Logout(LogoutTransportModel obj)
        {
            _proxyChat.Logout(obj);
        }

        public RegistrationResultTransportModel Registration(RegistrationTransportModel obj)
        {
            return _proxyChat.Registration(obj);
        }

        public void SendMessage(MessagePartialTransportModel obj)
        {
            _proxyChat.SendMessage(obj);
        }

        #endregion


        #region IChatServiceCallback

        public void UserJoined(UserPartialTransportModel obj)
        {
            if (EventUserJoined != null) EventUserJoined(this, obj.Mapping<UserJoinedEventArgs>());
        }

        public void UserLeaved(UserLeavedTransportModel obj)
        {
            if (EventUserLeaved != null) EventUserLeaved(this, obj.Mapping<UserLeavedEventArgs>());
        }

        public void MessageReceived(MessagePartialTransportModel obj)
        {
            if (EventMessageReceived != null) EventMessageReceived(this, obj.Mapping<MessageReceivedEventArgs>());
        }

        public void OnlineUsers(OnlineUsersTransportModel obj)
        {
            if (OnlineUsersReceived != null) OnlineUsersReceived(this, obj.Mapping<OnlineUsersEventArgs>());
        }

        public void CurrentUser(UserPartialTransportModel obj)
        {
            if (CurrentUserReceived != null) CurrentUserReceived(this, obj.Mapping<CurrentUserEventArgs>());
        }

        public void UnreadMessages(UnreadMessagesTransportModel obj)
        {
            if (UnreadMessagesReceived != null) UnreadMessagesReceived(this, obj.Mapping<UnreadMessagesEventArgs>());
        }

        #endregion
    }
}
