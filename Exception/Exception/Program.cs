using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception
{
   public class Program
    {
        static void Main(string[] args)
        {
            try//3. Exceptions must be handled using "try .. catch".
            {
                Console.WriteLine("Please enter your age.");//1. Ask the user for his age.
                int Age = int.Parse(Console.ReadLine());
                if (Age<1)
                { throw new ZeroException(); }
                DateTime YB = DateTime.Now.AddYears(-Age);
                int YBY = YB.Year;

                Console.WriteLine("You were born in the year " + YBY + " or posssibly " + (YBY - 1));
//2. Display the year user born.
                Console.ReadLine();
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a whole number for yor age and no letters.");
                Console.ReadLine();
                return;
            }
            catch( ZeroException)
            {
                Console.WriteLine("LIAR, you are older than that.");//4. Display appropriate error messages if user enters zero or negative numbers.
                Console.ReadLine();
                return;

            }
            catch (System.Exception)//5. Display a general message if exception caused by anything else.
            {
            Console.WriteLine("Something has gone terribly wrong, throw your computer out the nearest window");
                Console.ReadLine();
                return;
            }
        }
    }
}







