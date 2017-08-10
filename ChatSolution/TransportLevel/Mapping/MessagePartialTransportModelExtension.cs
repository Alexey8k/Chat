﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using TransportLevel.ChatServiceReference;

namespace TransportLevel.Mapping
{
    internal static class MessagePartialTransportModelExtension
    {
        public static T Mapping<T>(this MessagePartialTransportModel obj)
        {
            Mapper.Initialize(cfg => cfg.CreateMap<MessagePartialTransportModel, T>());
            return Mapper.Map<MessagePartialTransportModel, T>(obj);
        }
    }
}
