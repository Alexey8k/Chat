using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using ChatClient.ViewModel;

namespace ChatClient.Mapping
{
    internal static class RegistrationViewModelExtension
    {
        public static T Mapping<T>(this RegistrationViewModel obj)
        {
            Mapper.Initialize(cfg => cfg.CreateMap<RegistrationViewModel, T>());
            return Mapper.Map<RegistrationViewModel, T>(obj);
        }
    }
}
