using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;//для передачи пользовательского типа данных
using System.ServiceModel;
using System.Text;
using System.Threading;
using ChatServise.DataContract;


namespace ChatServise
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single, ConcurrencyMode = ConcurrencyMode.Multiple)]
    public class ChatService : IChatService
    {
        public LoginResultTransportModel Login(LoginTransportModel obj)    // войти
        {
            
            return new LoginResultTransportModel();
        }

        public void Logout(LogoutTransportModel obj)    // выйти
        {
            
        }

        public void SendMessage(MessagePartialTransportModel obj)    // отправить сообщение
        {
            
        }

        public RegistrationResultTransportModel Registration(RegistrationTransportModel obj)    // регистрация
        {

            return new RegistrationResultTransportModel();
        }
    }
}
