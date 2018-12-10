using System;



namespace DailyReport
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine ( "The Tech Academy");
            Console.WriteLine("Student Daily Report");
            Console.WriteLine("1.What course are you on?");
            string course = Console.ReadLine();

            Console.WriteLine("2.What page are you on?");
            int pageNo;
            string input = Console.ReadLine();
            if (Int32.TryParse(input, out pageNo)) ;
            else
            {
                Console.WriteLine("Please only use numerals to answer.");
                Console.WriteLine("2.What page are you on?");

                string input2 = Console.ReadLine();
                if (Int32.TryParse(input, out pageNo)) ;
                else Console.WriteLine("Please only use numerals to answer.");
            }

           

            Console.WriteLine("3.Do you need help with anything? Please answer 'true' or 'False' ");
            bool HelpBool = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("4.Were there any positive experiences youd like to share? Please give specifics");
            string PosEx = Console.ReadLine();

            Console.WriteLine("5.Is there any other feedback youd like to provide? Please be specific");
            string feedback = Console.ReadLine();

            Console.WriteLine("6.How many hours did you study today?");
            int Hours = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Thank you for your answers. An instructor will respond to this shortly. Have a great day!");
            Console.Read();



        }
    }
}

