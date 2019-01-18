using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace time_travel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Current time and date is " + DateTime.Now);//1. Prints the current date and time to the console.
            Console.WriteLine("Please enter a whole number");//2. Asks the user for a number.
            int Input = int.Parse(Console.ReadLine());

            DateTime PlusInput = DateTime.Now.AddHours(Input);
            Console.WriteLine("If we were to travel {0} hours into the future the date and time would be {1}", Input, PlusInput);//3. Prints to the console the exact time it will be in X hours, X being the number the user entered in step 2.
            Console.ReadLine();

        }
    }
}





