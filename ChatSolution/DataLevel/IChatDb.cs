using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLevel.Model;

namespace DataLevel
{
    interface IChatDb
    {
        LoginResultDataModel Login(LoginDataModel obj);
        void Logout(LoginDataModel obj);
        RegistrationResultDataModel Registration(RegistrationDataModel obj);
        UserDataModel GetUser(LoginDataModel obj);
        MessageDataModel[] GetMessages(LoginDataModel obj);

    }
}
