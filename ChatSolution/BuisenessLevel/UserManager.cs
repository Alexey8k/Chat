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
        private readonly IChatDb _chatDb;

        private List<UserPartialModel> _users = new List<UserPartialModel>();

        public UserManager(IChatDb chatDb)
        {
            _chatDb = chatDb;
        }

        public UserPartialModel GetCurrentUser(LoginSuccessModel obj)
        {
            var currentUser = _users.Find(u => u.Id == obj.UserId);
            if (currentUser == null)
            {
                currentUser = _chatDb.GetCurrentUser(obj.Mapping<LoginSuccessDataModel>()).Mapping<UserPartialModel>();
                _users.Add(currentUser);
            }
            return currentUser;
        }

        public UserPartialModel[] GetOnlineUsers(LoginSuccessModel obj)
        {
            var cashUsers = _users.ToList();
            var indexCurrentUser = cashUsers.FindLastIndex(u => u.Id == obj.UserId);
            return cashUsers.Take(indexCurrentUser).Concat(cashUsers.Skip(indexCurrentUser++)).ToArray();
        }
    }
}
