using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_97
{
    class Program
    {
        static void Main(string[] args)
        {


            string  what = ("What is ");
            string brown= ("brown and sticky? ");
            string stick =("A stick....");
            string allTogetherNow = (what + brown + stick);

            Console.WriteLine(allTogetherNow);
            System.Threading.Thread.Sleep(1000);

            
            Console.WriteLine(allTogetherNow.ToUpper());
            System.Threading.Thread.Sleep(1000);

            StringBuilder XMAS = new StringBuilder ("\nHave yourself a merry little Christmas \nMake the Yuletide gay \nFrom now on your troubles will be miles away\n");
            XMAS.AppendLine("\nHere we are as in olden days \nHappy golden days of yore \nFaithful friends who are dear to us \nGather near to us once more /n");
            XMAS.AppendLine("\nThrough the years we all will be together \nIf the fates allow \nHang a shining star upon the highest place \nSo have yourself a merry little Christmas");
            XMAS.AppendLine("\nHave yourself a merry little Christmas \nMake the Yuletide gay \nFrom now on your troubles will be miles away\n");

            Console.WriteLine(XMAS);
            Console.ReadLine();





        }
    }
}


//Concatenate three strings.

//Convert a string to uppercase.

//Create a Stringbuilder and build a paragraph of text, one sentence at a time.