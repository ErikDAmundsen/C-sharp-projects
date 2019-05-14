


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
            string entered = Console.ReadLine();
            Reverse(entered);
            Console.ReadLine();


            // reverse order of words when entered 3


            void Reverse(string str)
            {
                int i;
                StringBuilder reverseSentence = new StringBuilder();

                int Start = str.Length - 1;
                int End = str.Length - 1;

                while (Start >0)
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
                for (i = 0; i<=End; i++)
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
                
            }
        }
    }
}

