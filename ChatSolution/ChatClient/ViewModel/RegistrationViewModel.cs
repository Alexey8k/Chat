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
        public PasswordBox _password { get; set; }
        public string Email { get; set; }
        public ICommand RegistrationCommand
        {
            get
            {
                return new ActionCommand(
                    sender =>
                    {
                        if (string.IsNullOrEmpty(Login) || _password == null || _password.Password.Length == 0 || Email.Length == 0 )
                        {
                            MessageBox.Show("Не все поля заполнены.");
                            return;
                        }
                    });
            }
        }

       
    }
}
