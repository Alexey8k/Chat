using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportLevel.EventArg
{
    public class UserJoinedEventArgs : EventArgs
    {
        public int Id { get; set; }
        public string Login { get; set; }
    }
}
