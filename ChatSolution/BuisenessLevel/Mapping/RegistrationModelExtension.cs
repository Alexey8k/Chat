using AutoMapper;
using BuisenessLevel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisenessLevel.Mapping
{
    public static class RegistrationModelExtension
    {
        public static T Mapping<T>(this RegistrationModel obj)
        {
            Mapper.Initialize(cfg => cfg.CreateMap<RegistrationModel, T>());
            return Mapper.Map<RegistrationModel, T>(obj);
        }
    }
}
