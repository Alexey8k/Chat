using AutoMapper;
using BuisenessLevel.Model;
using ChatServise.DataContract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatServise.Mapping
{
    public static class UnreadMessagesModelExtension
    {
        public static UnreadMessagesTransportModel Mapping(this UnreadMessagesResultModel obj)
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<UnreadMessagesResultModel, UnreadMessagesTransportModel>();
                cfg.CreateMap<MessagePartialModel, MessagePartialTransportModel>();
            });
            return Mapper.Map<UnreadMessagesResultModel, UnreadMessagesTransportModel>(obj);
        }
    }
}
