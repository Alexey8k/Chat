using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatServise.Model
{
    public class RegistrationModel:Attribute
    {
       public string Login { get;set; }
       public string Mail { get; set; }
       public string Password { get; set; }

    }
}
