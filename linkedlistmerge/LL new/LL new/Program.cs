using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LL_new
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.Add("Test1");
            list.Add("Test2");
            list.Add(1, "Test3");
            //Console.WriteLine("Is it empty?" + list.empty);
            //Console.WriteLine("Count - " + list.Count);
            Console.ReadLine();
        }
    }
}
