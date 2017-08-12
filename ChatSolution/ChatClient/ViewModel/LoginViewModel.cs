using ChatClient.View;
using Microsoft.Expression.Interactivity.Core;
using System;
using System.Collections.Generic;
using System.Linq;
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
    internal class LoginViewModel
    {
        private PasswordBox _password;

        public string Login { get; set; }

        public string Password { get { return _password.Password; } }

        public IChatClient ChatClient { set; private get; }

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
                        var result = await ChatClient.Login(this.Mapping<LoginModel>());
                        switch (result.Result)
                        {
                            case LoginResult.Fail:
                                MessageBox.Show("Не верный логин или пароль.");
                                break;
                            case LoginResult.Online:
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
    }
}
