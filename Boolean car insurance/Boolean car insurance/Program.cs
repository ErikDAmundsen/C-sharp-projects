using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean_car_insurance
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("-Please answer the following questions.-");
            Console.WriteLine("What is your age in numbers?");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Is it true you have never been convicted of a DUI?");
            bool DUI = bool.Parse(Console.ReadLine());

            Console.WriteLine("How many speeding tickets have you had?");
            int tickets = int.Parse(Console.ReadLine());

            Console.WriteLine("Please wait while we verify your information...");

            System.Threading.Thread.Sleep(1200);

            bool Boolage = (age > 15);
            Console.WriteLine("You are old enough to drive: " + Boolage);

            Console.WriteLine("You have never been convicted of a DUI: " + DUI);

            bool tix = (tickets <= 3);
            Console.WriteLine  (" You have 3 or fewer tickets: " + tix);


            bool qualified = Boolage && DUI && tix;

            Console.WriteLine("Are you qualified for our insurance? " + qualified);

            Console.ReadLine();





        }
    }
}
