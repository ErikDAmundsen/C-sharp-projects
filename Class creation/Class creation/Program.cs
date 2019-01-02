using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_creation
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the number of dollars you earn in a month");
             double inputA = double.Parse(Console.ReadLine());

          Console.WriteLine("You earn $" + ClassA.Hourly(inputA, 173) + " an hour.");
            Console.WriteLine(" On average you pay $" + ClassA.Taxes(inputA, 0.14) + " in taxes per month.");
            Console.WriteLine("At that rate you will earn $" + ClassA.Lifetime(inputA, 516) + " in your lifetime.");
            Console.ReadLine();
     }

        // 1.Create a class. In that class, create three methods, each of which will take one integer parameter in and return an integer.The methods should do some math operation on the received parameter.Put this class in a separate.cs file in the application.

        //2. In the Main() program, ask the user what number they want to do the math operations on.

        //3. Call each method in turn, passing the user input to the method.Display the returned integer to the screen.


      





    }
}
