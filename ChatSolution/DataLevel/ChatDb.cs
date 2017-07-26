using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLevel.Model;

namespace DataLevel
{
    public class ChatDb : IChatDb
    {
        public void AddMessage(MessagePartialDataModel obj)
        {
            using (var messageManager = new MessageDataManager())//конструкция using для Dispose
            {
                messageManager.AddMessage(obj);
            }
        }

        public UnreadMessagesResultDataModel GetUnreadMessages(LoginSuccessDataModel obj)
        {
            UnreadMessagesResultDataModel messages;
            using (var messageManager = new MessageDataManager())
            {
                messages = messageManager.GetUnreadMessages(obj);
            }
            return messages;
        }

        public UserPartialDataModel GetCurrentUser(LoginSuccessDataModel obj)
        {
            UserPartialDataModel user;
            using (var userManager = new UserDataManager())
            {
                user = userManager.GetCurrentUser(obj);
            }
            return user;
        }

        public LoginResultDataModel Login(LoginDataModel obj)
        {
            LoginResultDataModel result;
            using (var authorizationManager = new AuthorizationDataManager())
            {
                result = authorizationManager.Login(obj);
            }
            return result;
        }

        public void Logout(LogoutDataModel obj)
        {
            using (var authorizationManager = new AuthorizationDataManager())
            {
                authorizationManager.Logout(obj);
            }
        }

        public RegistrationResultDataModel Registration(RegistrationDataModel obj)
        {
            RegistrationResultDataModel result;
            using (var authorizationManager = new AuthorizationDataManager())
            {
                result = authorizationManager.Registration(obj);
            }
            return result;
        }
    }
}
