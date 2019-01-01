using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace More_exception_handling
{
    class Program
    {
        static void Main(string[] args)
        {



            // 1.Create a list of integers. Ask the user for a number to divide each number in the list by.Write a loop that takes each integer in the list, divides it by the number the user entered, and displays the result to the screen.

            try
            {
                List<int> numbs = new List<int>() { 2019, 100, 365, 31, 7, 24, 60 };

                Console.WriteLine("Enter a whole number.");
                int input1 = int.Parse(Console.ReadLine());

                for (int i = 0; i < numbs.Count; i++) ;

                foreach (int number in numbs)
                {
                    Console.WriteLine(number / input1);
                }
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Do not divide by zero");
                    }
            catch( FormatException exfor)
            {
                Console.WriteLine(exfor.Message);
            }
            catch(Exception exAll)
            {
                Console.WriteLine(exAll.Message);

            }
            finally
            {

                Console.WriteLine("Try catch finished.");
            }


            Console.ReadLine();

           //2.Run that code, entering in non - zero numbers as the user.Look at the displayed results.
           

           //3.Run that code, entering in zero as the number to divide by.Note any error messages you get.
           

           //4.Run that code, entering in a string as the number to divide by.Note any error messages you get.
           

           //5.Now put the loop in a try/catch block.Below and outside of the try/catch block, make the program display a message to the display to let you know the program has emerged from the try/catch block and continued on with program execution.In the catch block, display the error message to the screen.Then try various combinations of user input: valid numbers, zero and a string.Ensure the proper error messages display on the screen, and that the code after the try/catch block gets executed.
      





        }
    }
}
