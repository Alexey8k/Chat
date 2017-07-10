using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ChatServise.Model
{
    [DataContract]
    public class RegistrationModel
    {
       public string Login { get;set; }
       public string Mail { get; set; }
       public string Password { get; set; }

    }
}
