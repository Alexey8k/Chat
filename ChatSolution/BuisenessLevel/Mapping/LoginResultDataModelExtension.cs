using AutoMapper;
using DataLevel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisenessLevel.Mapping
{
    public static class LoginResultDataModelExtension
    {
        public static T Mapping<T>(this LoginResultDataModel obj)
        {
            Mapper.Initialize(cfg => cfg.CreateMap<LoginResultDataModel, T>());
            return Mapper.Map<LoginResultDataModel, T>(obj);
        }
    }
}
