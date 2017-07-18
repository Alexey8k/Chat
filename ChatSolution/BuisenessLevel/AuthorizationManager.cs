using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using BuisenessLevel.Model;


namespace BuisnessLevel
{
    public class AuthorizationManager//реализация логики службы для входа (Login)
    {
        public LoginResultModel Login(LoginModel obj)//для прповерки логина и пароля (вернуть результат проверки логина и пароля и вернуть out int id)
        {
            return new LoginResultModel();
        }

    }
}
