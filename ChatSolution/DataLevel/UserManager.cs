using DataLevel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace DataLevel
{
    class UserManager : BaseManager
    {
        public UserDataModel GetUserCurrent(LoginDataModel obj)
        {
            Mapper.Initialize(cfg => cfg.CreateMap<GetUser_Result, UserDataModel>());
            return Mapper.Map<GetUser_Result, UserDataModel>(_chatDb.GetUser(obj.Hash).FirstOrDefault());
        }
    }
}
