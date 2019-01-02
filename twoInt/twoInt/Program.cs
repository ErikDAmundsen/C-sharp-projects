using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace twoInt
{
    class Program
    {
        static void Main(string[] args)
        {
             SecondClass SC = new SecondClass();

            Console.WriteLine("Enter your favorite number.");
            int favnum = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your least favorite number.");
            int leastnum = int.Parse(Console.ReadLine());

            SC.Metho(intOne:favnum,intTwo: leastnum);


            Console.ReadLine();
        }
    }

    class SecondClass
    {
        public void Metho(int intOne,int intTwo)
        {
            int otherNum = 5;
           Console.WriteLine("First number:" + (intOne + otherNum));
            Console.WriteLine("Second number:" + intTwo);

        }


    }
}
//1. Create a class. In that class, create a void method that takes two integers as parameters.Have the method do a math operation on the first integer and display the second integer to the screen.

//2. In the Main() method of the console app, instantiate the class.

//3. Call the method in the class, passing in two numbers.

//4. Call the method in the class, specifying the parameters by name.