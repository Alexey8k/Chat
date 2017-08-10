using AutoMapper;
using BuisenessLevel.Model;
using DataLevel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisenessLevel.Mapping
{
    public static class UnreadMessagesResultDataModelExtension
    {
        public static UnreadMessagesResultModel Mapping(this UnreadMessagesResultDataModel obj)
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<UnreadMessagesResultDataModel, UnreadMessagesResultModel>();
                cfg.CreateMap<MessageDataModel, MessageModel>();
            });
            return Mapper.Map<UnreadMessagesResultDataModel, UnreadMessagesResultModel>(obj);
        }
    }
}
