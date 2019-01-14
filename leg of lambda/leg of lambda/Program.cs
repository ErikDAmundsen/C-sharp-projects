using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leg_of_lambda
{
    class Program
    {
        static void Main(string[] args)

       
        {
          //1. In the Main() method, create a list of at least 10 employees.Each employee should have a first and last name, as well as an Id.At least two employees should have the first name "Joe".

            Employee employee1 = new Employee
            { FirstName = "Erik",
                LastName = "Amundsen",
                ID = 01
            };



            Employee employee2 = new Employee
            {
                FirstName = "Kristina",
                LastName = "Husby",
                ID =02
           };

            Employee employee3 = new Employee
            {
                FirstName = "Soren",
                LastName = "Amundsen",
                ID =03
           };
            Employee employee4 = new Employee
            {
                FirstName = "Luna",
                LastName = "Amundsen",
                ID =04
           };
            Employee employee5 = new Employee
            {
                FirstName = "Bjorn",
                LastName = "Amundsen",
                ID =05
           };
            Employee employee6 = new Employee
            {
                FirstName = "Byron",
                LastName = "Amundsen",
                ID = 06
           };
            Employee employee7 = new Employee
            {
                FirstName = "Judy",
                LastName = "Amundsen",
                ID = 07
           };
            Employee employee8 = new Employee
            {
                FirstName = "Joe",
                LastName = "Amundsen",
                ID =08
           };
            Employee employee9 = new Employee
            {
                FirstName = "Joe",
                LastName = "Pfantz",
                ID =09
           };
            Employee employee10 = new Employee
            {
                FirstName = "Vanessa",
                LastName = "Bossert",
                ID =010
           };

            List<Employee> RollCall = new List<Employee>()
            {employee1,employee2,employee3,employee4,employee5,employee6,employee7,employee8,employee9,employee10
            
            };

//2. Using a foreach loop, create a new list of all employees with the first name "Joe".
List<Employee> JoeFor = new List<Employee>();

            foreach (Employee employee in RollCall)
            {
                if (employee.FirstName == "Joe")
                {
                    JoeFor.Add(employee);

                }
            }
          



            

            
            
          List<Employee> LambdaJoe =  RollCall.Where(x => x.FirstName == "Joe").ToList();
               

            


            List<Employee> Over5 = RollCall.Where(x => x.ID > 5).ToList();
            foreach (Employee employee in Over5)
            {
                Console.WriteLine(employee.FirstName + "\n" + employee.LastName +"\n" + employee.ID + "\n");
            }


            Console.ReadLine();
        }
    }
}







//3. Do the same thing again, but this time with a lambda expression.

//4. Using a lambda expression, make a list of all employees with an Id number greater than 5


