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
    public static class OnlineUsersTransportModelExtension
    {
        public static OnlineUsersEventArgs Mapping(this OnlineUsersTransportModel obj)
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<OnlineUsersTransportModel, OnlineUsersEventArgs>();
                cfg.CreateMap<UserPartialTransportModel, UserPartialModel>();
            });
            return Mapper.Map<OnlineUsersTransportModel, OnlineUsersEventArgs>(obj);
        }
    }
}
