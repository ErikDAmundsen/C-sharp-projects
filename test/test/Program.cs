using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {


            // 1.Takes an input from the user, multiplies it by 50, and prints the result to the console. (Note: make sure your code can take inputs larger than 10, 000, 000).
            Console.WriteLine("Enter a whole number");
            long input1 = long.Parse(Console.ReadLine());

            Console.WriteLine("Your number times 50 equals: " + (input1 * 50));
            

            //2.Takes an input from the user, adds 25 to it, and prints the result to the console.
            Console.WriteLine("Enter another whole number");
            long input2 = long.Parse(Console.ReadLine());
            Console.WriteLine("Your number plus 25 is: " + (input2 + 25));


            //3.Takes an input from the user, divides it by 12.5, and prints the result to the console.
            Console.WriteLine(" Enter any number");
            decimal input3 = decimal.Parse(Console.ReadLine());
            decimal divider = 12.5m;
            Console.WriteLine("Your number divided by 12.5 is: " + (input3 / divider));



            //4.Takes an input from the user, checks if it is greater than 50, and prints the true / false result to the console.
            Console.WriteLine("Enter any whole number");
            int input4 = int.Parse(Console.ReadLine());
            bool compare1 = (input4 > 50);
            Console.WriteLine("Youre number is greate than 50: " + compare1);


            //5.Takes an input from the user, divides it by 7, and prints the remainder to the console(tip: think % operator). 
            Console.WriteLine("Enter any number");
            decimal input5 = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Your number divided by 7 leaves a remainder of " + (input5 % 7));


            Console.Read();
        }
    }


}
