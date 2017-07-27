using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ChatServise.DataContract;

namespace ChatServise
{

    [ServiceContract(CallbackContract = typeof(IChatCallback))]
    public interface IChatService
    {
        [OperationContract]
        LoginResultTransportModel Login(LoginTransportModel obj);    //войти

        [OperationContract]
        void Logout(LogoutTransportModel obj);    //выйти

        [OperationContract]
        RegistrationResultTransportModel Registration(RegistrationTransportModel obj);    //регистрация

        [OperationContract]
        void SendMessage(MessagePartialTransportModel obj);    //отправить сообщение
    }

   
}
