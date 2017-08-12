using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using LogicLevel.EventArg;

namespace ChatClient.Mapping
{
    internal static class UserJoinedEventArgsExtension
    {
        public static T Mapping<T>(this UserJoinedEventArgs obj)
        {
            Mapper.Initialize(cfg => cfg.CreateMap<UserJoinedEventArgs, T>());
            return Mapper.Map<UserJoinedEventArgs, T>(obj);
        }
    }
}
