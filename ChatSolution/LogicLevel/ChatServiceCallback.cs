using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using LogicLevel.ChatServiceReference;
using LogicLevel.EventArg;
using LogicLevel.Mapping;

namespace LogicLevel
{
    [CallbackBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
    internal class ChatServiceCallback : IChatServiceCallback
    {
        private object _locker = new object();

        public event EventHandler<UserJoinedEventArgs> OnUserJoined;

        public event EventHandler<UserLeavedEventArgs> OnUserLeave;

        public event EventHandler<MessageReceivedEventArgs> OnMessageReceived;

        public event EventHandler<OnlineUsersEventArgs> OnlineUsersReceived;

        public event EventHandler<CurrentUserEventArgs> CurrentUserReceived;

        public event EventHandler<UnreadMessagesEventArgs> UnreadMessagesReceived;

        public void UserJoined(UserPartialTransportModel obj)
        {
            lock (_locker)
            {
                if (OnUserJoined != null) OnUserJoined(this, obj.Mapping<UserJoinedEventArgs>());
            }
        }

        public void UserLeave(UserLeavedTransportModel obj)
        {
            lock (_locker)
            {
                if (OnUserLeave != null) OnUserLeave(this, obj.Mapping<UserLeavedEventArgs>());
            }
        }

        public void MessageReceived(MessagePartialTransportModel obj)
        {
            lock (_locker)
            {
                if (OnMessageReceived != null) OnMessageReceived(this, obj.Mapping<MessageReceivedEventArgs>());
            }
        }

        public void OnlineUsers(OnlineUsersTransportModel obj)
        {
            lock (_locker)
            {
                if (OnlineUsersReceived != null) OnlineUsersReceived(this, obj.Mapping());
            }
        }

        public void CurrentUser(UserPartialTransportModel obj)
        {
            lock (_locker)
            {
                if (CurrentUserReceived != null) CurrentUserReceived(this, obj.Mapping<CurrentUserEventArgs>());
            }
        }

        public void UnreadMessages(UnreadMessagesTransportModel obj)
        {
            lock (_locker)
            {
                if (UnreadMessagesReceived != null) UnreadMessagesReceived(this, obj.Mapping());
            }
        }
    }
}
