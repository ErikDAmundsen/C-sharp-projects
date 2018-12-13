using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_and_comparison_operator
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("   ");
            Console.WriteLine("Press Enter to begin");

//Person 1
            Console.ReadLine();
            Console.WriteLine("   ");
            Console.WriteLine("Person 1");
            Console.WriteLine("---------");
            decimal p1hourly = 15.0m;
            Console.WriteLine("Hourly rate: $" + p1hourly);
            decimal p1HoursWorked = 46.0m;
            Console.WriteLine("Hours worked per week: " + p1HoursWorked);
            System.Threading.Thread.Sleep(1200);


 //Person 2

            
            Console.WriteLine("   ");
            Console.WriteLine("Person 2");
            Console.WriteLine("---------");
            decimal p2hourly = 75.75m;
            Console.WriteLine("Hourly rate: $" + p2hourly);
            decimal p2HoursWorked = 33.0m;
            Console.WriteLine("Hours worked per week: " + p2HoursWorked);


            System.Threading.Thread.Sleep(1000);

 //Total income 
            decimal p1Salary = (p1hourly * p1HoursWorked) * 52;
            Console.WriteLine("");
            Console.WriteLine("-Person 1 Annual Salary is:");
            Console.WriteLine("$" + p1Salary);
            System.Threading.Thread.Sleep(1000);

            decimal p2Salary = (p2hourly * p2HoursWorked) * 52;
            Console.WriteLine("-Person 2 Annual Salary is:");
            Console.WriteLine("$" + p2Salary);
            Console.WriteLine("");


 //Comparison
            System.Threading.Thread.Sleep(1200);
            Console.WriteLine ("Does Person 1 make more money than Person 2?");
            bool SalaryCompare = (p1Salary > p2Salary);
            Console.WriteLine(SalaryCompare);
            Console.WriteLine("");

 // Unneccesary Social political commentary
            System.Threading.Thread.Sleep(1200);
            Console.WriteLine("Does Person 1 make a fair and liveable wage?");
            decimal LowIncomeThresholdSeattle = 72000.0m;
            bool livable = (p1Salary > LowIncomeThresholdSeattle );

            Console.WriteLine(SalaryCompare);
            Console.WriteLine("");
            Console.ReadLine();




        }
    }
}
