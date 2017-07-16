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
        public MessageDataModel[] GetMessages(int userId)
        {
            Mapper.Initialize(cfg => cfg.CreateMap<GetMessages_Result, MessageDataModel>());
            return Mapper.Map<ObjectResult<GetMessages_Result>, MessageDataModel[]>(_chatDb.GetMessages(userId));
        }
    }
}
