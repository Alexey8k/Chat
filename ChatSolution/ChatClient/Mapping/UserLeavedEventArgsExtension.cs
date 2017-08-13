using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using LogicLevel.EventArg;
using LogicLevel.Model;

namespace ChatClient.Mapping
{
    internal static class UserLeavedEventArgsExtension
    {
        public static UserPartialModel Mapping(this UserLeavedEventArgs obj)
        {
            Mapper.Initialize(cfg => cfg.CreateMap<UserLeavedEventArgs, UserPartialModel>().ForMember(u => u.Id,
                opt => opt.MapFrom(u => u.UserId)));
            return Mapper.Map<UserLeavedEventArgs, UserPartialModel>(obj);
        }
    }
}
