using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLevel.Model;
using DataLevel.Mapping;

namespace DataLevel
{
    class MessageManager : BaseManager
    {
        public MessageModel[] GetMessages()
        {
            return _chatDb.GetMessages()
        }
    }
}
