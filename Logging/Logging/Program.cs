using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Logging
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");//1. Ask a user for a number.
            string Input = Console.ReadLine();

            File.WriteAllText(@"C:\Users\The Tech Academy\Desktop\Logging.txt", Input);//2. Log that number to a text file.

            string ReadText = File.ReadAllText(@"C:\Users\The Tech Academy\Desktop\Logging.txt");
            Console.WriteLine("The number {0} has been logged", ReadText);//3. Print the text file back to the user.
            Console.ReadLine();


        }
    }
}




