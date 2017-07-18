using AutoMapper;
using DataLevel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisenessLevel.Mapping
{
    public static class RegistrationResultDataModelExtension
    {
        public static T Mapping<T>(this RegistrationResultDataModel obj)
        {
            Mapper.Initialize(cfg => cfg.CreateMap<RegistrationResultDataModel, T>());
            return Mapper.Map<RegistrationResultDataModel, T>(obj);
        }
    }
}
