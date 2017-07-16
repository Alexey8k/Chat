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
        public MessageModel[] GetMessages(int userId)
        {
            Mapper.Initialize(cfg => cfg.CreateMap<GetMessages_Result, MessageModel>());
            return Mapper.Map<ObjectResult<GetMessages_Result>, MessageModel[]>(_chatDb.GetMessages(userId));
        }
    }
}
