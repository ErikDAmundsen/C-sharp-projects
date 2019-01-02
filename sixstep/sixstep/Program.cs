using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sixstep
{
    class Program
    {
         static void Main(string[] args)
        {
            Classy CL = new Classy();

            //whole number
            Console.WriteLine("Type the number that equals one dozen as a whole number.");
            int dozen = int.Parse(Console.ReadLine());

            
            Console.WriteLine(CL.Answer(dozen));

            //decimal
            Console.WriteLine("Type the number that equals one dozen as a decimal.");
            decimal dozen2 = decimal.Parse(Console.ReadLine());


            Console.WriteLine(CL.Answer(dozen2));

            //string
         
            Console.WriteLine("Type the number that equals one dozen as a decimal.");
            string dozen3 = (Console.ReadLine());


            Console.WriteLine(CL.Answer(dozen3));
            Console.ReadLine();

        }
    }


}


//1. Create a class. In that class, create a method that will take in an integer, do a math operation to it and then return the answer as an integer.

//2. In the Main() method of the console app, instantiate the class and call the one method, passing in an integer, such as 12. Then display the result to the screen.

//3. Add a second method to the class, with the same name, that will take in a decimal, do a different math operation to it and then return the answer as an integer.

//4. In the Main() method of the console app, instantiate the class and call the second method, passing in a decimal. Display the result to the screen.

//5. Add a third method to the class, with the same name, that will take in a string, convert it to an integer if possible, do a different math operation to it and then return the answer as an integer.

//6. In the Main() method of the console app, instantiate the class and call the third method, passing in a string that equates to an integer.Display the result to the screen.