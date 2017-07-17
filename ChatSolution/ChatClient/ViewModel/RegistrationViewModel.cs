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
    class RegistrationViewModel
    {
        public string Login { get; set; }
        public PasswordBox _password1 { get; set; }
        public PasswordBox _password2 { get; set; }
        public string Email { get; set; }
        public ICommand RegistrationCommand
        {
            get
            {
                return new ActionCommand(
                    sender =>
                    {
                        if (string.IsNullOrEmpty(Login) || _password1 == null || _password1.Password.Length == 0 || Email.Length == 0 || _password1 != _password2 )
                        {
                            MessageBox.Show("Не все поля заполнены или пароли не совпадают.");
                            return;
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
