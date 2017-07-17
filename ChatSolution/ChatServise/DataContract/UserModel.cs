using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ChatServise.DataContract
{
    [DataContract]
    public class UserModel
    {
        [DataMember]
        public int UserId { get; set; }//ID в базе данных (переместил в UserManager)
        [DataMember]
        public string Login { get; set; }

  
        public IChatCallback callBack { get; set; }//поле обр вызова
        //   public string passHesh { get; set; }//для проброски к БД для сверки

    }
}
