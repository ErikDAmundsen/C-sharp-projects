﻿


using System;
using System.Linq;
using System.Text;

namespace Csharp_whiteboarding

{
    class Program
    {
        static void Main(string[] args)
        {
            //Ans.: The user will input a sentence and we need to reverse the sequence of words in the sentence.

            // input: Welcome to Csharp corner, output: corner Csharp to Welcome
            Console.ReadLine();
            Rev("This is the last word of the sentence");
            Console.ReadLine();


            void Rev(string IN)
            { }


            for (int i = 0; i < 101; i++)
            { if (i % 3 == 0 && i % 5 == 0)
                { Console.WriteLine("FizzBuzz");
                    continue;
                }
                if (i % 3 == 0)
                { Console.WriteLine("Fizz");
                    continue;
                }
                if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                    continue;
                }

                //else { Console.WriteLine(i); }
            }
            Console.ReadLine();


            Console.WriteLine("Enter a word");
            string entered = (Console.ReadLine());
            AllPos(entered);
            Console.ReadLine();

            void AllPos(string Ent)
            {
               
               
               for (int i = 0; i< Ent.Length; i++)
                {
                    StringBuilder Answer = new StringBuilder(Ent.Length - i);
                        for(int a = i; a< Ent.Length;a++)
                    {
                        Answer.Append(Ent[a]);
                        Console.WriteLine(Answer + " ");
                    }
                }
                
                
            }
            Console.ReadLine();


            //all possible configurations of a string



            //if number is palindrome
            bool IsPalindrome(int x)
             {
                if (x <= 0)
                {
                    return false;
                }
                string NUMS = x.ToString();
                
                int end = NUMS.Length - 1;
                for (int i = 0, J = end; i < J; i++, J--)
                {
                    if (NUMS[i] != NUMS[J])
                    {
                        return false;

                    }
                 }
                    return true;
               
           
             }


            // remove a character
            string Pick(int rem)
            { string A = ("ERIKDAMU");
                string Z = A.Remove(rem,1);
                return Z;
            }
            Console.ReadLine();

         
            
            
            // reverse order of words when entered 3


            void Reverse(string IN)
            {
                int i;
                StringBuilder reverseSentence = new StringBuilder();

                int Start = IN.Length - 1;
                int End = IN.Length - 1;

                while (Start > 0)
                {
                    if (IN[Start] == ' ')
                    {
                        i = Start + 1;
                        while (i <= End)
                        {
                            reverseSentence.Append(IN[i]);
                            i++;
                        }
                        reverseSentence.Append(' ');
                        End = Start - 1;
                    }
                    Start--;

                }
                for (i = 0; i <= End; i++)
                {
                    reverseSentence.Append(IN[i]);

                }
                Console.WriteLine(reverseSentence.ToString());


            }

            //check if a word is a palindrome 2
            void ChkPal(string str2)
            {
                bool flag = false;

                for (int i = 0, j = str2.Length - 1; i < str2.Length / 2; i++, j--)
                {
                    if (str2[i] != str2[j])
                    {
                        flag = true;
                        break;
                    }
                }
                if (flag == true)

                { Console.WriteLine(str2 + " is not a palindrome."); }
                else
                {

                    Console.WriteLine(str2 + " is a palindrome");

                }
            }

            //reverse a string 1


            void ReverseString(string str)
            {

                char[] charArray = str.ToCharArray();
                for (int i = 0, j = str.Length - 1; i < j; i++, j--)
                {
                    charArray[i] = str[j];
                    charArray[j] = str[i];
                }
                string reversedstring = new string(charArray);
                Console.WriteLine(reversedstring);


    //Bonus method 1
    //using System;
    //public class Exercise1
    //{
    //    public static void Main()
    //    {
    //        Console.WriteLine("Enter first number");
    //        int A = Convert.ToInt32(Console.ReadLine());

    //        Console.WriteLine("Enter second number");
    //        int B = int.Parse(Console.ReadLine());

    //        Maths(A, B);

    //        void Maths(int IN1, int IN2)
    //        {
    //            Console.WriteLine(IN1 + IN2);
    //            Console.WriteLine(IN1 - IN2);
    //            Console.WriteLine(IN1 * IN2);
    //            Console.WriteLine(IN1 / IN2);


    //        }
    //        Console.ReadLine();
    //    }
    //}

    //Bonus 2
    void Foring(int Num)
    {
        Console.WriteLine("\n" + "{0} {0} {0}", Num);
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("{0}   {0}", Num);
        }
        Console.WriteLine("{0} {0} {0}", Num);
    }
    Console.ReadLine();
        }

        }
  
      void removeduplicate(string str)
    {
        string result = string.Empty;

        for (int i = 0; i < str.Length; i++)
        {
            if (!result.Contains(str[i]))
            {
                result += str[i];
            }
        }

        Console.WriteLine(result);
    }  }
}

