using AutoMapper;
using ChatServise.DataContract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatServise.Mapping
{
    public static class LoginTransportModelExtension
    {
        public static T Mapping<T>(this LoginTransportModel obj)
        {
            Mapper.Initialize(cfg => cfg.CreateMap<LoginTransportModel, T>());
            return Mapper.Map<LoginTransportModel, T>(obj);
        }
    }
}
