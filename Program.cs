using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
         

                Console.WriteLine("Enter a word");
                string entered = Console.ReadLine();
                ReverseString(entered);
            Console.ReadLine();

                void ReverseString(string str)
                {

                    char[] charArray = str.ToCharArray();
                    for (int i = 0, j = str.Length - 1; i < j; i++, j--)
                    {
                        charArray[i] = str[j];
                        charArray[j] = str[i];
                        string reversedstring = new string(charArray);
                        Console.WriteLine(reversedstring);
                    }
                }
            }
        }
    }

