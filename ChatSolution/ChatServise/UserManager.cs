using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ChatServise.DataContract
{
    [DataContract]
    public class UserManager//для запоминания подключенных пользователей (онлайн юзеры) и работы с ними
    {
        public Dictionary<int, User> Users = new Dictionary<int, User>();//для запоминания подключенных пользователей (онлайн юзеры idUser, User)

        public List<string> SetUsers()//список онлайн юзеров
        {
            List<string> UsersOnline = new List<string>();

            foreach (var item in Users)
            {
                UsersOnline.Add(item.Value.login);
            }
            return UsersOnline;
        }

        public MessagesObjectIn SetMessage()//список непрочитанных сообщений
        {
            BuisnessLevel.Login business = new BuisnessLevel.Login();
            business.SetMessage(MessagesModelIn)
        }
    }
}
