using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Solution.Problem11_20
{
    public static  class Problem16
    {
       public static void Solution()
        {
            /*
                2 power 215 = 32768 and the sum of its digits is 3 + 2 + 7 + 6 + 8 = 26.
                What is the sum of the digits of the number 21000?
             */
            double times = 1000;
            BigInteger powerSum = (BigInteger)Math.Pow(2, times);
            string sumString = powerSum.ToString();
            List<int> list = sumString.Select(x => Convert.ToInt32(x.ToString())).ToList();
            int sum = list.Sum();
            Console.WriteLine(sum);
        }
    }
}
