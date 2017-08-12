using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using ChatClient.ViewModel;

namespace ChatClient.Mapping
{
    internal static class LoginViewModelExtension
    {
        public static T Mapping<T>(this LoginViewModel obj)
        {
            Mapper.Initialize(cfg => cfg.CreateMap<LoginViewModel, T>());
            return Mapper.Map<LoginViewModel, T>(obj);
        }
    }
}
