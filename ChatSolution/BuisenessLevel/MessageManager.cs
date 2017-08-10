using BuisenessLevel.Model;
using DataLevel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuisenessLevel.Mapping;
using DataLevel.Model;

namespace BuisenessLevel
{
    public class MessageManager
    {
        private readonly IChatDb _chatDb;

        public MessageManager(IChatDb chatDb)
        {
            _chatDb = chatDb;
        }

        public void ReceivedMessage(MessagePartialModel obj)
        {
            _chatDb.AddMessage(obj.Mapping<MessagePartialDataModel>());
        }

        public UnreadMessagesResultModel GetUnreadMessages(LoginSuccessModel obj)
        {
            return _chatDb.GetUnreadMessages(obj.Mapping<LoginSuccessDataModel>()).Mapping();
        }
    }
}
