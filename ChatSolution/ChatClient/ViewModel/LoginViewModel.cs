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

namespace ChatClient.ViewModel
{
    class LoginViewModel
    {
        public string Login { get; set; }
        private PasswordBox _password;
        //public ChatClient ProxyChat { set; private get; }
        public ICommand LoginCommand
        {
            get
            {
                return new ActionCommand(
                    sender =>
                    {
                        if (string.IsNullOrEmpty(Login) || _password == null || _password.Password.Length == 0)
                        {
                            MessageBox.Show("Не все поля заполнены.");
                            return;
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
                    new RegistrationWindow().ShowDialog();
                });
            }
        }
    }
}
