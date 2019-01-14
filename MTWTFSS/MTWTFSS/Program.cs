using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTWTFSS
{
    public enum Days
    { monday = 1, tuesday = 2, wednesday = 3, thursday = 4, friday = 5, saturday = 6, Sunday = 7 };
    class Program
    {
        static void Main(string[] args)
        {
           
                Console.WriteLine("Please enter the current day of the week.");
                string DayInput = (Console.ReadLine()).ToLower();
            int intEnumValue;
 try
            {
                Days day = (Days)Enum.Parse(typeof(Days), DayInput );
                 Console.WriteLine("Today is " + day);
            }
            catch (ArgumentException )
            {
                Console.WriteLine("Please enter an actual day of the week.");
            
            }
           
            Console.ReadLine();
           
    }
}
}



//1. Create an enum for the days of the week.

//2. Prompt the user to enter the current day of the week.

//3. Assign the value to a variable of that enum data type you just created.

//4. Wrap the above statement in a try/catch block and have it print "Please enter an actual day of the week." to the console if an error occurs.

//Note - In the last video, we explained the underlying concepts behinds enums.Nobody knows everything about a programming language and its features, so it's our job as programmers to do research on how to work with various data types, classes and libraries. For this drill, you'll need to do some additional research on how to parse enums.