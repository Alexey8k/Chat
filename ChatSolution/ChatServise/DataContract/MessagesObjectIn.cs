using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ChatServise.DataContract
{
    [DataContract]
    public class MessagesObjectIn //вернет коллекцию непрочитанных сообщений
    {
        public List<MessagesModelIn> Messages = new List<MessagesModelIn>();
    }
}
