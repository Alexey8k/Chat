using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using LogicLevel.Model;

namespace LogicLevel.Mapping
{
    public static class MessagePartialModelExtension
    {
        public static T Mapping<T>(this MessagePartialModel obj)
        {
            Mapper.Initialize(cfg => cfg.CreateMap<MessagePartialModel, T>());
            return Mapper.Map<MessagePartialModel, T>(obj);
        }
    }
}
