using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicLevel.Model;

namespace LogicLevel.EventArg
{
    public class OnlineUsersEventArgs : EventArgs
    {
        public UserPartialModel[] Users { get; set; }
    }
}
