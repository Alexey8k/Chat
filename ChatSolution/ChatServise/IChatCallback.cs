using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChatServise.DataContract;
using System.ServiceModel;

namespace ChatServise
{
    public interface IChatCallback    // дуплексный контракт
    {
        [OperationContract(IsOneWay = true)]
        void UserJoined(UserPartialTransportModel obj);    // разослать всем что юзер присоеденился к чату

        [OperationContract(IsOneWay = true)]
        void UserLeaved(UserLeavedTransportModel obj);    // разослать всем что юзер покинул чат

        [OperationContract(IsOneWay = true)]
        void MessageReceived(MessagePartialTransportModel obj);    // разослать всем такое то сообщение (у нас общий чат)

        [OperationContract(IsOneWay = true)]
        void OnlineUsers(OnlineUsersTransportModel obj);    // метод который запускается методом Login (при входе пользователя) пользователю который только залогинился придут пользователи которые онлайн

        [OperationContract(IsOneWay = true)]
        void CurrentUser(UserPartialTransportModel obj);

        [OperationContract(IsOneWay = true)]
        void UnreadMessages(UnreadMessagesTransportModel obj);    // метод который запускается методом Login (при входе пользователя) и показывает пользователю непрочитанные сообщения
    }

}
