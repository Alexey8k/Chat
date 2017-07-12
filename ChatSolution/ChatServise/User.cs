using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ChatServise.DataContract
{
    [DataContract]
    public class User//хранит поля для работы с пользователем
    {
      //  public int idUser { get; set; }//ID в базе данных (переместил в UserManager)
        public string login { get; set; }
        public IChatCallback callBack { get; set; }//поле обр вызова
     //   public string passHesh { get; set; }//для проброски к БД для сверки
    }
}
