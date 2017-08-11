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
    [CallbackBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
    public class ChatClient : IChatClient, IChatServiceCallback
    {
        private readonly ChatServiceClient _proxyChat;

        public ChatClient()
        {
            _proxyChat = new ChatServiceClient(new InstanceContext(this));
        }
        
        #region IChatTransport

        public event EventHandler<UserJoinedEventArgs> OnUserJoined;

        public event EventHandler<UserLeavedEventArgs> OnUserLeave;

        public event EventHandler<MessageReceivedEventArgs> OnMessageReceived;

        public event EventHandler<OnlineUsersEventArgs> OnlineUsersReceived;

        public event EventHandler<CurrentUserEventArgs> CurrentUserReceived;

        public event EventHandler<UnreadMessagesEventArgs> UnreadMessagesReceived;

        public LoginResultModel Login(LoginModel obj)
        {
            return _proxyChat.Login(obj.Mapping<LoginTransportModel>()).Mapping<LoginResultModel>();
        }

        public void Logout(LogoutModel obj)
        {
            _proxyChat.Logout(obj.Mapping<LogoutTransportModel>());
        }

        public RegistrationResultModel Registration(RegistrationModel obj)
        {
            return _proxyChat.Registration(obj.Mapping<RegistrationTransportModel>()).Mapping<RegistrationResultModel>();
        }

        public void SendMessage(MessagePartialModel obj)
        {
            _proxyChat.SendMessage(obj.Mapping<MessagePartialTransportModel>());
        }

        #endregion


        #region IChatServiceCallback

        public void UserJoined(UserPartialTransportModel obj)
        {
            if (OnUserJoined != null) OnUserJoined(this, obj.Mapping<UserJoinedEventArgs>());
        }

        public void UserLeave(UserLeavedTransportModel obj)
        {
            if (OnUserLeave != null) OnUserLeave(this, obj.Mapping<UserLeavedEventArgs>());
        }

        public void MessageReceived(MessagePartialTransportModel obj)
        {
            if (OnMessageReceived != null) OnMessageReceived(this, obj.Mapping<MessageReceivedEventArgs>());
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
