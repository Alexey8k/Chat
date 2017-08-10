using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using TransportLevel.ChatServiceReference;

namespace TransportLevel.Mapping
{
    internal static class UserPartialTransportModelExtension
    {
        public static T Mapping<T>(this UserPartialTransportModel obj)
        {
            Mapper.Initialize(cfg => cfg.CreateMap<UserPartialTransportModel, T>());
            return Mapper.Map<UserPartialTransportModel, T>(obj);
        }
    }
}
