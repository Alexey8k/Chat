using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChatServise.DataContract;
using System.ServiceModel;

namespace ChatServise
{
    //возможно этот файл надо удалить
    public interface IChatCallback//дуплексный контракт
    {
        [OperationContract]
        void UserJoined(UserJoinedObjectIn obj);//разослать всем что юзер присоеденился к чату

        [OperationContract]
        void UserLeaved(UserLeavedObjectIn obj);//разослать всем что юзер покинул чат

        [OperationContract]
        void Message(MessageObjectIn obj);//разослать всем такое то сообщение (у нас общий чат)

        [OperationContract]
        void SetUsers(UsersObjectIn obj);//метод который запускается методом Login (при входе пользователя) пользователю который только залогинился придут пользователи которые онлайн

        [OperationContract]
        void SetMessage(MessagesObjectIn obj);//метод который запускается методом Login (при входе пользователя) и показывает пользователю непрочитанные сообщения
    }

}
