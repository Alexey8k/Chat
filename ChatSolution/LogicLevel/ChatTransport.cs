using System;
using System.Collections.Generic;
using System.Linq;
//using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using TransportLevel.ChatServiceReference;
using TransportLevel.EventArg;

namespace LogicLevel
{
    //public class ChatTransport : IChatTransport
    //{
    //    private readonly CallbackChatService _callbackChatService;

    //    private readonly ChatServiceClient _proxyChat;

    //    public ChatTransport()
    //    {
    //        _callbackChatService = new CallbackChatService();
    //        _proxyChat = new ChatServiceClient(new InstanceContext(_callbackChatService));
    //    }

    //    public event EventHandler<UserJoinedEventArgs> UserJoined
    //    {
    //        add { _callbackChatService.EventUserJoined += value; }
    //        remove { _callbackChatService.EventUserJoined -= value; }
    //    }

    //    public event EventHandler<UserLeavedEventArgs> UserLeaved
    //    {
    //        add { _callbackChatService.EventUserLeaved += value; }
    //        remove { _callbackChatService.EventUserLeaved -= value; }
    //    }

    //    public event EventHandler<MessageReceivedEventArgs> MessageReceived
    //    {
    //        add { _callbackChatService.EventMessageReceived += value; }
    //        remove { _callbackChatService.EventMessageReceived -= value; }
    //    }

    //    public event EventHandler<OnlineUsersEventArgs> OnlineUsersReceived
    //    {
    //        add { _callbackChatService.OnlineUsersReceived += value; }
    //        remove { _callbackChatService.OnlineUsersReceived -= value; }
    //    }

    //    public event EventHandler<CurrentUserEventArgs> CurrentUserReceived
    //    {
    //        add { _callbackChatService.CurrentUserReceived += value; }
    //        remove { _callbackChatService.CurrentUserReceived -= value; }
    //    }

    //    public event EventHandler<UnreadMessagesEventArgs> UnreadMessagesReceived
    //    {
    //        add { _callbackChatService.UnreadMessagesReceived += value; }
    //        remove { _callbackChatService.UnreadMessagesReceived -= value; }
    //    }

    //    public LoginResultTransportModel Login(LoginTransportModel obj)
    //    {
    //        return _proxyChat.Login(obj);
    //    }

    //    public void Logout(LogoutTransportModel obj)
    //    {
    //        _proxyChat.Logout(obj);
    //    }

    //    public RegistrationResultTransportModel Registration(RegistrationTransportModel obj)
    //    {
    //        return _proxyChat.Registration(obj);
    //    }

    //    public void SendMessage(MessagePartialTransportModel obj)
    //    {
    //        _proxyChat.SendMessage(obj);
    //    }
    //}
}
