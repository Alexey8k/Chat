using AutoMapper;
using BuisenessLevel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatServise.Mapping
{
    public static class UserPartialModelExtension
    {
        public static T Mapping<T>(this UserPartialModel obj)
        {
            Mapper.Initialize(cfg => cfg.CreateMap<UserPartialModel, T>());
            return Mapper.Map<UserPartialModel, T>(obj);
        }
    }
}
