using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace come_pare
{
   public class Program
    {
       public static void Main(string[] args)
        {
            //Overload the "==" operator so it checks if two Employee objects are equal by comparing their Id property.
              Employee employee1 = new Employee()
            {
                ID = 1111,
                Name = "Erik Amundsen "
            };

            Employee employee2 = new Employee()
            {
                ID = 1111,
                Name = "Eric Amundsen "

            };


            Employee employee3 = new Employee()
            {
                ID = 3333,
                Name = "Bob Smith "
            };

            Console.WriteLine(employee1.Name + "\n" + employee2.Name  + "\n Press enter to find out if these are the same employee or not...");
                Console.ReadLine();



            if
            (employee1 == employee2)
            { Console.WriteLine("These are the same employees based on their ID number\n" + employee1.Name + employee1.ID + "\n" + employee2.Name + employee2.ID); }
            else
            { Console.WriteLine("These are not the same employees based on their ID number"); }
            Console.ReadLine();
        }
    }
}





