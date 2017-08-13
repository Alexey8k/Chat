using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicLevel.EventArg;
using LogicLevel.Model;

namespace LogicLevel
{
    public class ChatClient : IChatClient
    {
        private readonly AuthorizationManager _authorizationManager;

        private readonly UserManager _userManager;

        private readonly MessageManager _messageManager;

        public ChatClient(AuthorizationManager authorizationManager, UserManager userManager, MessageManager messageManager)
        {
            _authorizationManager = authorizationManager;
            _userManager = userManager;
            _messageManager = messageManager;
        }
        public event EventHandler<UserJoinedEventArgs> OnUserJoined
        {
            add { _userManager.OnUserJoined += value; }
            remove { _userManager.OnUserJoined -= value; }
        }
        public event EventHandler<UserLeavedEventArgs> OnUserLeave
        {
            add { _userManager.OnUserLeave += value; }
            remove { _userManager.OnUserLeave -= value; }
        }
        public event EventHandler<MessageReceivedEventArgs> OnMessageReceived
        {
            add { _messageManager.OnMessageReceived += value; }
            remove { _messageManager.OnMessageReceived -= value; }
        }
        public event EventHandler<OnlineUsersEventArgs> OnlineUsersReceived
        {
            add { _userManager.OnlineUsersReceived += value; }
            remove { _userManager.OnlineUsersReceived -= value; }
        }
        public event EventHandler<CurrentUserEventArgs> CurrentUserReceived
        {
            add { _userManager.CurrentUserReceived += value; }
            remove { _userManager.CurrentUserReceived -= value; }
        }
        public event EventHandler<UnreadMessagesEventArgs> UnreadMessagesReceived
        {
            add { _messageManager.UnreadMessagesReceived += value; }
            remove { _messageManager.UnreadMessagesReceived -= value; }
        }

        public async Task<LoginResultModel> Login(LoginModel obj)
        {
            return await _authorizationManager.Login(obj);
        }

        public void Logout(LogoutModel obj)
        {
            _authorizationManager.Logout(obj);
        }

        public async Task<RegistrationResultModel> Registration(RegistrationModel obj)
        {
            return await _authorizationManager.Registration(obj);
        }

        public void SendMessage(MessagePartialModel obj)
        {
            _messageManager.SendMessage(obj);
        }
    }
}
