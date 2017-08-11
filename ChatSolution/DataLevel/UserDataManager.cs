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
        public UserPartialDataModel GetCurrentUser(LoginSuccessDataModel obj)
        {
            Mapper.Initialize(cfg => cfg.CreateMap<UserPartialResult, UserPartialDataModel>());
            return Mapper.Map<UserPartialResult, UserPartialDataModel>(_chatDb.GetUserPartial(obj.UserId).FirstOrDefault());
        }
    }
}
