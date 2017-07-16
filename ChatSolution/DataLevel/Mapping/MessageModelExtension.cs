using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLevel.Model;

namespace DataLevel.Mapping
{
    //internal static class MessageModelExtension
    //{
    //    internal static Model.MessageModel FromEntitiesModel(this Model.MessageModel obj, MessageModel messageModel)
    //    {
    //        return new Model.MessageModel
    //        {
    //            Text = messageModel.Text,
    //            UserId = messageModel.UserId,
    //            Date = messageModel.Date
    //        };
    //    }
    //}
    internal static class ModelExtension
    {
        internal static T Mapping<T>(this object obj, MessageModel messageModel)
        {
            
            return (T)(Activator.CreateInstance(typeof(T)));
        }
    }
}
