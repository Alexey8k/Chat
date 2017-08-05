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
        private readonly IChat _chat;

        private readonly MessageTransportManager _messenger;

        public ChatService()
        {
            IChatDb chatDb = new ChatDb();
            _chat = new Chat(new UserManager(chatDb), new AuthorizationManager(chatDb), new MessageManager(chatDb));
            _messenger = new MessageTransportManager(_chat);
        }

        public LoginResultTransportModel Login(LoginTransportModel obj)    // войти
        {
            var resultLogin = _chat.Login(obj.Mapping<LoginModel>());
            if (resultLogin.Result == LoginResult.Ok)
            {
                _messenger.UserJoined(resultLogin.Mapping<LoginSuccessModel>());
            }
            return resultLogin.Mapping<LoginResultTransportModel>();
        }

        public void Logout(LogoutTransportModel obj)    // выйти
        {
            _chat.Logout(obj.Mapping<LogoutModel>());
            _messenger.UserLeaved(obj.Mapping<UserLeavedTransportModel>());
        }

        public void SendMessage(MessagePartialTransportModel obj)    // отправить сообщение
        {
            _messenger.SendMessage(obj);
        }

        public RegistrationResultTransportModel Registration(RegistrationTransportModel obj)    // регистрация
        {
            return _chat.Registration(obj.Mapping<RegistrationModel>()).Mapping<RegistrationResultTransportModel>();
        }
    }
}
