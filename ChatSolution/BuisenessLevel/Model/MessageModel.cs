using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisenessLevel.Model
{
    public class MessageModel
    {
        public int Id { get; set; }
        public string MessageText { get; set; }
        public DateTime Date { get; set; }
        public string Login { get; set; }
    }
}
