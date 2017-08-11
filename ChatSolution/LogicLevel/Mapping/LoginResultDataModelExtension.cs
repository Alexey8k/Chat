using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransportLevel.ChatServiceReference;

namespace LogicLevel.Mapping
{
    public static class LoginResultTransportModelExtension
    {
        public static T Mapping<T>(this LoginResultTransportModel obj)
        {
            Mapper.Initialize(cfg => cfg.CreateMap<LoginResultTransportModel, T>());
            return Mapper.Map<LoginResultTransportModel, T>(obj);
        }
    }
}
