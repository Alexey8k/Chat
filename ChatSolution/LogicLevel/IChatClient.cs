using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicLevel.EventArg;
using LogicLevel.Model;

namespace LogicLevel
{
    public interface IChatClient
    {
        event EventHandler<UserJoinedEventArgs> OnUserJoined;

        event EventHandler<UserLeavedEventArgs> OnUserLeave;

        event EventHandler<MessageReceivedEventArgs> OnMessageReceived;

        event EventHandler<OnlineUsersEventArgs> OnlineUsersReceived;

        event EventHandler<CurrentUserEventArgs> CurrentUserReceived;

        event EventHandler<UnreadMessagesEventArgs> UnreadMessagesReceived;

        LoginResultModel Login(LoginModel obj);

        void Logout(LogoutModel obj);

        RegistrationResultModel Registration(RegistrationModel obj);

        void SendMessage(MessagePartialModel obj);
    }
}
