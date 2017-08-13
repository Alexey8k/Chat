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
using ChatClient.Mapping;
using ChatClient.View;
using LogicLevel;
using LogicLevel.Model;

namespace ChatClient.ViewModel
{
    class RegistrationViewModel : INotifyPropertyChanged
    {
        public string Login { get; set; }

        private PasswordBox _password1;

        private PasswordBox _password2;

        public string Password { get { return _password1.Password; } }

        public string Email { get; set; }

        public IChatClient ChatClient { set; private get; }

        private bool _buttonIsEnabled = true;

        public bool ButtonIsEnabled
        {
            get { return _buttonIsEnabled; }
            private set
            {
                _buttonIsEnabled = value;
                OnPropertyChanged("ButtonIsEnabled");
            }
        }

        public ICommand RegistrationCommand
        {
            get
            {
                return new ActionCommand(
                    sender =>
                    {
                        if (string.IsNullOrEmpty(Login) || _password1 == null || _password1.Password.Length == 0 || Email.Length == 0 || _password1.Password != _password2.Password)
                        {
                            MessageBox.Show("Не все поля заполнены или пароли не совпадают.");
                            return;
                        }
                        ButtonIsEnabled = false;
                        var result = ChatClient.Registration(this.Mapping<RegistrationModel>()).Result;
                        switch (result)
                        {
                            case RegistrationResult.Login:
                                ButtonIsEnabled = true;
                                MessageBox.Show("Данный логин уже занят.");
                                break;
                            case RegistrationResult.Email:
                                ButtonIsEnabled = true;
                                MessageBox.Show("Пользователь с такой почтой уже есть.");
                                break;
                            case RegistrationResult.Ok:
                                ((RegistrationWindow)sender).DialogResult = true;
                                break;
                        }
                    });
            }
        }
        public ICommand Psw1Command
        {
            get
            {
                return new ActionCommand(sender =>
                {
                    _password1 = (PasswordBox)sender;
                });
            }
        }

        public ICommand Psw2Command
        {
            get
            {
                return new ActionCommand(sender =>
                {
                    _password2 = (PasswordBox)sender;
                });
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            if (PropertyChanged == null) return;
            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
