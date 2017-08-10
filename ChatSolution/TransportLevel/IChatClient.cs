using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransportLevel.ChatServiceReference;
using TransportLevel.EventArg;

namespace TransportLevel
{
    public interface IChatClient
    {
        event EventHandler<UserJoinedEventArgs> UserJoined;

        event EventHandler<UserLeavedEventArgs> UserLeaved;

        event EventHandler<MessageReceivedEventArgs> MessageReceived;

        event EventHandler<OnlineUsersEventArgs> OnlineUsersReceived;

        event EventHandler<CurrentUserEventArgs> CurrentUserReceived;

        event EventHandler<UnreadMessagesEventArgs> UnreadMessagesReceived;

        LoginResultTransportModel Login(LoginTransportModel obj);

        void Logout(LogoutTransportModel obj);

        RegistrationResultTransportModel Registration(RegistrationTransportModel obj);

        void SendMessage(MessagePartialTransportModel obj);
    }
}
