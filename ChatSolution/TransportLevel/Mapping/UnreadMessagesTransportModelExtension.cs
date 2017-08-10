using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using TransportLevel.ChatServiceReference;

namespace TransportLevel.Mapping
{
    internal static class UnreadMessagesTransportModelExtension
    {
        public static T Mapping<T>(this UnreadMessagesTransportModel obj)
        {
            Mapper.Initialize(cfg => cfg.CreateMap<UnreadMessagesTransportModel, T>());
            return Mapper.Map<UnreadMessagesTransportModel, T>(obj);
        }
    }
}
