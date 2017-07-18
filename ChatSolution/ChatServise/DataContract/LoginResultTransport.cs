using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ChatServise.DataContract
{
    [DataContract]
    public enum LoginResult : byte
    {
        [EnumMember]
        Ok,
        [EnumMember]
        Online,
        [EnumMember]
        Fail
    }
}
