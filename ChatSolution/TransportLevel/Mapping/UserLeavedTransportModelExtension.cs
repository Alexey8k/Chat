using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using TransportLevel.ChatServiceReference;

namespace TransportLevel.Mapping
{
    internal static class UserLeavedTransportModelExtension
    {
        public static T Mapping<T>(this UserLeavedTransportModel obj)
        {
            Mapper.Initialize(cfg => cfg.CreateMap<UserLeavedTransportModel, T>());
            return Mapper.Map<UserLeavedTransportModel, T>(obj);
        }
    }
}
