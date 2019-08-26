using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sorted_merge
{

    


    class Program
    {
        static void Main(string[] args)
        {
            //LinkedList<string> myLL = new LinkedList<string>();

            //myLL.AddLast("erik");
            //myLL.AddLast("kristina");
            //myLL.AddLast("Soren");

            //foreach( string word in myLL)
            //{
            //    Console.WriteLine("good morning " + word);
            //}
            //Console.ReadLine();

            LinkedList<int> nums = new LinkedList<int>();
            nums.AddLast(2);
            nums.AddLast(4);
            nums.AddLast(1);
        
            nums.AddLast(9);

            nums.AddLast(6);

            nums.AddLast(45);

            nums.OrderBy<int,T>();


        }
    }
}
