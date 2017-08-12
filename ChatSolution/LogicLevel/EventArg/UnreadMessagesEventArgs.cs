using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicLevel.Model;

namespace LogicLevel.EventArg
{
    public class UnreadMessagesEventArgs : EventArgs
    {
        public MessageModel[] Messages { get; set; }
    }
}
