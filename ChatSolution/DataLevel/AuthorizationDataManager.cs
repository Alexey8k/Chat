using DataLevel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLevel
{
    class AuthorizationDataManager : BaseDataManager
    {
        public LoginResultDataModel Login(LoginDataModel obj)
        {
            return new LoginResultDataModel { Result = (LoginDataResult)_chatDb.Login(obj.Hash).FirstOrDefault() };
        }
        public void Logout(LogoutDataModel obj)
        {
            _chatDb.Logout(obj.UserId);
        }
        public RegistrationResultDataModel Registration(RegistrationDataModel obj)
        {
            return new RegistrationResultDataModel
            {
                Result = (RegistrationDataResult)_chatDb.Registration(obj.Login, obj.Hash, obj.Email).FirstOrDefault()
            };
        }
    }
}
