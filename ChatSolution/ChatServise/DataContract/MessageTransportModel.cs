﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ChatServise.DataContract
{
   [DataContract]
   public class MessageTransportModel
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string MessageText { get; set; }

        [DataMember]
        public DateTime Date { get; set; }

        [DataMember]
        public int UserId { get; set; }
    }
}
