using AutoMapper;
using BuisenessLevel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisenessLevel.Mapping
{
    public static class MessageReceiveModelExtension
    {
        public static T Mapping<T>(this MessageReceiveModel obj)
        {
            Mapper.Initialize(cfg => cfg.CreateMap<MessageReceiveModel, T>());
            return Mapper.Map<MessageReceiveModel, T>(obj);
        }
    }
}
