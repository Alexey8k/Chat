﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;//для передачи пользовательского типа данных
using System.ServiceModel;
using System.Text;
using System.Threading;
using ChatServise.DataContract;

namespace ChatServise
{
    public class ChatService : IChatService
    {
     //   List<IChatCallback> call = new List<IChatCallback>();
        Dictionary<string, IChatCallback> Call = new Dictionary<string, IChatCallback>();//для запоминания подключенных пользователей (онлайн юзеры)
        public Thread t;//потоки для дуплекса

        
        public LoginObjectOut Login(LoginObjectIn obj)//войти
        {
            //if (Call.Count!=0)
            //{
            //    foreach (var item in Call)
            //    {
            //        ChatCallback ch = new ChatCallback();
            //        ch.Callback = item.Value;//изъяли канал обр вызова IChatCallback из Dictionary
            //        t = new Thread(new ParameterizedThreadStart(ch.UserJoined));
            //        t.IsBackground = true;
            //        t.Start(_Login);
            //    }

            //    //  void SetUsers(UsersobjectIn);//метод который запускается методом Login (при входе пользователя) пользователю который только залогинился придут пользователи которые онлайн
            //    //послать новому пользователю список пользователей онлайн
            //    ChatCallback newch = new ChatCallback();
            //    newch.Callback = OperationContext.Current.GetCallbackChannel<IChatCallback>();                
            //    foreach (var item in Call)
            //    {
            //        t=new Thread(new ParameterizedThreadStart(newch.SetUsers));
            //        t.IsBackground = true;
            //        t.Start(item.Key);
            //    }

            //    //метод который запускается методом Login (при входе пользователя) и показывает пользователю непрочитанные сообщения
            //    t = new Thread(new ParameterizedThreadStart(newch.SetMessage));
            //    t.IsBackground = true;
            //    t.Start(_Login);
            //}

            //Call.Add(_Login, OperationContext.Current.GetCallbackChannel<IChatCallback>());//добавили в базу онлайн пользователей
            //Console.WriteLine(_Login +" вошел в чат");           

            //return BuisenessLevel.Login(_Login);
            return new LoginObjectOut();
        }

        public void Logout(LogoutObjectIn obj)//выйти
        {
            //Call.Remove(_Logout);//исключили из базы онлайн пользователей
            //Console.WriteLine(_Logout + " вышел из чата");

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
        //    Console.WriteLine("Поток остановлен");
        //}

    }
    //---------------------------------переместить в клиент--------------------
        // //////////////////////////////////////////////ДУПЛЕКС//////////////////////////////////////////////////////////////////////
    public class ChatCallback
    {
        public IChatCallback Callback = null;//ссылка на функцию - интерфейсная ссылка (потомучто нельзя создать экземпляр интерфейса) которая будет вызываться при калбеке

        public void UserJoined(UserJoinedObjectIn obj)//разослать всем что юзер присоеденился к чату
        {
            try
            {
                UserJoinedObjectIn us = (UserJoinedObjectIn)obj;
                //Callback.UserJoined(us);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка UserJoined" + ex.Message);
            }
        }

        public void UserLeaved(UserLeavedObjectIn obj)//разослать всем что юзер покинул чат
        {
            try
            {
                UserLeavedObjectIn us = (UserLeavedObjectIn)obj;
                //Callback.UserLeaved(us);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка UserLeaved" + ex.Message);
            }
        }

        public void Message(MessageObjectIn obj)//разослать всем такое то сообщение (у нас общий чат)
        {
            try
            {
                MessageObjectIn us = (MessageObjectIn)obj;
                //Callback.Message(us);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка Message" + ex.Message);
            }
        }

       public void SetUsers(UsersObjectIn obj)//метод который запускается методом Login (при входе пользователя) пользователю который только залогинился придут пользователи которые онлайн
        {
            try
            {
                UsersObjectIn us = (UsersObjectIn)obj;
                //Callback.Message(us);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка SetUsers" + ex.Message);
            }
        }

        public void SetMessage(MessagesObjectIn obj)//метод который запускается методом Login (при входе пользователя) и показывает пользователю непрочитанные сообщения
        {
            try
            {
                MessagesObjectIn us = (MessagesObjectIn)obj;
                //Callback.Message(us);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка SetMessage" + ex.Message);
            }
        }

    }////////////////////////////////////////////////////////////Конец дуплекса/////////////////////////////////////////////////////////////////////
}
