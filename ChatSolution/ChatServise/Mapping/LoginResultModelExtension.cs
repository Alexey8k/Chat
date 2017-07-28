using AutoMapper;
using BuisenessLevel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatServise.Mapping
{
    public static class LoginResultModelExtension
    {
        public static T Mapping<T>(this LoginResultModel obj)
        {
            Mapper.Initialize(cfg => cfg.CreateMap<LoginResultModel, T>());
            return Mapper.Map<LoginResultModel, T>(obj);
        }
    }
}
