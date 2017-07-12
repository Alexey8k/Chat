using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;//для передачи пользовательского типа данных
using System.ServiceModel;
using System.Text;
using System.Threading;
using BuisnessLevel;
using ChatServise.DataContract;


namespace ChatServise
{
    public class ChatService : IChatService
    {


        public LoginModelResponce Login(LoginModelRequest obj)//войти (принимает obj от LogicLevel, возвращает Login)
        {
            DataContract.User user = new DataContract.User();
            UserManager userManager = new UserManager();
            BuisnessLevel.Login business = new BuisnessLevel.Login();
            int id;

            user.callBack = OperationContext.Current.GetCallbackChannel<IChatCallback>();
            user.login = obj.login;

            business.CheckLogin(obj.login, obj.passHesh,out id);//должен вернуть результат проверки логина/пароля из БД

            //      User/UserManager & UserModel/UsersObjectIn дублируют друг друга
            //UsersObjectIn usOnline = new UsersObjectIn();//UsersObjectIn() вернет коллекцию пользователей онлайн пользователей

            //СДЕЛАТЬ ФУНКЦИИ КАЛБЕКАМИ!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

            userManager.SetUsers();//вернем список онлайн юзеров

            userManager.SetMessage();//вернем список непрочитанных сообщений

            userManager.Users.Add(id,user);//добавили в базу онлайн пользователей

            //Через CallBack надо всем отправить что Юзер онлайн

            return new LoginModelResponce();
        }

        public void Logout(LogoutObjectIn obj)//выйти
        {
            //Call.Remove(_Logout);//исключили из базы онлайн пользователей

            //if (Call.Count != 0)
            //{
            //    foreach (var item in Call)
            //    {
            //        ChatCallback ch = new ChatCallback();
            //        ch.Callback = item.Value;//изъяли канал обр вызова IChatCallback из Dictionary
            //        t = new Thread(new ParameterizedThreadStart(ch.UserLeaved));
            //        t.IsBackground = true;
            //        t.Start(_Logout);
            //    }
            //}
            //return BuisenessLevel.Logout(_Logout);
        }

        public void SendMessage(MessageObjectIn obj)//отправить сообщение
        {
            //foreach (var item in Call)
            //{
            //    if (item.Value ==OperationContext.Current.GetCallbackChannel<IChatCallback>())//если пользователь сам отправил сообщение - пропускаем
            //        continue;

            //    ChatCallback ch = new ChatCallback();
            //    ch.Callback = item.Value;//изъяли канал обр вызова IChatCallback из Dictionary
            //    t = new Thread(new ParameterizedThreadStart(ch.Message));
            //    t.IsBackground = true;
            //    t.Start(_Message);
            //}

            //return BuisenessLevel.SendMessage(_SendMessage);
        }

        public RegistrationObjectOut Registration(RegistrationObjectIn obj)//регистрация
        {

            //return BuisenessLevel.Registration(_Registration);//просто для добавленгие в БД
            return new RegistrationObjectOut();
        }

        //public void StopStream()//для остановки потока
        //{
        //    t.Abort();
        //}

    }
}
