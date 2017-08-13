using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using LogicLevel.ChatServiceReference;

namespace LogicLevel.Mapping
{
    public static class RegistrationResultTransportModelExtension
    {
        public static T Mapping<T>(this Task<RegistrationResultTransportModel> obj)
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Task<RegistrationResultTransportModel>, T>();
                cfg.CreateMap<RegistrationResultTransportModel, T>();
            });
            return Mapper.Map<Task<RegistrationResultTransportModel>, T>(obj);
        }
    }
}
