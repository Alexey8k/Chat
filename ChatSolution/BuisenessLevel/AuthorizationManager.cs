using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using BuisenessLevel.Model;
using DataLevel;


namespace BuisnessLevel
{
    public class AuthorizationManager//реализация логики службы для входа (Login)
    {
        private readonly IChatDb _chatDb = new ChatDb();
        public LoginResultModel Login(LoginModel obj)//для прповерки логина и пароля (вернуть результат проверки логина и пароля и вернуть out int id)
        {
            return new LoginResultModel();
        }

    }
}
