using DataLevel.Model;
using DataLevel.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLevel
{
    class UserManager : BaseManager
    {
        public UserModel GetUserCurrent(LoginModel obj)
        {
            return new UserModel().FromEntitiesModel(_chatDb.GetUser(obj.Hash).FirstOrDefault());
        }
    }
}
