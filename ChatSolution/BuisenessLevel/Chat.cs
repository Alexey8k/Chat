using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuisenessLevel.Model;

namespace BuisenessLevel
{
    public class Chat : IChat
    {
        private readonly UserManager _userManager;

        private readonly AuthorizationManager _authorizationManager;

        private readonly MessageManager _messageManager;

        public Chat(UserManager userManager, AuthorizationManager authorizationManager, MessageManager messageManager)
        {
            _userManager = userManager;
            _authorizationManager = authorizationManager;
            _messageManager = messageManager;
        }

        public UserPartialModel GetCurrentUser(LoginSuccessModel obj)
        {
            return _userManager.GetCurrentUser(obj);
        }

        public OnlineUsersResultModel GetOnlineUsers(LoginSuccessModel obj)
        {
            return _userManager.GetOnlineUsers(obj);
        }

        public UnreadMessagesResultModel GetUnreadMessages(LoginSuccessModel obj)
        {
            return _messageManager.GetUnreadMessages(obj);
        }

        public LoginResultModel Login(LoginModel obj)
        {
            return _userManager.IsOnline(obj) ? 
                new LoginResultModel { Result = LoginResult.Online } : _authorizationManager.Login(obj);
        }

        public void Logout(LogoutModel obj)
        {
            _authorizationManager.Logout(obj);
            _userManager.RemoveUser(obj);
        }

        public void ReceivedMessage(MessagePartialModel obj)
        {
            _messageManager.ReceivedMessage(obj);
        }

        public RegistrationResultModel Registration(RegistrationModel obj)
        {
            return _authorizationManager.Registration(obj);
        }
    }
}
