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
        public Dictionary<int, UserModel> Users = new Dictionary<int, UserModel>();//для запоминания подключенных пользователей (онлайн юзеры idUser, User)

        public IEnumerable<string> GetUsers()//список онлайн юзеров
        {
            return Users.Values.Select(u => u.Login).ToList();
        }

        

        

    }
}
