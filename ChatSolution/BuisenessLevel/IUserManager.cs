using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuisenessLevel.Model;

namespace BuisenessLevel
{
    public interface IUserManager
    {
        UserPartialModel GetCurrentUser(LoginSuccessModel obj);

        OnlineUsersResultModel GetOnlineUsers(LoginSuccessModel obj);

        void RemoveUser(LogoutModel obj);

        bool IsOnline(LoginModel obj);
    }
}
