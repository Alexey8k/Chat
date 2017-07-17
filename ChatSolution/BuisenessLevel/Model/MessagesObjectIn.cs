using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisenessLevel.Model
{
    class MessagesObjectIn//вернет коллекцию непрочитанных сообщений в BuisenessLevel.Model
    {
        //   public List<MessagesModelIn> Messages = new List<MessagesModelIn>();
        public Dictionary<string, MessagesModelIn> Messages = new Dictionary<string, MessagesModelIn>();// string - Login пользователя который отправил сообщение
    }
}
