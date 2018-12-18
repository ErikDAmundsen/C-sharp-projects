using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _100
{
    class Program
    {
        static void Main(string[] args)
        {
            //String array
            Console.WriteLine("Get your fortune told to find out when you will die.....");
            string[] WeekArray = {"You will never die", "Monday","Tuesday","Wednesday", "Thursday","Friday", "Saturday", "Sunday"};

            Console.WriteLine("\nEnter a number 1-7 to see what day of the week");
            try
            {

                var DayInput = Console.ReadLine();
                int Dayint;
                if (int.TryParse(DayInput, out Dayint))
                    Console.WriteLine("\nYou will die on " + WeekArray[Dayint]);
                
           
            }
            catch (IndexOutOfRangeException )
            {
                
                 Console.WriteLine("\nYou didnt enter a valid number so you were assigned Wednesday");
        
            }


            try
            {
                //integer array
                Console.WriteLine("\nEnter a number 1-12 to find out what time you will die...");
                int[] TimeArray = { 0, 12, 11, 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
                int TimeInput = int.Parse(Console.ReadLine());
                Console.WriteLine("\nYou will die at " + TimeArray[TimeInput] + " p.m.");
            }
            catch ( FormatException)
            {
                Console.WriteLine("You didnt enter a valid number so you are assigned Midnight");
                    
                    }
            catch (IndexOutOfRangeException)
            { Console.WriteLine("You didnt enter a valid number so you are assigned Midnight"); }

            //Cause of death
            try
            {
                Console.WriteLine("Enter a number 1-10 to see how you die...");
                List<string> COD = new List<string> { "Nothing, you live forever", "Plane crash", "Aliens attacking", "The Black plague", "premature old age", "A broken heart", "a tiger escaped from the zoo", "spontaneous combustion", "Poison in your coffee", "a rabid squirrel", "boredom" };

                int CODint = int.Parse(Console.ReadLine());

                Console.WriteLine("You die from " + COD[CODint]);
            }
            catch (FormatException)
            { Console.WriteLine("Since you neglected to enter a valid number you will live forever sitting at this computer without interenet access"); }
            catch (ArgumentOutOfRangeException)
            { Console.WriteLine("Since you neglected to enter a valid number you will live forever sitting at this computer without interenet access"); }


            Console.ReadLine();
           





        }
    }
}



//       List<int> intList = new List<int>();
//       intList.Add(4);
//       intList.Add(10);
//       intList.Remove(10);

//       Console.WriteLine(intList[0]);



//       List<string> stringList = new List<string>();
//       stringList.Add("Hello");
//       stringList.Add("World");
//       stringList.Remove("World");

//       Console.WriteLine(stringList[0]);

//Console.ReadLine();




//int[] numArray = new int[5];
//numArray[0] = 5;
//numArray[1] = 2;
//numArray[2] = 10;
//numArray[3] = 20;
//numArray[4] = 5000;



//int[] numArray1 = new int[] { 5, 2, 10, 200, 5000 };
//Console.WriteLine(numArray1[3]);

//int[] numArray2 = { 1, 2, 3, 4, 5, 5, 6, };
//Console.WriteLine(numArray2[5]);

//Console.WriteLine(numArray[3]);

//numArray2[5] = 650;
//Console.ReadLine();