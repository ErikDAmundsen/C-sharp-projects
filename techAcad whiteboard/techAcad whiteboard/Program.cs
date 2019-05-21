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

            //            Given an array of integers, write a method to total the odd numbers.
            Console.WriteLine("1. Given an array of integers, write a method to total the odd numbers.");
  
            int [] IntArr = new int[5] ;
             for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("Please enter a positive whole number and press enter");
                IntArr[i] = Convert.ToInt32(Console.ReadLine());
            }
       
            Console.Write("The numbers you added were ");
                IntArr.ToList().ForEach(Console.Write);

            FindOdd(IntArr);
            void FindOdd(int[] IntArray )
            {
List<int> oddInts = new List<int> { };
                for (int i=0;i<IntArr.Length;i++)
                {
                    
                    if (IntArray[i] % 2 != 0)
                    {

                        oddInts.Add(IntArray[i]);
                    }
}
                    string NoVal = ("\n The array had no odd numbers");
                    if(oddInts == null || oddInts.Count == 0)
                    {
                        Console.WriteLine( NoVal);
                        
                    }
                    int Total = oddInts.Sum();

                    Console.WriteLine ("\nThe total of all the odd numbers from the array is " + Total);
                
            }

            Console.WriteLine("Press enter for next method");
            Console.ReadLine();

            //Given an array of integers, write a method to sum the elements in the array, knowing that some of the elements may be very large integers.
            Console.WriteLine("2. Given an array of integers, write a method to sum the elements in the array, knowing that some of the elements may be very large integers. ");



            //Given a string, reverse it.
            Console.WriteLine("3. Given a string, reverse it");




            //Given a string, remove any repeated letters.
            Console.WriteLine("4. Given a string, reverse it. ");




            //FizzBuzz(Look this one up and try it out)
            Console.WriteLine("5.FizzBuzz ");



        }
    }
}
