using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatServise
{
   public class UserManager//для запоминания подключенных пользователей (онлайн юзеры) и работы с ними
    {
        public Dictionary<int, User> Users = new Dictionary<int, User>();//для запоминания подключенных пользователей (онлайн юзеры)
        
    }
}
