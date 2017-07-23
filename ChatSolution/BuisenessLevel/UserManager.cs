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
        private List<UserPartialModel> _users = new List<UserPartialModel>();
        public UserPartialModel GetCurrentUser(LoginSuccessModel obj)
        {
            var user = _chatDb.GetCurrentUser(obj.Mapping<LoginSuccessDataModel>()).Mapping<UserPartialModel>();
            _users.Add(user);
            return user;
        }
        public UserPartialModel[] GetOnlineUsers(LoginSuccessModel obj)
        {
            return _users.Where(u => u.Id != obj.UserId).ToArray();
        }
    }
}
