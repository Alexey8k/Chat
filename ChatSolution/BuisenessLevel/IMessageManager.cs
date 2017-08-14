using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuisenessLevel.Model;

namespace BuisenessLevel
{
    public interface IMessageManager
    {
        void ReceivedMessage(MessagePartialModel obj);

        UnreadMessagesResultModel GetUnreadMessages(LoginSuccessModel obj);
    }
}
