using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using LogicLevel.ChatServiceReference;

namespace LogicLevel.Mapping
{
    public static class OnlineUsersTransportModelExtension
    {
        public static T Mapping<T>(this OnlineUsersTransportModel obj)
        {
            Mapper.Initialize(cfg => cfg.CreateMap<OnlineUsersTransportModel, T>());
            return Mapper.Map<OnlineUsersTransportModel, T>(obj);
        }
    }
}
