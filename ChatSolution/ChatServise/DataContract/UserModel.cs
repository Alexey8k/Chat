using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ChatServise.DataContract
{
    [DataContract]
    public class UserModel//возможно надо будет удалить
    {
        public int idUser { get; set; }//ID в базе данных
        public string login { get; set; }
    }
}
