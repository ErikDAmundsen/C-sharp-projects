using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @struct
{
    class Program
    {
        public struct Number
        {
          public decimal Amount//1. Create a struct called Number and give it the property "Amount" and have it be of data type decimal.
            {get;set;
                
            } 
           
                }

        static void Main(string[] args)
        {

            Number amo = new Number();//2. In the Main() method, create an object of data type Number and assign an amount to it.

            amo.Amount = 35.35m;

            Console.WriteLine("It took me " +amo.Amount +" tries to remember to put the m after the decimal"); //3. Print this amount to the console.
            Console.ReadLine();
        }
    }
}






