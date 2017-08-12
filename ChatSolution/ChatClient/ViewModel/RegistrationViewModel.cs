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
using ChatClient.View;
using LogicLevel;
using LogicLevel.Model;

namespace ChatClient.ViewModel
{
    class RegistrationViewModel
    {
        public string Login { get; set; }

        private PasswordBox _password1;

        private PasswordBox _password2;

        public string Passwopd { get { return _password1.Password; } }

        public string Email { get; set; }

        public IChatClient ChatClient { set; private get; }

        public ICommand RegistrationCommand
        {
            get
            {
                return new ActionCommand(
                    sender =>
                    {
                        if (string.IsNullOrEmpty(Login) || _password1 == null || _password1.Password.Length == 0 || Email.Length == 0 || _password1.Password != _password2.Password )
                        {
                            MessageBox.Show("Не все поля заполнены или пароли не совпадают.");
                            return;
                        }
                        var result = ChatClient.Registration(this.Mapping<RegistrationModel>()).Result;
                        switch (result)
                        {
                            case RegistrationResult.Login:
                                MessageBox.Show("Данный логин уже занят.");
                                break;
                            case RegistrationResult.Email:
                                MessageBox.Show("Пользователь с такой почтой уже есть.");
                                break;
                            default:
                                ((RegistrationWindow) sender).DialogResult = true;
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

    }
}
