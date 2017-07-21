using DataLevel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace DataLevel
{
    class UserDataManager : BaseDataManager // менеджер юзеров
    {
        public UserDataModel GetCurrentUser(LoginSuccessDataModel obj)
        {
            Mapper.Initialize(cfg => cfg.CreateMap<UserResult, UserDataModel>());
            return Mapper.Map<UserResult, UserDataModel>(_chatDb.GetUser(obj.UserId).FirstOrDefault());
        }
    }
}
