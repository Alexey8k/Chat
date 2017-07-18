using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLevel.Model;

namespace DataLevel
{
    public interface IChatDb
    {
        LoginResultDataModel Login(LoginDataModel obj);
        void Logout(LogoutDataModel obj);
        RegistrationResultDataModel Registration(RegistrationDataModel obj);
        UserDataModel GetCurrentUser(LoginDataModel obj);
        MessageDataModel[] GetUnreadMessages(GetUnreadMessagesDataModel obj);
        void AddMessage(MessageAddDataModel obj);
    }
}
