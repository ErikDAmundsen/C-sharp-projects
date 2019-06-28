using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_order_of_sentence
{
    class Program
    {
        static void Main(string[] args)
        {
            //The correct version of what I was trying to create in the interview.
            Console.WriteLine("Please type a sentence and press enter.");
            string Input = Console.ReadLine();

            Reverse(Input);

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

            //The simplified version as you recommended it

            Console.WriteLine("Enter another sentence and press enter");
            string Input2 = Console.ReadLine();
            Rev(Input2);


            void Rev(string In2)
            {
                string[] word = In2.Split(' ');
                StringBuilder final = new StringBuilder();

                for (int i = word.Length - 1; i >= 0; i--)
                {
                    final.Append(word[i]);
                    final.Append(' ');
                }
                Console.WriteLine(final);
            }
            Console.ReadLine();
        }
    }
}
