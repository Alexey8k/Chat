using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using ChatClient.ViewModel;

namespace ChatClient.Mapping
{
    internal static class ChatViewModelExtension
    {
        public static T Mapping<T>(this ChatViewModel obj)
        {
            Mapper.Initialize(cfg => cfg.CreateMap<ChatViewModel, T>());
            return Mapper.Map<ChatViewModel, T>(obj);
        }
    }
}
