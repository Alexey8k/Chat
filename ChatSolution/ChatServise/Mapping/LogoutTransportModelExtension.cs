using AutoMapper;
using ChatServise.DataContract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatServise.Mapping
{
    public static class LogoutTransportModelExtension
    {
        public static T Mapping<T>(this LogoutTransportModel obj)
        {
            Mapper.Initialize(cfg => cfg.CreateMap<LogoutTransportModel, T>());
            return Mapper.Map<LogoutTransportModel, T>(obj);
        }
    }
}
