using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Const_antinople
{
    class citizen
    {

        public citizen(string name, int age, string City)
        {
            Console.WriteLine("name/age/City constructor executing" + name + age + City);
        }

        public citizen(string name, int age)
        : this(name, age, " Chicago ")
//3. Chain two constructors together.
        {
            Console.WriteLine("name/age constructor executing"+ name + age);
        }
    }
}
