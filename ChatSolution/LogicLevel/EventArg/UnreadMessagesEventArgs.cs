using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicLevel.ChatServiceReference;

namespace LogicLevel.EventArg
{
    public class UnreadMessagesEventArgs : EventArgs
    {
        public MessageTransportModel[] Messages { get; set; }
    }
}
