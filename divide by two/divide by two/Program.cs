using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace divide_by_two
{
    class Program
    {
        static void Main(string[] args)
        {
            divide DV = new divide(); // 2. instantiate class

            

            Console.WriteLine("You are getting a divorce, enter the number of dollars you have in savings to find out how much you get to keep.");

            int Money = int.Parse(Console.ReadLine());//3. Take input divide by 2

             DV.HalfIt( Money, 2);// 1. Integer divided by 2

            Console.WriteLine("How many spouses do you have?");
            int SpouseCount = int.Parse(Console.ReadLine());

            DV.Spouses(out  SpouseCount); //4. with output parameter

            Console.WriteLine("You now have " + SpouseCount + " Spouses.");
            

            Console.WriteLine("How many kids do you have?");
            int KidCount = int.Parse(Console.ReadLine());

           Console.WriteLine( "You now have "+ Kids.KidCount(KidCount,2) +" kids");
            Console.ReadLine();
        }
    }
}



//1. Create a class. In that class, create a void method that outputs an integer.Have the method divide the data passed to it by 2.

//2. In the Main() method, instantiate that class.

//3. Have the user enter a number.Call the method on that number.Display the output to the screen. It should be the entered number, divided by two.

//4. Create a method with output parameters.

//5. Overload a method.

//6. Declare a class to be static