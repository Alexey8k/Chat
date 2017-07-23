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
    class MessageDataManager : BaseDataManager  // менеджер сообщений
    {
        public MessageDataModel[] GetUnreadMessages(LoginSuccessDataModel obj)
        {
            Mapper.Initialize(cfg => cfg.CreateMap<MessageResult, MessageDataModel>());
            return Mapper.Map<ObjectResult<MessageResult>, MessageDataModel[]>(_chatDb.GetUnreadMessages(obj.UserId));
        }

        public void AddMessage(MessageAddDataModel obj)
        {
            _chatDb.AddMessage(obj.MessageText, obj.UserId);
        }
    }
}
