using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicLevel.ChatServiceReference;

namespace LogicLevel.EventArg
{
    public class OnlineUsersEventArgs : EventArgs
    {
        public UserPartialTransportModel[] Users { get; set; }
    }
}
