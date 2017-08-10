using AutoMapper;
using BuisenessLevel.Model;
using ChatServise.DataContract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatServise.Mapping
{
    public static class RegistrationResultModelExtension
    {
        public static T Mapping<T>(this RegistrationResultModel obj)
        {
            Mapper.Initialize(cfg => cfg.CreateMap<RegistrationResultModel, T>());
            return Mapper.Map<RegistrationResultModel, T>(obj);
        }
    }
}
