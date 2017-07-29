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
        private readonly IChat _chat;

        private readonly Dictionary<int, IChatCallback> _callbacks = new Dictionary<int, IChatCallback>();

        public MessageTransportManager(IChat chat)
        {
            _chat = chat;
        }

        public void UserJoined(LoginSuccessModel obj)
        {
            var callbacks = _callbacks.Values.ToList();
            var currentCallBack = OperationContext.Current.GetCallbackChannel<IChatCallback>();
            _callbacks.Add(obj.UserId, currentCallBack);
            var currentUser = _chat.GetCurrentUser(obj).Mapping<UserPartialTransportModel>();
            callbacks.ForEach(u => u.UserJoined(currentUser));
            currentCallBack.CurrentUser(currentUser);
            currentCallBack.OnlineUsers(_chat.GetOnlineUsers(obj).Mapping());
            currentCallBack.UnreadMessages(_chat.GetUnreadMessages(obj).Mapping());
        }

        public void UserLeaved(UserLeavedTransportModel obj)
        {
            _callbacks.Remove(obj.UserId);
            foreach (var callback in _callbacks.Values) callback.UserLeaved(obj);
        }

        public void SendMessage(MessagePartialTransportModel obj)
        {
            foreach (var callback in _callbacks.Where(pair => pair.Key != obj.UserId).Select(pair => pair.Value))
            {
                callback.MessageReceived(obj);
            }
        }
    }
}
