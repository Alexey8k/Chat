using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicLevel.Mapping;
using LogicLevel.Model;
using TransportLevel;
using TransportLevel.ChatServiceReference;

namespace LogicLevel
{
    public class AuthorizationManager
    {
        private readonly IChatTransport _chatTransport;

        public AuthorizationManager(IChatTransport chatTransport)
        {
            _chatTransport = chatTransport;
        }

        public LoginResultModel Login(LoginModel obj)
        {
            return _chatTransport.Login(obj.Mapping<LoginTransportModel>()).Mapping<LoginResultModel>();
        }
        public void Logout(LogoutModel obj)
        {
            _chatTransport.Logout(obj.Mapping<LogoutTransportModel>());
        }
        public RegistrationResultModel Registration(RegistrationModel obj)
        {
            return _chatTransport.Registration(obj.Mapping<RegistrationTransportModel>()).Mapping<RegistrationResultModel>();
        }
    }
}
