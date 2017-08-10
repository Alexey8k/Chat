using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLevel.Model
{
    public class MessageDataModel
    {
        public int Id { get; set; }
        public string MessageText { get; set; }
        public DateTime Date { get; set; }
        public int UserId { get; set; }
    }
}
