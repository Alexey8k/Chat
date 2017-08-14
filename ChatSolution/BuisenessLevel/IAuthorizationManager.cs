using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuisenessLevel.Model;

namespace BuisenessLevel
{
    public interface IAuthorizationManager
    {
        LoginResultModel Login(LoginModel obj);
        void Logout(LogoutModel obj);
        RegistrationResultModel Registration(RegistrationModel obj);
    }
}
