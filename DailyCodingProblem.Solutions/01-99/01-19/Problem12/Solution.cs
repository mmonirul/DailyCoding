using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyCodingProblem.Solutions.Problem12
{
    public class Solution
    {
        public static void Test()
        {
            var n = 4;
            var x = new[] {1, 2};

            var waysToClimb = Climb(0, n, x);

            Console.WriteLine(waysToClimb);
        }

        public static int Climb(int climbedStairs, int n, int[] x)
        {
            if (climbedStairs > n) return 0;

            //for (int i = 0; i < x.Length; i++)
            //{
            //    var nextClimb = climbedStairs + x[i];

            //    result += Climb(nextClimb, n, x);
            //}

            //return result;
            return climbedStairs == n ? 1 : x.Select(i => climbedStairs + i).Select(nextClimb => Climb(nextClimb, n, x)).Sum();
        }
    }
}
