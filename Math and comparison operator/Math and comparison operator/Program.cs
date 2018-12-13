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

            Console.WriteLine("What is the hourly rate of person 1");
            decimal p1hourly = decimal.Parse(Console.ReadLine());
            Console.WriteLine("How many hours a week does person 1 work?");
            decimal p1HoursWorked = decimal.Parse(Console.ReadLine());


            Console.WriteLine("What is the hourly rate of person 2");
            decimal p2hourly = decimal.Parse(Console.ReadLine());
            Console.WriteLine("How many hours a week does person 2 work?");
            decimal p2HoursWorked = decimal.Parse(Console.ReadLine());

            //Person 1

            Console.WriteLine("   ");
            Console.WriteLine("Person 1");
            Console.WriteLine("---------");
            Console.WriteLine("Hourly rate: $" + p1hourly);
       
            Console.WriteLine("Hours worked per week: " + p1HoursWorked);
            System.Threading.Thread.Sleep(1200);


 //Person 2

            
            Console.WriteLine("   ");
            Console.WriteLine("Person 2");
            Console.WriteLine("---------");
        
            Console.WriteLine("Hourly rate: $" + p2hourly);
            
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

 
          
            Console.ReadLine();




        }
    }
}
