﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ChatServise.DataContract
{
    [DataContract]
    public class RegistrationTransportModel
    {
        [DataMember]
        public string Login { get; set; }

        [DataMember]
        public string Email { get; set; }

        [DataMember]
        public byte[] Hash { get; set; }
    }
}
