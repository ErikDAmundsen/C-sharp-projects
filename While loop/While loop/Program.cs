using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press Enter to initialize countdown!");
            Console.ReadLine();
            int count = 10;
            bool liftoff = false;
            while (liftoff == false)
            {
                Console.WriteLine(count);
                count = count - 1;
                System.Threading.Thread.Sleep(500);
                if (count <= 0)
                {
                    liftoff = true; 
                    


                }
            }
            Console.WriteLine("LIFT OFFFFFF!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
            System.Threading.Thread.Sleep(700);
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            System.Threading.Thread.Sleep(1000);
            //trip begins color change
            Console.WriteLine("If you forgot anything important back on earth now is the time to let us know");
            System.Threading.Thread.Sleep(1000);
            bool forgot = false;
   

            do
            {

                Console.WriteLine("Are you sure you didn't forget anything? Yes or no?");
           
// changing true false to yes no
                string answer = Console.ReadLine();
                if

                    (answer.ToLower().Equals("yes"))
                { forgot = false; }
                else if

                    (answer.ToLower().Equals("no"))
                { forgot = true; }
                else
                {
                    Console.WriteLine("Incorrect input, self destructing now.");
                    System.Threading.Thread.Sleep(1000);
                    Environment.Exit(-1);
                }

            } while (forgot == false );

            Console.WriteLine("OH NO, Back to earth");
            System.Threading.Thread.Sleep(1000);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            Console.WriteLine("Crash Landing succesful!");
            Console.ReadLine();
        }
        }

        



    }

