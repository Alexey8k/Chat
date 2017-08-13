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
        public UnreadMessagesResultDataModel GetUnreadMessages(LoginSuccessDataModel obj)
        {
            Mapper.Initialize(cfg => cfg.CreateMap<MessageResult, MessageDataModel>().ForMember(
                m => m.MessageText, opt => opt.MapFrom(m => m.Text)));
            return new UnreadMessagesResultDataModel
            {
                Messages = Mapper.Map<ObjectResult<MessageResult>, MessageDataModel[]>(_chatDb.GetUnreadMessages(obj.UserId))
            };
        }

        public void AddMessage(MessagePartialDataModel obj)
        {
            _chatDb.AddMessage(obj.MessageText, obj.UserId);
        }
    }
}
