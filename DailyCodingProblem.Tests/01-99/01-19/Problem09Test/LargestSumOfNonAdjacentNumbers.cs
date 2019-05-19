using NUnit.Framework;
using System;

// ReSharper disable CheckNamespace
namespace DailyCodingProblem.Tests.Problem09Tests
{
    [TestFixture]
    public class LargestSumOfNonAdjacentNumbers
    {
        [Test]
        public void Largest_sum_of_non_adjacent_numbers_in_BigOn_and_constant_time()
        {

            //[] should return 13, since we pick 2, 6, and 5. [5, 1, 1, 5] should return 10
            var numbers = new[]
            {
                2, 4, 6, 2, 5
            };
            var numbers2 = new[]
            {
                5, 5, 10, 40, 50, 35, 5, 5, 10, 40, 50, 35, 40, 50, 35, 5, 5, 10, 40, 50, 1, 99, 45, 89, 343, 324,65, 35, 10, 40, 50, 35, 40, 50,
                35, 5, 10, 40, 50, 35, 40, 50, 35, 453, 4, -1, 1, 99, 45, 89, 343, 324, 65, 5, 10, 40, 50, 35, 5, 5, 10, 40, 50, 35, 40, 50, 35, 5, 5, 10, 40, 50, 1, 99, 45, 89, 343, 324,65, 35, 10, 40, 50, 35, 40, 50,
                35, 5, 10, 40, 50, 35, 40, 50, 35, 453, 4, -1, 1, 99, 45, 89, 343, 324, 65
            };


            const int expected = 4084;

            var result = Solutions.Problem09.Solution.GetMaxSum(numbers2);

            Assert.AreEqual(expected, result);
        }
        [Test]
        public void Largest_sum_of_non_adjacent_numbers_in_recursion()
        {
            var numbers = new[]
            {
                5, 5, 10, 40, 50, 35, 5, 5, 10, 40, 50, 35, 40, 50, 35, 5, 5, 10, 40, 50, 1, 99, 45, 89, 343, 324, 65,
                35, 10, 40, 50, 35, 40, 50

            };
            const int expected = 947;

            var result = Solutions.Problem09.Solution.GetMaxSum_Recursion(numbers);

            Assert.AreEqual(expected, result);
        }
    }
}
