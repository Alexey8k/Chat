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
using ChatClient.Mapping;
using LogicLevel;
using LogicLevel.Model;

namespace ChatClient.ViewModel
{
    internal class LoginViewModel : INotifyPropertyChanged
    {
        private PasswordBox _password;

        public string Login { get; set; }

        public string Password { get { return _password.Password; } }

        public IChatClient ChatClient { set; private get; }

        private bool _buttonIsEnabled = true;

        public bool ButtonIsEnabled
        {
            get { return _buttonIsEnabled; }
            private set
            {
                _buttonIsEnabled = value;
                OnPropertyChanged();
            }
        }

        public ICommand LoginCommand
        {
            get
            {
                return new ActionCommand(
                    async sender =>
                    {
                        if (string.IsNullOrEmpty(Login) || _password == null || _password.Password.Length == 0)
                        {
                            MessageBox.Show("Не все поля заполнены.");
                            return;
                        }
                        ButtonIsEnabled = false;
                        var result = await ChatClient.Login(this.Mapping<LoginModel>());
                        switch (result.Result)
                        {
                            case LoginResult.Fail:
                                ButtonIsEnabled = true;
                                MessageBox.Show("Не верный логин или пароль.");
                                break;
                            case LoginResult.Online:
                                ButtonIsEnabled = true;
                                MessageBox.Show("Пользователь онлайн.");
                                break;
                            case LoginResult.Ok:
                                ((LoginWindow)sender).DialogResult = true;
                                break;
                        }
                    });
            }
        }
        public ICommand PswCommand
        {
            get
            {
                return new ActionCommand(sender =>
                {
                    _password = (PasswordBox)sender;
                });
            }
        }

        public ICommand RegistrationCommand
        {
            get
            {
                return new ActionCommand(sender =>
                {
                    RegistrationWindow registrationWindow = new RegistrationWindow();
                    ((RegistrationViewModel)registrationWindow.DataContext).ChatClient = ChatClient;
                    registrationWindow.ShowDialog();
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
