using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using TransportLevel.ChatServiceReference;
using TransportLevel.Mapping;
using TransportLevel.EventArg;

namespace TransportLevel
{
    [CallbackBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
    internal class CallbackChatService : IChatServiceCallback
    {
        public event EventHandler<UserJoinedEventArgs> EventUserJoined;

        public event EventHandler<UserLeavedEventArgs> EventUserLeaved;

        public event EventHandler<MessageReceivedEventArgs> EventMessageReceived;

        public event EventHandler<OnlineUsersEventArgs> OnlineUsersReceived;

        public event EventHandler<CurrentUserEventArgs> CurrentUserReceived;

        public event EventHandler<UnreadMessagesEventArgs> UnreadMessagesReceived;

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
    }
}
