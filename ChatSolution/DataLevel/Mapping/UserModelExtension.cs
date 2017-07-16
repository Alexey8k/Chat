using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLevel.Model;
using System.Runtime.CompilerServices;

namespace DataLevel.Mapping
{
    internal static class UserModelExtension
    {
        internal static Model.UserModel FromEntitiesModel(this Model.UserModel obj, UserModel userModel)
        {
            return new Model.UserModel
            {
                Id = userModel.Id,
                Login = userModel.Login,
                Hash = userModel.Hash,
                Email = userModel.Email,
                RegDate = userModel.RegDate,
                LastVisitDate = userModel.LastVisitDate
            };
        }
    }

    
}
