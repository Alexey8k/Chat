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
        public UserModel GetUserCurrent(LoginModel obj)
        {
            Mapper.Initialize(cfg => cfg.CreateMap<GetUser_Result, UserModel>());
            return Mapper.Map<GetUser_Result, UserModel>(_chatDb.GetUser(obj.Hash).FirstOrDefault());
        }
    }
}
