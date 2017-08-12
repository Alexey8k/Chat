using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using LogicLevel.ChatServiceReference;
using LogicLevel.EventArg;
using LogicLevel.Model;

namespace LogicLevel.Mapping
{
    public static class UnreadMessagesTransportModelExtension
    {
        public static UnreadMessagesEventArgs Mapping(this UnreadMessagesTransportModel obj)
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<UnreadMessagesTransportModel, UnreadMessagesEventArgs>();
                cfg.CreateMap<MessagePartialTransportModel, MessagePartialModel>();
            });
            return Mapper.Map<UnreadMessagesTransportModel, UnreadMessagesEventArgs>(obj);
        }
    }
}
