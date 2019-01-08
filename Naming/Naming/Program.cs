using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naming
{
    class Program
    {
       public static  void Main(string[] args)
        {

            Persons persons = new Persons();
            Employee employee = new Employee();

            Persons persons1 = new Persons();
            persons1.FirstName = "ERik ";
            persons1.LastName = "Amundsen";
            //4. Inside of the Main method, instantiate and initialize an Employee object with a first name of "Sample" and a last name of "Student".

            Employee employee1 = new Employee();
            
                employee1.FirstName = "Sample ";
                employee1.LastName = "Student";

           
            employee1.SayName();//5. Call the superclass method SayName() on the Employee object.


            Console.ReadLine();
        }
    }
}










