using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using LogicLevel.ChatServiceReference;
using LogicLevel.Model;

namespace LogicLevel.Mapping
{
    public static class RegistrationModelExtension
    {
        public static RegistrationTransportModel Mapping(this RegistrationModel obj, IHashAlgorithm hashAlgorithm)
        {
            Mapper.Initialize(cfg => cfg.CreateMap<RegistrationModel, RegistrationTransportModel>().ForMember(
                arg => arg.Hash, options => options.MapFrom(model => hashAlgorithm.GetHash(model.Login, model.Password))));
            return Mapper.Map<RegistrationModel, RegistrationTransportModel>(obj);
        }
    }
}
