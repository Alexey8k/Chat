using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransportLevel.ChatServiceReference;

namespace TransportLevel.EventArg
{
    public class UnreadMessagesEventArgs : EventArgs
    {
        public MessageTransportModel[] Messages { get; set; }
    }
}
