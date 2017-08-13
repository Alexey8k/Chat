using ChatClient.UserControls;
using ChatClient.View;
using Microsoft.Expression.Interactivity.Core;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Threading;
using ChatClient.Mapping;
using LogicLevel;
using LogicLevel.Mapping;
using LogicLevel.Model;

namespace ChatClient.ViewModel
{
    class ChatViewModel : INotifyPropertyChanged
    {
        private readonly Dispatcher _dispatcher = Dispatcher.CurrentDispatcher;

        private readonly IChatClient _chatClient;

        private UserPartialModel _currentUser;

        private AutoResetEvent _currentUserReceived = new AutoResetEvent(false);

        public ChatViewModel()
        {
            var chatTransport = new ChatTransport();

            _chatClient = new LogicLevel.ChatClient(
                new AuthorizationManager(chatTransport, new HashSHA1()),
                new UserManager(chatTransport),
                new MessageManager(chatTransport));

            _chatClient.CurrentUserReceived += (sender, args) =>
            {
                _currentUser = args.Mapping<UserPartialModel>();
                _currentUserReceived.Set();
            };
            _chatClient.OnMessageReceived += (sender, args) => ChatBox += string.Format(
                "({0}) {1}: {2}\r\n", DateTime.Now, OnLineUsers.ToList().Find(u => u.Id == args.UserId), args.MessageText);
            _chatClient.OnlineUsersReceived += (sender, args) =>
            {
                if (args.Users == null) return;
                _dispatcher.Invoke(() =>
                {
                    foreach (var user in args.Users) OnLineUsers.Add(user);
                });
            };
            _chatClient.UnreadMessagesReceived += (sender, args) =>
            {
                if (args.Messages == null) return;
                foreach (var message in args.Messages)
                    ChatBox += string.Format(
                        "({0}) {1}: {2}\r\n", message.Date, OnLineUsers.ToList().Find(u => u.Id == message.UserId), message.MessageText);
            };
            _chatClient.OnUserJoined += (sender, args) 
                => _dispatcher.Invoke(() => OnLineUsers.Add(args.Mapping<UserPartialModel>()));
            _chatClient.OnUserLeave += (sender, args)
                =>
            {
                _dispatcher.Invoke(() => OnLineUsers.Remove(args.Mapping()));
            };
        }
        public int UserId
        {
            get { return _currentUser.Id; }
        }
        public string Login
        {
            get { return _currentUser.Login; }
        }
        private string _messageText;
        public string MessageText
        {
            get { return _messageText; }
            set
            {
                _messageText = value;
                OnPropertyChanged("MessageText");
            }
        }

        private string _chatBox;
        public string ChatBox
        {
            get { return _chatBox; }
            set
            {
                _chatBox = value;
                OnPropertyChanged("ChatBox");
            }
        }

        public ObservableCollection<UserPartialModel> OnLineUsers { get; set; } = new ObservableCollection<UserPartialModel>();

        private UserControl _loginInOut = new LoginControl();
        public UserControl LoginInOut
        {
            get { return _loginInOut; }
            private set
            {
                _loginInOut = value;
                OnPropertyChanged("LoginInOut");
            }
        }
        public ICommand LoginCommand
        {
            get
            {
                return new ActionCommand(sender =>
                {
                    var loginWindow = new LoginWindow();
                    ((LoginViewModel)loginWindow.DataContext).ChatClient = _chatClient;
                    if (loginWindow.ShowDialog() != true) return;
                    _currentUserReceived.WaitOne();
                    LoginInOut = new LogoutControl();
                });
            }
        }
        public ICommand LogoutCommand
        {
            get
            {
                return new ActionCommand(sender =>
                {
                    if (_currentUser == null) return;
                    _chatClient.Logout(this.Mapping<LogoutModel>());
                    _currentUser = null;
                    LoginInOut = new LoginControl();
                    OnLineUsers.Clear();
                });
            }
        }
        public ICommand CabinetCommand
        {
            get
            {
                return new ActionCommand(sender =>
                {
                    
                });
            }
        }
        public ICommand SendMessageCommamd
        {
            get
            {
                return new ActionCommand(sender =>
                {
                    MessageBox.Show(MessageText);
                    MessageText = string.Empty;
                });
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            if(PropertyChanged!=null)
            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
