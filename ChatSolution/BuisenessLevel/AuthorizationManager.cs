using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using BuisenessLevel.Model;
using BuisenessLevel.Mapping;
using DataLevel;
using DataLevel.Model;

namespace BuisnessLevel
{
    public class AuthorizationManager
    {
        public AuthorizationManager(IChatDb chatDb)
        {
            _chatDb = chatDb;
        }
        private readonly IChatDb _chatDb;
        public LoginResultModel Login(LoginModel obj)
        {
            return _chatDb.Login(obj.Mapping<LoginDataModel>()).Mapping<LoginResultModel>();
        }
        public void Logout(LogoutModel obj)
        {
            _chatDb.Logout(obj.Mapping<LogoutDataModel>());
        }
        public RegistrationResultModel Registration(RegistrationModel obj)
        {
            return _chatDb.Registration(obj.Mapping<RegistrationDataModel>()).Mapping<RegistrationResultModel>();
        }
    }
}
