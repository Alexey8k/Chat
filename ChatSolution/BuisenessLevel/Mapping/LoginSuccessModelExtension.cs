using AutoMapper;
using BuisenessLevel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisenessLevel.Mapping
{
    public static class LoginSuccessModelExtension
    {
        public static T Mapping<T>(this LoginSuccessModel obj)
        {
            Mapper.Initialize(cfg => cfg.CreateMap<LoginSuccessModel, T>());
            return Mapper.Map<LoginSuccessModel, T>(obj);
        }
    }
}
