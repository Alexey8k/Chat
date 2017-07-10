using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ChatServise
{

    [ServiceContract(CallbackContract = typeof(IChatClient), SessionMode = SessionMode.Allowed)]//для дуплексного контакта
    public interface IChatService
    {
        [OperationContract]
        LoginObjectOut Login(LoginObjectIn);//войти

        [OperationContract]
        void Logout(LogoutObjectIn);//выйти

        [OperationContract]
        void SendMessage(MessageObjectIn);//отправить сообщение

        [OperationContract]
        RegistrationObjectOut Registration(RegistrationObjectIn);//регистрация

        //[OperationContract]
        //void GetUsers();

        //[OperationContract]
        //void GetMessages();
    }

    public interface IChatCallback//дуплексный контракт
    {
        [OperationContract]
        void UserJoined(UserJoinedObjectIn);//разослать всем что юзер присоеденился к чату

        [OperationContract]
        void UserLeaved(UserLeavedObjectIn);//разослать всем что юзер покинул чат

        [OperationContract]
        void Message(MessageObjectIn);//разослать всем такое то сообщение (у нас общий чат)

        [OperationContract]
        void SetUsers(UsersobjectIn);//метод который запускается методом Login (при входе пользователя) пользователю который только залогинился придут пользователи которые онлайн

        [OperationContract]
        void SetMessage(MessageObjectIn);//метод который запускается методом Login (при входе пользователя) и показывает пользователю непрочитанные сообщения
    }

}
