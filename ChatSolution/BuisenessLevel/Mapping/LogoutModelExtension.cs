using AutoMapper;
using BuisenessLevel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisenessLevel.Mapping
{
    public static class LogoutModelExtension
    {
        public static T Mapping<T>(this LogoutModel obj)
        {
            Mapper.Initialize(cfg => cfg.CreateMap<LogoutModel, T>());
            return Mapper.Map<LogoutModel, T>(obj);
        }
    }
}
