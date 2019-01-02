using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_creation
{
     class ClassA
    {
        public static double Hourly(double num1, double num2)
        {

            return num1 / num2;




        }

        public static double Taxes(double num1, double num2)
        {
            return num1 * num2;

        }

        public static double Lifetime(double num1, double num2)
        {
            return num1 * num2;

        }

    }
}
// 1.Create a class. In that class, create three methods, each of which will take one integer parameter in and return an integer.The methods should do some math operation on the received parameter.Put this class in a separate.cs file in the application.

//2. In the Main() program, ask the user what number they want to do the math operations on.

//3. Call each method in turn, passing the user input to the method.Display the returned integer to the screen.
