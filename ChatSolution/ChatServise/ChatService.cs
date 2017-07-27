using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;//для передачи пользовательского типа данных
using System.ServiceModel;
using System.Text;
using System.Threading;
using ChatServise.DataContract;
using BuisenessLevel;
using DataLevel;
using ChatServise.Mapping;
using BuisenessLevel.Model;

namespace ChatServise
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single, ConcurrencyMode = ConcurrencyMode.Multiple)]
    public class ChatService : IChatService
    {
        private IChat _chat;

        private Dictionary<int, IChatCallback> _callback = new Dictionary<int, IChatCallback>();

        public ChatService()
        {
            IChatDb chatDb = new ChatDb();
            _chat = new Chat(new UserManager(chatDb), new AuthorizationManager(chatDb), new MessageManager(chatDb));
        }

        public LoginResultTransportModel Login(LoginTransportModel obj)    // войти
        {
            var resultLogin = _chat.Login(obj.Mapping<LoginModel>());
            if (resultLogin.Result == LoginResult.Ok)
            {

            }
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
