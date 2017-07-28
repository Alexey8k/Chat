using BuisenessLevel;
using ChatServise.DataContract;
using DataLevel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using BuisenessLevel.Model;
using ChatServise.Mapping;

namespace ChatServise
{
    public class MessageTransportManager
    {
        private IChat _chat;

        private Dictionary<int, IChatCallback> _callback = new Dictionary<int, IChatCallback>();

        public MessageTransportManager(IChat chat)
        {
            _chat = chat;
        }

        public void UserJoined(LoginSuccessModel obj)
        {
            var callbacks = _callback.Values.ToList();
            var currentCallBack = OperationContext.Current.GetCallbackChannel<IChatCallback>();
            _callback.Add(obj.UserId, currentCallBack);
            var currentUser = _chat.GetCurrentUser(obj).Mapping<UserPartialTransportModel>();
            callbacks.ForEach(u => u.UserJoined(currentUser));
            currentCallBack.CurrentUser(currentUser);
            currentCallBack.OnlineUsers(_chat.GetOnlineUsers(obj).Mapping());
            currentCallBack.UnreadMessages(_chat.GetUnreadMessages(obj).Mapping());
        }

        public void UserLeaved(UserLeavedTransportModel obj)
        {
            _callback.Remove(obj.UserId);
            foreach (var callback in _callback.Values) callback.UserLeaved(obj);
        }
    }
}
