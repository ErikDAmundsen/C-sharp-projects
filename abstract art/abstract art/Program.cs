using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_art
{
    class Program
    {
        static void Main(string[] args)
        {

            IQuittable Quitter = new Employee(); //3A. Use polymorphism to create an object of type IQuittable and call the Quit() method on it. Hint: an object can be of an interface type if it implements that specific interface.

            Employee employee1 = new Employee()
            {
                FirstName = "Sample ",
                LastName = "Student"
            };

            //5. Inside the Main() method, instantiate an Employee object with firstName "Sample" and lastName "Student". Call the SayName() method on the object.
            employee1.SayName();
            employee1.Quit();
            Quitter.Quit();
            Console.ReadLine();
        }
    }
}





