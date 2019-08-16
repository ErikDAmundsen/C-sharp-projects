using System;
using System.Threading;

namespace Apptio20second
{
    class Program
    {
        static void Main(string[] args)
        {



            void beep()
            {
               
                for (int i = 20; i>=0; i--)
                {
                    Console.WriteLine(i);
                    Thread.Sleep(1000);
                }
                 Console.Beep(700,500);
            }      

            for (int i = 1; i < 46; i++)
            {
                Console.WriteLine("Question " + i);
                beep();
                Console.Clear();
            }
                Console.WriteLine();
        }
    }
}
