using ChatClient.UserControls;
using ChatClient.View;
using Microsoft.Expression.Interactivity.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace ChatClient.ViewModel
{
    class ChatViewModel : INotifyPropertyChanged
    {
        private string _login;
        public string Login
        {
            get { return _login; }
            set
            {
                _login = value;
                OnPropertyChanged("Login");
            }
        }
        private string _textMessage;
        public string TextMessage
        {
            get { return _textMessage; }
            set
            {
                _textMessage = value;
                OnPropertyChanged("TextMessage");
            }
        }
        private UserControl _logInOut = new LoginControl();
        public UserControl LogInOut
        {
            get { return _logInOut; }
            private set
            {
                _logInOut = value;
                OnPropertyChanged("LogInOut");
            }
        }
        public ICommand LoginCommand
        {
            get
            {
                return new ActionCommand(sender =>
                {
                    LoginWindow loginWindow = new LoginWindow();
                    //((LoginViewModel)loginWindow.DataContext).ProxyChat = _proxyChat;
                    if (loginWindow.ShowDialog() != true) return;
                    LogInOut = new LogoutControl();
                });
            }
        }
        public ICommand LogoutCommand
        {
            get
            {
                return new ActionCommand(sender =>
                {
                    if (_login == null) return;
                    //_proxyChat.Logout(_user);
                    //_proxyChat.Abort();
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
                    MessageBox.Show(TextMessage);
                    TextMessage = string.Empty;
                });
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
