using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransportLevel.ChatServiceReference;

namespace TransportLevel.EventArg
{
    public class OnlineUsersEventArgs : EventArgs
    {
        public UserPartialTransportModel[] Users { get; set; }
    }
}
