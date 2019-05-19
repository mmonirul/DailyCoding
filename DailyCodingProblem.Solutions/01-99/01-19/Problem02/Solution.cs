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

            for (var i = 0; i < result.Length; i++)
            {
                result[i] = 1;
                for (var j = 0; j < result.Length; j++)
                {
                    if (j != i) result[i] *= numbers[j];
                }
            }
            return result;
        }


        public static int GetArrayOfProducts_recursion(int[] numbers, int size, int left, int index)
        {

            if (index == size) return 1;
            int current = numbers[index];

            var right = GetArrayOfProducts_recursion(numbers, size, left * numbers[index], index + 1);

            numbers[index] = left * right;

            return current * right;
        }
    }
}
