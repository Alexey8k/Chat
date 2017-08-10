using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportLevel.EventArg
{
    public class MessageReceivedEventArgs : EventArgs
    {
        public int UserId { get; set; }

        public string MessageText { get; set; }
    }
}
