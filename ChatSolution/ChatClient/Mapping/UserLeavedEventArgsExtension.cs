using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using LogicLevel.EventArg;

namespace ChatClient.Mapping
{
    internal static class UserLeavedEventArgsExtension
    {
        public static T Mapping<T>(this UserLeavedEventArgs obj)
        {
            Mapper.Initialize(cfg => cfg.CreateMap<UserLeavedEventArgs, T>());
            return Mapper.Map<UserLeavedEventArgs, T>(obj);
        }
    }
}
