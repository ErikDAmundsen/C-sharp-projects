﻿using System;
using System.Collections;
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
            //string In = "Amundsen";

            //ReverseString(In);
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
            //void ReverseString(string str)
            //{

            //    char[] charArray = str.ToCharArray();
            //    for (int i = 0, j = str.Length - 1; i < j; i++, j--)
            //    {
            //        charArray[i] = str[j];
            //        charArray[j] = str[i];
            //    }
            //    string reversedstring = new string(charArray);
            //    Console.WriteLine(reversedstring);
            //    Console.ReadLine();
            //}


            ////check if string is palindrome
            //string str1 = "Risetovotesir";
            //check(str1);

            //void check(string In1) {
            //    bool Pal = true;
            //    for (int a = 0, b = In1.Length - 1; a <= b; a++, b--)
            //    {

            //        if (In1[a] == In1[b])
            //        {
            //            Pal = true;
            //        }
            //        else { Pal = false; }

            //    }
            //    if (Pal == true)
            //    {
            //        Console.WriteLine("This is a palindrome");
            //    }
            //    else { Console.WriteLine("Not a palindrome"); }
            //    Console.ReadLine();


            //}
            //print a times table


            //   Console.WriteLine("Enter a whole number");
            //   int IN = Int32.Parse(Console.ReadLine());

            //   TimesT(IN);

            //   void TimesT(int INN) { 
            //   for (int i = 1; i <= 10; i++)
            //   {
            //           Console.WriteLine(i * INN);
            //   }
            //}

            //count the number of times a char occurs in a string

            //SortedDictionary<char, int> characterCount = new SortedDictionary<char, int>();
            //foreach (var character in stringToCount)
            //{ if (!characterCount.ContainsKey(character))
            //    {
            //        characterCount.Add(character, 1);
            //    }
            //else
            //    {
            //        characterCount[character]++;
            //    }

            //}

            // // are two string anagrams?

            //bool areAnagram(ArrayList str1,
            //                       ArrayList str2)
            // {
            //     // Get lenghts of both strings 
            //     int n1 = str1.Count;
            //     int n2 = str2.Count;

            //     // If length of both strings is not 
            //     // same, then they cannot be anagram 
            //     if (n1 != n2)
            //     {
            //         return false;
            //     }

            //     // Sort both strings 
            //     str1.Sort();
            //     str2.Sort();

            //     // Compare sorted strings 
            //     for (int i = 0; i < n1; i++)
            //     {
            //         if (str1[i] != str2[i])
            //         {
            //             return false;
            //         }
            //     }

            //     return true;
            // }

            ////divide without using math operatoor

            
            //int Div()
            //{
            //    int a = 40;
            //    int b = 5;
            //    int count = b;
            //    while (b < a)
            //    {
            //        b += b;
            //        count++;


            //    }
            //    return count;
            //}
            //Console.WriteLine(Div());
            //character count
             char Countcharacter(string str)
            {
                Dictionary<char, int> characterCount = new Dictionary<char, int>();
                foreach (char character in str)
                {
                    if (character != ' ')
                    {
                        if (!characterCount.ContainsKey(character))
                        {
                            characterCount.Add(character, 1);
                        }
                        else
                        {
                            characterCount[character]++;
                        }
                        
                } }

                
                var T = characterCount.FirstOrDefault(m => m.Value == characterCount.Values.Max()).Key;

                return T;
               
                
            }
            string st = "A B CC D";
            Console.WriteLine(Countcharacter(st));



            Console.WriteLine("\nInput first integer:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input second integer:");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Check if one is negative and one is positive:");
            Console.WriteLine((x < 0 && y > 0) || (x > 0 && y < 0));


            Console.ReadLine();
        }
        }
    }
