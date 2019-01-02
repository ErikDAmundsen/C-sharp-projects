using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sixstep
{
    public class Classy
    {

        public int Answer(int dozen)
        {
            return  dozen * dozen;
        }


        public decimal Answer(decimal dozen2)
        {
            return dozen2 + dozen2;

        }

        public string Answer(string dozen3)
        {

            int X = 0;
            Int32.TryParse(dozen3, out X);


        
            int Y= X - 4;
            string convert = Convert.ToString(Y);
            return convert;
        }

    }
}
