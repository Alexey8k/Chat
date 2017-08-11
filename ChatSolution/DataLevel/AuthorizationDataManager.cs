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
            var result = _chatDb.Login(obj.Hash).FirstOrDefault();
            return new LoginResultDataModel
            {
                Result = result >= 100 ? LoginResaltData.Ok : (LoginResaltData)result,
                UserId = result >= 100 ? result : null
            };
        }
        public void Logout(LogoutDataModel obj)
        {
            _chatDb.Logout(obj.UserId);
        }
        public RegistrationResultDataModel Registration(RegistrationDataModel obj)
        {
            return new RegistrationResultDataModel
            {
                Result = (RegistrationResultData)_chatDb.Registration(obj.Login, obj.Hash, obj.Email).FirstOrDefault()
            };
        }
    }
}
