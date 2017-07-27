using BuisenessLevel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisenessLevel
{
    public interface IChat
    {
        LoginResultModel Login(LoginModel obj);

        void Logout(LogoutModel obj);

        RegistrationResultModel Registration(RegistrationModel obj);

        UserPartialModel GetCurrentUser(LoginSuccessModel obj);

        OnlineUsersResultModel GetOnlineUsers(LoginSuccessModel obj);

        void ReceivedMessage(MessagePartialModel obj);

        UnreadMessagesResultModel GetUnreadMessages(LoginSuccessModel obj);
    }
}
