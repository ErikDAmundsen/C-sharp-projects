using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naming
{
    public class Persons
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }

        //public string PersonBuild(string first, string last)
        //{
            
        //    FirstName = first;
        //     LastName = last ;
        //    return first + last;

        //}


        //public string NAME => $"{FirstName} {LastName}";




        public void SayName()
        {
           Console.WriteLine ("Name:[" + FirstName + LastName + "]"  );

        }
    }
}
