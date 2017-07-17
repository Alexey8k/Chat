using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLevel.Model;
using AutoMapper;
using System.Data.Entity.Core.Objects;

namespace DataLevel
{
    class MessageManager : BaseManager
    {
        public MessageDataModel[] GetUnreadMessages(GetUnreadMessagesDataModel obj)
        {
            Mapper.Initialize(cfg => cfg.CreateMap<GetMessages_Result, MessageDataModel>());
            return Mapper.Map<ObjectResult<GetMessages_Result>, MessageDataModel[]>(_chatDb.GetMessages(obj.UserId));
        }

        public void AddMessage(MessageAddDataModel obj)
        {
            _chatDb.AddMessage(obj.MessageText, obj.UserId);
        }
    }
}
