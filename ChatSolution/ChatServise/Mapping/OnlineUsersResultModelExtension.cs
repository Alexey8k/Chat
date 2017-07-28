using AutoMapper;
using BuisenessLevel.Model;
using ChatServise.DataContract;
using DataLevel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatServise.Mapping
{
    public static class OnlineUsersResultModelExtension
    {
        public static OnlineUsersTransportModel Mapping(this OnlineUsersResultModel obj)
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<OnlineUsersResultModel, OnlineUsersTransportModel>();
                cfg.CreateMap<UserPartialModel, UserPartialTransportModel>();
            });
            return Mapper.Map<OnlineUsersResultModel, OnlineUsersTransportModel>(obj);
        }
    }
}
