using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ChatServise.DataContract
{
    [DataContract]
    public class UsersObjectIn  //UsersObjectIn() вернет коллекцию онлайн пользователей
    {
        public List<UserModel> Users = new List<UserModel>();//хранит коллекцию онлайн пользователей
    }
}
