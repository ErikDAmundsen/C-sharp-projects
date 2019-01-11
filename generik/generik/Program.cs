using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generik
{
    class Program
    {
        static void Main(string[] args)
        {
            //3. Instantiate an Employee object with type "string" as its generic parameter.Assign a list of strings as the property value of Things.
            Employee<string> employeestring = new Employee<string>()
            {
                Things = new List<string>()
            {
            "Monday", "Tuesday", "Wednesday", "Thursday", "Friday"

            }
            };


            //4. Instantiate an Employee object with type "int" as its generic parameter.Assign a list of integers as the property value of Things.
            Employee<int> employeeint = new Employee<int>()
            {
                Things = new List<int>()
            { 1,2,3,4,5,6,7 }
            };




            //5. Create a loop that prints all of the Things to the Console.
            foreach (string day in employeestring.Things)
            {
                Console.WriteLine(day);
            }


            foreach (int numb in employeeint.Things)
            {
                Console.WriteLine(numb);

            }
            Console.ReadLine();







        }
    }
}











