using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Solution.Problem11_20
{
    public static class Problem20
    {
        public static void Solution()
        {
            int input = 100;
            BigInteger factorial = Factorial(input);
            int sum = factorial.ToString().Select(x => Convert.ToInt32(x.ToString())).ToList().Sum();
            Console.WriteLine("Sum of factorial " + " is  : " + sum);

        }

        private static BigInteger Factorial(int input)
        {
            if (input == 1) return 1;
            else return input * Factorial(input - 1);
        }
    }
}
