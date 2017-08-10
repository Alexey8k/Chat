using AutoMapper;
using DataLevel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisenessLevel.Mapping
{
    public static class UserPartialDataModelExtension
    {
        public static T Mapping<T>(this UserPartialDataModel obj)
        {
            Mapper.Initialize(cfg => cfg.CreateMap<UserPartialDataModel, T>());
            return Mapper.Map<UserPartialDataModel, T>(obj);
        }
    }
}
