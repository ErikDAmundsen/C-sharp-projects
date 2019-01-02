using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace optional_parameter
{
    class Program
    {
        static void Main(string[] args)
        {
            option O = new option();

            Console.WriteLine("How many months in a year?");
            int months = int.Parse(Console.ReadLine());

            Console.WriteLine("How many days in a month( or put 0 if you dont want to answer)");
            int days = int.Parse(Console.ReadLine());
             if (days > 0)
            {
                Console.WriteLine("In theory there are " + O.Doub(months,days) + " days in a year");
            }
        
            else
            {
                Console.WriteLine("In theory there are " + O.Doub(months ) + " days in a year");
            }
            
            

            Console.ReadLine();


        }
    }
}


//1. Create a class. In that class, create a method that takes two integers as parameters.Make one of them optional.Have the method do a math operation and return a integer result.

//2. In the Main() method of the console app, instantiate the class.

//3. Ask the user to input two numbers, one at a time.Let them know they need not enter anything for the second number.

//4. Call the method in the class, passing in the one or two numbers entered.

//5. Try various combinations of numbers on the code, including having no second number.