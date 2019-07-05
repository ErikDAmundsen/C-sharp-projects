using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace whitebaord_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string In = "Amundsen";

            ReverseString(In);
            //void Rev(string In)
            //{
            //    Char[] Out = In.ToCharArray();
            //    for(int i =0;i<Out.Length; i++)
            //    {
            //        string Revd = string.Empty;
            //         Revd = Revd + Out[i];

            //    }
            //    Console.WriteLine(Revd);
            


            //Reverse a String
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
                Console.ReadLine();
            }


            //check if string is palindrome
            string str1 = "Risetovotesir";
            check( str1);

           void check(string In1){
           bool Pal = true;
                for (int a = 0,  b = In1.Length - 1; a<=b; a++, b--)
                {
                    
                    if(In1[a]==In1[b])
                    {
                        Pal = true;
                    }
                    else{ Pal = false; }
                   
                }
                if (Pal == true)
                {
                    Console.WriteLine("This is a palindrome");
                }
                else { Console.WriteLine("Not a palindrome"); }
                    Console.ReadLine();


            }

        }
        }
    }

