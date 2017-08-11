using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using LogicLevel.Model;

namespace LogicLevel.Mapping
{
    internal static class RegistrationModelExtension
    {
        public static T Mapping<T>(this RegistrationModel obj)
        {
            Mapper.Initialize(cfg => cfg.CreateMap<RegistrationModel, T>());
            return Mapper.Map<RegistrationModel, T>(obj);
        }
    }
}
