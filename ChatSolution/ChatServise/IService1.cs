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
        //AuthModel 
        //AuthModelResponse
        [OperationContract]
        void Login();

        [OperationContract]
        void Logout();

        [OperationContract]
        void SendMessage();

        [OperationContract]
        void Registration();

        [OperationContract]
        void GetUsers();

        [OperationContract]
        void GetMessages();
    }

    public interface IChatClient//дуплексный контракт (исправить string s)
    {
        [OperationContract]
        void UserJoined(string s);
        [OperationContract]
        void UserLeaved(string s);
        [OperationContract]
        void MessageReceived(string s);
    }

}
