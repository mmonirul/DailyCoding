using System;
using System.Collections.Generic;
using System.Linq;

namespace DailyCodingProblem.Solutions.Problem01
{
    public class Solution
    {
        public static void Test()
        {
            Console.WriteLine("Please enter space separated integers");
            var numbers = Console.ReadLine()
                ?.Split(' ')
                .Select(int.Parse)
                .ToList();

            Console.WriteLine("k = ");
            var k = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException("Invalid number!"));

            var result = TwoNumbersEqual(numbers, k);
            Console.WriteLine(result);
        }

        public static bool TwoNumbersEqual(List<int> numbers, int k)
        {
            var set = new HashSet<int>();
            foreach (var number in numbers)
            {
                var remaining = k - number;

                if (set.Contains(remaining))
                {
                    return true;
                }

                set.Add(number);
            }

            return false;
        }
    }
}
