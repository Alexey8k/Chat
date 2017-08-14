using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicLevel.ChatServiceReference;
using LogicLevel.Mapping;
using LogicLevel.Model;

namespace LogicLevel
{
    public interface IAuthorizationManager
    {
        Task<LoginResultModel> Login(LoginModel obj);

        void Logout(LogoutModel obj);

        Task<RegistrationResultModel> Registration(RegistrationModel obj);
    }
}
