


using System;

namespace Csharp_whiteboarding

{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Enter a word");
            string entered = Console.ReadLine();
            ChkPal(entered);
            Console.ReadLine();


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

            //reverse a string


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

