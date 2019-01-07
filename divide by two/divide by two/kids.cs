using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace divide_by_two
{
   public static class Kids // 6. static class
    {
        public static int KidCount(int currentKids, int numb2)

        {
            return  currentKids / numb2;
            

        }

        //5. OverLoad the method
        public static int KidCount(int currentKids, int numb2,int StepKids)
        {
            return currentKids / numb2 + StepKids;

        }
    }
}
