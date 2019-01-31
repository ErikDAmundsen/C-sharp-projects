using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blackjack
{
    public class ExceptionEntity
    {
        public int ID { get; set; }
        public string ExceptionType { get; set; }
        public string ExceptionMessage { get; set; }
        public int MyProperty { get; set; }
        public DateTime TimeStamp { get; set; }
    }

}