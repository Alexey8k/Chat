using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicLevel.EventArg;

namespace LogicLevel
{
    public class UserManager
    {
        private readonly ChatTransport _chatTransport;

        public UserManager(ChatTransport chatTransport)
        {
            _chatTransport = chatTransport;
        }

        public event EventHandler<UserJoinedEventArgs> OnUserJoined
        {
            add { _chatTransport.OnUserJoined += value; }
            remove { _chatTransport.OnUserJoined -= value; }
        }

        public event EventHandler<UserLeavedEventArgs> OnUserLeave
        {
            add { _chatTransport.OnUserLeave += value; }
            remove { _chatTransport.OnUserLeave -= value; }
        }

        public event EventHandler<OnlineUsersEventArgs> OnlineUsersReceived
        {
            add { _chatTransport.OnlineUsersReceived += value; }
            remove { _chatTransport.OnlineUsersReceived -= value; }
        }

        public event EventHandler<CurrentUserEventArgs> CurrentUserReceived
        {
            add { _chatTransport.CurrentUserReceived += value; }
            remove { _chatTransport.CurrentUserReceived -= value; }
        }
    }
}
