


using System;
using System.Text;

namespace Csharp_whiteboarding

{
    class Program
    {
        static void Main(string[] args)
        {
            //Ans.: The user will input a sentence and we need to reverse the sequence of words in the sentence.

            // input: Welcome to Csharp corner, output: corner Csharp to Welcome

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


            void Reverse(string str)
            {
                int i;
                StringBuilder reverseSentence = new StringBuilder();

                int Start = str.Length - 1;
                int End = str.Length - 1;

                while (Start > 0)
                {
                    if (str[Start] == ' ')
                    {
                        i = Start + 1;
                        while (i <= End)
                        {
                            reverseSentence.Append(str[i]);
                            i++;
                        }
                        reverseSentence.Append(' ');
                        End = Start - 1;
                    }
                    Start--;

                }
                for (i = 0; i <= End; i++)
                {
                    reverseSentence.Append(str[i]);

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
    }
}