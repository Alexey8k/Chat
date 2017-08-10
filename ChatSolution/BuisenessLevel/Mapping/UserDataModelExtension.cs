﻿using AutoMapper;
using DataLevel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisenessLevel.Mapping
{
    public static class UserDataModelExtension
    {
        public static T Mapping<T>(this UserDataModel obj)
        {
            Mapper.Initialize(cfg => cfg.CreateMap<UserDataModel, T>());
            return Mapper.Map<UserDataModel, T>(obj);
        }
    }
}
