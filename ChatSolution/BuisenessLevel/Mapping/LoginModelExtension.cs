using AutoMapper;
using BuisenessLevel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisenessLevel.Mapping
{
    public static class LoginModelExtension
    {
        public static T Mapping<T>(this LoginModel obj)
        {
            Mapper.Initialize(cfg => cfg.CreateMap<LoginModel, T>());
            return Mapper.Map<LoginModel, T>(obj);
        }
    }
}
