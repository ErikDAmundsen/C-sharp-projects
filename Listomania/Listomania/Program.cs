using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listomania
{
    class Program
    {
        static void Main(string[] args)
        {


            //  1.Create a one-dimensional Array of strings.Ask the user to input some text.Create a loop that goes through each string in the Array, adding the user’s text to the string.Then create a loop that prints off each string in the Array on a separate line.

            string[] stArr = new string[] { "Paint your house ", "Buy shoes that are ", "change your name to ", "Change your hair color to " };



            Console.WriteLine("What is your favorite color?");
            string ColorST = Console.ReadLine();

            for (int i = 0; i < stArr.Length; i++)
            {


                stArr[i] = (stArr[i] + ColorST);
                Console.WriteLine(stArr[i]);

            }







            //2.Create an infinite loop.
            bool HaveAJob = false;
            Console.WriteLine("\nDo you have any job experience in this field? True of False");
            while (HaveAJob == false)
            {

                bool hired = bool.Parse(Console.ReadLine());
                if (hired == true)
                {
                    HaveAJob = true;

                }
                else
                {
                    for (int i = 0; i - 1 < i++; i++)
                    {
                        if (Console.KeyAvailable)
                        {
                            break;
                        }


                        Console.WriteLine("Sorry you have all of the qualifications and skills but we only hire people with prior experience.");



                    }
                }
            }

            if (HaveAJob == true)
                Console.WriteLine("Congrautlations, You're hired!\n");




            //3.Fix the infinite loop so it will execute.

            //Hit any key while the console app is looping to stop the loop, type true and press enter to continue past the infinite loop

            //4.Create a loop where the comparison used to determine whether to continue iterating the loop is a “<” operator.
            Console.WriteLine("Happy New Year! press enter to begin 2019");
            Console.ReadLine();
            for (int A = 0; A < 365; A++)
            { Console.WriteLine(A); }

            Console.WriteLine("Happy New Year! its 2020\n");
            //5.Create a loop where the comparison used to determine whether to continue iterating the loop is a “<=” operator.
            int hoursWorked = 0;
            while (hoursWorked < 8)
            {
                Console.WriteLine("\n After working 8 hours you can go home. How many hours have you worked so far today?");
                hoursWorked = int.Parse(Console.ReadLine());

                if (hoursWorked < 8)
                {
                    Console.WriteLine("Ok check back in a few hours...");
                }
            }

            Console.WriteLine("OK you can go home!\n ");

            //6.Create a List of strings where each item in the list is unique.Ask the user to select text to search for in the List.Create a loop that iterates through the list and then displays the index of the array that contains matching text on the screen.

            List<string> flavors = new List<string>() { "chocolate", "vanilla", "moose tracks", "mint chocolate chip", "strawberry", "salted carmel", "reeses", "neopolitan", "fudge", "blackberry", "coffee", "peanut butter", "dulce de leche", "mexican chocolate", "rum raisin", "cardamom", "coffee" };
            Console.WriteLine("Please choose a flavor from the list below then type it in and press enter to find its location");
            flavors.ForEach(Console.WriteLine);

            string inputFlavor = Console.ReadLine();

            bool findFlavor = false;
            int flavorindex = 0;
            foreach (string flavor in flavors)

            {


                if (inputFlavor == flavor)
                {
                    findFlavor = true;
                    Console.WriteLine("\nThe index of your flavor is " + flavorindex + "\n");
                    break; //8..Add code to that above loop that stops it from executing once a match has been found.

                }
                flavorindex++;


                //Begin 7.Add code to that above loop that tells a user if they put in text that isn’t in the List.
                if (flavorindex == flavors.Count & findFlavor == false)
                { Console.WriteLine("Your flavor is not found on the list."); }
            }










            //9.Create a List of strings that has at least two identical strings in the List. Ask the user to select text to search for in the List.Create a loop that iterates through the list and then displays the indices of the array that contain matching text on the screen.
            List<string> people = new List<string>() { "Mike S", "Mike S", "Lindsay ", "Erik", "Jeremy", "Erik", "Aaron ", };

            people.ForEach(Console.WriteLine);

            Console.WriteLine("Please enter one of the names from the list to see its index/indeces");
            var nameEntered = (Console.ReadLine());

            bool exists = false;


            for (int indx = 0; indx < people.Count; indx++)
            {
                if (nameEntered == people[indx])

                {
                    Console.WriteLine(" The index of the name you entered is: " + indx);
                    exists = true;
                }

            }

            //10.Add code to that above loop that tells a user if they put in text that isn’t in the List.
            if (exists == false)
            {
                Console.WriteLine("That name is not on the list");

            }





            //11.Create a List of strings that has at least two identical strings in the List. Create a foreach loop that evaluates each item in the list, and displays a message showing the string and whether or not it has already appeared in the list.

            List<string> months = new List<string>() { "january", "february", "february", "march", "april", "may", "june", "july", "july", "august", "september", "october", "november", "december" };
            Console.WriteLine("\nHere is a list of months, press enter to find out which months are duplicated...");
            foreach (var month in months)
                Console.WriteLine(month);
            Console.ReadLine();

            var original = new List<string>();
            var duplicates = new List<string>();


        foreach(var month in months)
            {
                if (!original.Contains(month))
                    original.Add(month);
                else
                    duplicates.Add(month);
                    
                        }
            Console.WriteLine("\nThe duplicate months in this list are:");
            foreach (var dupmont in duplicates)
                Console.WriteLine(dupmont);
            Console.ReadLine();

        }
    }
}
