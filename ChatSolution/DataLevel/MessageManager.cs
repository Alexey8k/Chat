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
        public MessageDbModel[] GetMessages(int userId)
        {
            Mapper.Initialize(cfg => cfg.CreateMap<GetMessages_Result, MessageDbModel>());
            return Mapper.Map<ObjectResult<GetMessages_Result>, MessageDbModel[]>(_chatDb.GetMessages(userId));
        }
    }
}
