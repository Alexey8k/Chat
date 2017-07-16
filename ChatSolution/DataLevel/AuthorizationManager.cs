using DataLevel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLevel
{
    class AuthorizationManager : BaseManager
    {
        public LoginResultModel Login(LoginModel obj)
        {
            return new LoginResultModel { Result = _chatDb.Login(obj.Hash).FirstOrDefault() };
        }
        public void Logout(LogoutModel obj)
        {
            _chatDb.Logout(obj.UserId);
        }
        public RegistrationResultModel Registration(RegistrationModel obj)
        {
            return new RegistrationResultModel
            {
                Result = _chatDb.Registration(obj.Login, obj.Hash, obj.Email).FirstOrDefault()
            };
        }
    }
}
