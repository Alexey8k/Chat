using AutoMapper;
using ChatServise.DataContract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatServise.Mapping
{
    public static class RegistrationTransportModelExtension
    {
        public static T Mapping<T>(this RegistrationTransportModel obj)
        {
            Mapper.Initialize(cfg => cfg.CreateMap<RegistrationTransportModel, T>());
            return Mapper.Map<RegistrationTransportModel, T>(obj);
        }
    }
}
