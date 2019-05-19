using System;
using System.Diagnostics;
using System.Dynamic;
using System.Linq;

namespace DailyCodingProblem.Solutions.Problem09
{
    public class Solution
    {
        public static void Test()
        {
            var numbers = new int[]
            {
                5, 5, 10, 40, 50, 35, 5, 5, 10, 40, 50, 35, 40, 50, 35, 5, 5, 10, 40, 50, 35, 10, 40, 50, 35, 40, 50,
                35, 5, 10, 40, 50, 35, 40, 50, 35, 5
            };
            //GetInput();
            var maxSum = GetMaxSum(numbers);
            Console.WriteLine($"MaxSum: {maxSum}");
        }

        public static int[] GetInput()
        {
            var input = Console.ReadLine()?.Split(' ').Select(int.Parse).ToArray();

            return input;
        }

        public static int GetMaxSum(int[] numbers)
        {
            var watch = Stopwatch.StartNew();
            var maxSum = FindMaxSum(numbers, numbers.Length);
            Console.WriteLine($"GetMaxSum: {maxSum}");
            watch.Stop();
            Console.WriteLine("Time taken: {0}ms", watch.ElapsedMilliseconds);

            return maxSum;
        }
        public static int GetMaxSum_Recursion(int[] numbers)
        {
            var watch = Stopwatch.StartNew();
            var maxSum = FindMaxSum_Recursion(numbers, 0, 0, false);
            watch.Stop();
            Console.WriteLine("Time taken: {0}ms", watch.ElapsedMilliseconds);

            return maxSum;
        }

        private static int FindMaxSum_Recursion(int[] numbers, int currentIndex, int currentSum, bool isPreviousAdded)
        {
            if (currentIndex == numbers.Length) return currentSum;

            var currentMaxSum = currentSum;

            if (!isPreviousAdded)
            {
                var maxIfAddCurrent = FindMaxSum_Recursion(numbers, currentIndex + 1, currentSum + numbers[currentIndex], true);
                currentMaxSum = Math.Max(maxIfAddCurrent, currentMaxSum);
            }

            var maxIfDontAddCurrent = FindMaxSum_Recursion(numbers, currentIndex + 1, currentSum, false);
            currentMaxSum = Math.Max(currentMaxSum, maxIfDontAddCurrent);

            return currentMaxSum;
        }

        //Follow-up: In O(N) time and constant space
        private static int FindMaxSum(int[] numbers, int n)
        {
            if (n == 0) return 0;
            if (n == 1) return numbers[0];

            var incl = numbers[0];
            var excl = 0;

            for (var i = 1; i < n; i++)
            {
                var exclNew = (incl > excl) ? incl : excl;
                incl = excl + numbers[i];
                excl = exclNew;
            }

            return (incl > excl) ? incl : excl;
        }
    }
}
