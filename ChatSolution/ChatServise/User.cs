using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatServise
{
    public class User//хранит поля для работы с пользователем
    {
      //  public int idUser { get; set; }//ID в базе данных (переместил в UserManager)
        public string login { get; set; }
        public IChatCallback call { get; set; }//поле обр вызова
    }
}
