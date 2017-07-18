using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ChatServise.DataContract
{
    [DataContract]
    public class MessageObjectIn
    {
       public RegistrationResultTransport regresult { get; set; }
    }
}
