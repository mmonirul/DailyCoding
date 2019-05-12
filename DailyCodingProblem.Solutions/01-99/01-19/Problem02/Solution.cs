using System;
using System.Linq;

namespace DailyCodingProblem.Solutions.Problem02
{
    public class Solution
    {
        public static void Test()
        {
            Console.WriteLine("Please enter space separated integers");
            var numbers = Console.ReadLine()?.Split(' ').Select(int.Parse).ToArray();
            var result = GetArrayOfProducts(numbers);

            if (result != null) Console.WriteLine("[{0}]", string.Join(", ", result));
        }

        public static int[] GetArrayOfProducts(int[] numbers)
        {
            var result = new int[numbers.Length];

            for (int i = 0; i < result.Length; i++)
            {
                result[i] = 1;
                for (int j = 0; j < result.Length; j++)
                {
                    if (j != i) result[i] *= numbers[j];
                }
            }
            return result;
        }
    }
}
