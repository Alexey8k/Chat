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
            User user = new User();
            UserManager userManager = new UserManager();
            BuisnessLevel.Login business = new BuisnessLevel.Login();

            user.callBack = OperationContext.Current.GetCallbackChannel<IChatCallback>();
            user.login = obj.login;
            user.passHesh = obj.passHesh;

            business.CheckLogin(user.login, user.passHesh);



            //      User/UserManager & UserModel/UsersObjectIn дублируют друг друга

            UsersObjectIn usOnline = new UsersObjectIn();//UsersObjectIn() вернет коллекцию пользователей онлайн пользователей



            call.SetUsers(obj);//получить онлайн пользователей
            call.SetMessage(MessagesObjectIn obj);
            Call.Add(obj, call);//добавили в базу онлайн пользователей



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
