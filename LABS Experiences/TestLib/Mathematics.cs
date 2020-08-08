using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLib
{
    public class Mathematics
    {
        public static int IntSum(params int[] numbers)
        {
            int res = 0;
            foreach (int number in numbers)
            {
                res += number;
            }
            return res;
        }
    }
}
