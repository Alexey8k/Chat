using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using LogicLevel.EventArg;

namespace LogicLevel.Mapping
{
    public static class CurrentUserEventArgsExtension
    {
        public static T Mapping<T>(this CurrentUserEventArgs obj)
        {
            Mapper.Initialize(cfg => cfg.CreateMap<CurrentUserEventArgs, T>());
            return Mapper.Map<CurrentUserEventArgs, T>(obj);
        }
    }
}
