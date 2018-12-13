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

            Console.WriteLine("True or False: Have you ever been convicted of a DUI?");
            bool DUI = bool.Parse(Console.ReadLine());

            Console.WriteLine("How many speeding tickets have you had?");
            int tickets = int.Parse(Console.ReadLine());


            Console.ReadLine();





        }
    }
}
