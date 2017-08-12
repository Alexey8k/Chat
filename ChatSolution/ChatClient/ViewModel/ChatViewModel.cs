﻿using ChatClient.UserControls;
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
using LogicLevel;
using LogicLevel.Mapping;
using LogicLevel.Model;

namespace ChatClient.ViewModel
{
    class ChatViewModel : INotifyPropertyChanged
    {
        private readonly IChatClient _chatClient;

        private UserPartialModel _currentUser;

        public ChatViewModel()
        {
            _chatClient = new LogicLevel.ChatClient();
            _chatClient.CurrentUserReceived += (sender, args) => _currentUser = args.Mapping<UserPartialModel>();
            _chatClient.OnMessageReceived += (sender, args) => ChatBox += string.Format("({0}) ", DateTime.Now);
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
                    LoginWindow loginWindow = new LoginWindow();
                    ((LoginViewModel)loginWindow.DataContext).ChatClient = _chatClient;
                    if (loginWindow.ShowDialog() != true) return;
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
