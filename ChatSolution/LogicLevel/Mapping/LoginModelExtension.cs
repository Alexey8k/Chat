using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicLevel.ChatServiceReference;
using LogicLevel.Model;

namespace LogicLevel.Mapping
{
    public static class LoginModelExtension
    {
        public static LoginTransportModel Mapping(this LoginModel obj, IHashAlgorithm hashAlgorithm)
        {
            Mapper.Initialize(cfg => cfg.CreateMap<LoginModel, LoginTransportModel>().ForMember(
                arg => arg.Hash, options => options.MapFrom(model => hashAlgorithm.GetHash(model.Login, model.Password))));
            return Mapper.Map<LoginModel, LoginTransportModel>(obj);
        }
    }
}
