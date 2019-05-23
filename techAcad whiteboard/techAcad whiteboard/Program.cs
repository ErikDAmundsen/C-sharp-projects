using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace techAcad_whiteboard
{
    class Program
    {
        static void Main(string[] args)
        {

            //            //            Given an array of integers, write a method to total the odd numbers.
            Console.WriteLine("1. Given an array of integers, write a method to total the odd numbers.");

            int[] IntArr = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Please enter a positive whole number and press enter");
                IntArr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("The numbers you added were ");
            IntArr.ToList().ForEach(Console.Write);

            FindOdd(IntArr);
            void FindOdd(int[] IntArray)
            {
                List<int> oddInts = new List<int> { };
                for (int i = 0; i < IntArr.Length; i++)
                {

                    if (IntArray[i] % 2 != 0)
                    {

                        oddInts.Add(IntArray[i]);
                    }
                }
                string NoVal = ("\n The array had no odd numbers");
                if (oddInts == null || oddInts.Count == 0)
                {
                    Console.WriteLine(NoVal);

                }
                int Total = oddInts.Sum();

                Console.WriteLine("\nThe total of all the odd numbers from the array is " + Total);

            }

            Console.WriteLine("Press enter for next method");
            Console.ReadLine();
            Console.Clear();

            //Given an array of integers, write a method to sum the elements in the array, knowing that some of the elements may be very large integers.
            Console.WriteLine("2. Given an array of integers, write a method to sum the elements in the array, knowing that some of the elements may be very large integers. ");
            int[] EntInt = new int[5];
            NumEnt();


            void NumEnt()
            {
                for (int i = 0; i < 5; i++)
                {

                    Console.WriteLine("Please enter a positive whole number");
                    EntInt[i] = Int32.Parse(Console.ReadLine());

                }
            }
            long[] longs = EntInt.Select(items => (long)items).ToArray();
            SumAr(longs);
            void SumAr(long[] longz)
            {
                long TOTAL = longz.Sum();
                Console.WriteLine("The sum of the numbers you entered is " + TOTAL);


            }
            Console.WriteLine("Press enter for next method");
            Console.ReadLine();
            Console.Clear();


            //Given a string, reverse it.
            Console.WriteLine("3. Given a string, reverse it");
            Console.WriteLine("Please enter a word");
            string INTAKE = Console.ReadLine();

            Reverse(INTAKE);

            void Reverse(string INTAKEE)
            {
                var LETS = INTAKEE.ToCharArray();
                StringBuilder REVED = new StringBuilder();
                for (int i = LETS.Length - 1; i >= 0; i--)
                {
                    REVED.Append(LETS[i]);
                }
                Console.WriteLine("The reverse of what you entered is " + REVED);
            }
            Console.WriteLine("Press enter for next method");
            Console.ReadLine();
            Console.Clear();


            //Given a string, remove any repeated letters.
            Console.WriteLine("4. Given a string, remove any repeated letters. ");
            Console.WriteLine("Please enter a word");
            string INPUT = Console.ReadLine();

            check(INPUT);
            void check(string INPUTs)
                {
               List<char> INPARR = INPUTs.ToList();
                List<char> SING = new List<char>();

                for ( int i =0;i< INPUTs.Length; i++)
                {
                    if (SING.Contains(INPARR[i]))
                        { continue; }
                    SING.Add(INPARR[i]);
                }
                    StringBuilder RES = new StringBuilder();
                foreach (char character in SING) { RES.Append(character); }
            
                Console.WriteLine(" Your input with duplicates removed is " +RES);

            }
            Console.WriteLine("Press enter for next method");
            Console.ReadLine();
            Console.Clear();



            //FizzBuzz(Look this one up and try it out)
            //"Write a program that prints the numbers from 1 to 100. But for multiples of three print “Fizz” instead of the number and for the multiples of five print “Buzz”. For numbers which are multiples of both three and five print “FizzBuzz”."
            Console.WriteLine("5.FizzBuzz ");
            FB();
            Console.ReadLine();
            void FB()
            {
                for(int a=0;a<101;a++)
                { if ( (a % 3) == 0)
                    { Console.WriteLine("Fizz");
                        continue;
                    }
                    if ((a % 5) == 0)
                    {
                        Console.WriteLine("Buzz");
                        continue;
                    }
                    Console.WriteLine(a);
                }
            }


        }
    }
}
