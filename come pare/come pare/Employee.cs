using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace come_pare
{
   public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public static bool operator ==(Employee emp1, Employee emp2)
        {
            bool status = false;
            
            if (emp1 == emp2)
            {
                status = true;
            }
            return status;
        }

            public static bool operator !=(Employee emp1, Employee emp2)
        {
            bool status = false;
            
            if (emp1 == emp2)
            {
                status = true;
            }
            return status;

        }


    }
}


