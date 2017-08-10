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
        public static T Mapping<T>(this MessagePartialModel obj)
        {
            Mapper.Initialize(cfg => cfg.CreateMap<MessagePartialModel, T>());
            return Mapper.Map<MessagePartialModel, T>(obj);
        }
    }
}
