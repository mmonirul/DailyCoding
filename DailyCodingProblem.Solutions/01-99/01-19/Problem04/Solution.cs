using System;
using System.Collections.Generic;
using System.Linq;

namespace DailyCodingProblem.Solutions.Problem04
{
    public class Solution
    {
        public static int GetMinimalPositiveNumber(HashSet<int> input)
        {
            var minPositiveNumber = 1;

            while (true)
            {
                if(!input.Contains(minPositiveNumber)) break;

                minPositiveNumber++;
            }

            return minPositiveNumber;
        }
    }
}
