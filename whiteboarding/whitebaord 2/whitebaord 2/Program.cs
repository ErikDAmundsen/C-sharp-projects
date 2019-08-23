using System;
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
            //     char Countcharacter(string str)
            //    {
            //        Dictionary<char, int> characterCount = new Dictionary<char, int>();
            //        foreach (char character in str)
            //        {
            //            if (character != ' ')
            //            {
            //                if (!characterCount.ContainsKey(character))
            //                {
            //                    characterCount.Add(character, 1);
            //                }
            //                else
            //                {
            //                    characterCount[character]++;
            //                }

            //        } }


            //        var T = characterCount.FirstOrDefault(m => m.Value == characterCount.Values.Max()).Key;

            //        return T;


            //    }
            //    string st = "A B CC D";
            //    Console.WriteLine(Countcharacter(st));



            //    Console.WriteLine("\nInput first integer:");
            //    int x = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Input second integer:");
            //    int y = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Check if one is negative and one is positive:");
            //    Console.WriteLine((x < 0 && y > 0) || (x > 0 && y < 0));
            //    Console.WriteLine(SumTriple(2, 2));
            //    Console.WriteLine(SumTriple(12, 10));
            //    Console.WriteLine(SumTriple(-5, 2));
            //}
            //public static int SumTriple(int a, int b)
            //{
            //    return a == b ? (a + b) * 3 : a + b;

            //bool CHECK(int a, int b)
            //{
            //    if(a==20||b==20||(a+b==20))
            //    { return true; }
            //    else
            //    {
            //        return false;
            //    }
            //}

            //string G = "A small cat was socoolit";
            //Console.WriteLine(Longest(G));

            //string Longest(string I)
            //{
            //     int A = 0;
            //        string MAX = string.Empty;
            //    string[] words = I.Split(' ');
            //    foreach (string word in words)
            //    {

            //        if (word.Length > A)
            //        {
            //            A = word.Length;
            //            MAX = word;
            //        }
            //    }
            //    return MAX;
            //}
            //void C()
            //{
            //    for(int i = 1; i<100; i += 2)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //C();
            //Console.Write("Input  a number(integer): ");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int sum = 0;
            //while (n != 0)
            //{
            //    sum += n % 10;
            //    n /= 10;
            //}
            //Console.WriteLine("Sum of the digits of the said integer: " + sum);

            //Console.ReadLine();

            //    Console.WriteLine("\nSum of the first 500 prime numbers: ");
            //    long sum = 0;
            //    int ctr = 0;
            //    int n = 2;
            //    while (ctr < 500)
            //    {
            //        if (isPrime(n))
            //        {
            //            sum += n;
            //            ctr++;
            //        }
            //        n++;
            //    }

            //    Console.WriteLine(sum.ToString());

            //}
            //public static bool isPrime(int n)
            //{
            //    int x = (int)Math.Floor(Math.Sqrt(n));

            //    if (n == 1) return false;
            //    if (n == 2) return true;

            //    for (int i = 2; i <= x; ++i)
            //    {
            //        if (n % i == 0) return false;
            //    }

            //    return true;
            //}

            //Console.Write("Input  a number(integer): ");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int sum = 0;
            //while (n != 0)
            //{
            //    sum += n % 10;
            //    n /= 10;
            //}
            //Console.WriteLine("Sum of the digits of the said integer: " + sum);

            string dup(string inp)
            {
                string final = string.Empty;
                foreach(Char character in inp)
                {
                    final = final + character;
                    final = final + character;

                }
                return final;
            }
            string st = "Eeriikk";
            Console.WriteLine(remoDup(st));
            Console.ReadLine();

            string remoDup(string inp)
            {
                string final = string.Empty;
                foreach(char character in inp)
                {
                    if (final.Contains(character))
                        {
                        continue;
                         }
                    else
                    {
                        final += character;
                    }
                }
                return final;
            }
        }
    }
}
    

