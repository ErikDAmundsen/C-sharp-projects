using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_art
{
    //3. Create another class called Employee and have it inherit from the Person class.
    class Employee : Person, IQuittable
    {
        //4. Implement the SayName() method inside of the Employee class.
        public new void SayName()
        {
            Console.WriteLine("Name:" + FirstName + LastName);

        }
        //2A. Have your Employee class from the previous drill inherit that interface and implement the Quit() method in any way you choose.
        public void  Quit()
        {
            Console.WriteLine("I Quit");
        }
    }
}








