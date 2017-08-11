using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicLevel.Mapping;
using LogicLevel.Model;
using TransportLevel;
using TransportLevel.EventArg;

namespace LogicLevel
{
    public class UserManager
    {
        private readonly IChatTransport _chatTransport;

        public event EventHandler<UserJoinedEventArgs> UserJoined
        {
            add { _chatTransport.UserJoined += value; }
            remove { _chatTransport.UserJoined -= value; }
        }

        public event EventHandler<UserLeavedEventArgs> UserLeaved
        {
            add { _chatTransport.UserLeaved += value; }
            remove { _chatTransport.UserLeaved -= value; }
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

        public UserManager(IChatTransport chatTransport)
        {
            _chatTransport = chatTransport;
        }
    }
}
