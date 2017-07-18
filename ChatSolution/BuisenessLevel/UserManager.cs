using DataLevel;
using DataLevel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuisenessLevel.Model;
using BuisenessLevel.Mapping;

namespace BuisenessLevel
{
    public class UserManager
    {
        public UserManager(IChatDb chatDb)
        {
            _chatDb = chatDb;
        }
        private readonly IChatDb _chatDb;
        private List<UserModel> _users;
        public UserModel GetCurrentUser(LoginModel obj)
        {
            var user = _chatDb.GetCurrentUser(obj.Mapping<LoginDataModel>()).Mapping<UserModel>();
            _users.Add(user);
            return user;
        }
    }
}
