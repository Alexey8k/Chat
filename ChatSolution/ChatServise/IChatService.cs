using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ChatServise.DataContract;

namespace ChatServise
{

    [ServiceContract(CallbackContract = typeof(IChatCallback), SessionMode = SessionMode.Allowed)]//для дуплексного контакта
    public interface IChatService
    {
        [OperationContract]
        LoginResultTransportModel Login(LoginTransportModel obj);//войти

        [OperationContract]
        void Logout(LogoutObjectIn obj);//выйти

        [OperationContract]
        void SendMessage(MessageObjectIn obj);//отправить сообщение

        [OperationContract]
        RegistrationResultTransportModel Registration(RegistrationTransportModel obj);//регистрация

        //[OperationContract]
        //void GetUsers();

        //[OperationContract]
        //void GetMessages();
    }

   
}
