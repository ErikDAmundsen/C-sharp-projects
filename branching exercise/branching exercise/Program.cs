using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace branching_exercise
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine(" Please enter the weight of your package in pounds.");
            int Weight = int.Parse(Console.ReadLine());
            //Check if weight is too much
            if (Weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped vis Package Express. Have a good day.");

                System.Threading.Thread.Sleep(2000);
                Environment.Exit(0);

            }
            else
            {

                Console.WriteLine("Please enter package width in inches.");
            }
            //Get dimensions of package
            int width = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter package heigh in inches.");
            int height = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter package length in inches.");
            int length = int.Parse(Console.ReadLine());

            decimal DimenTotal = height + width + length;
            //check if greater than maximum dimension
            if (DimenTotal > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                System.Threading.Thread.Sleep(2000);
                Environment.Exit(0);

            }
            else
            {
                decimal quote = (DimenTotal * Weight) / 100;
 Console.WriteLine(" Your esitmated total for shipping this package is: $" + Decimal.Parse (quote.ToString("0.00"))); //Makes the decimal have exactly 2 places to represent $

            Console.ReadLine();

            }

           
        




        }
    }
}
