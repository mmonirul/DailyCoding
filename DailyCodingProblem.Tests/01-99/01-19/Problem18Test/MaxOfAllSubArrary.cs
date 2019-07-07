using NUnit.Framework;
using System;
using DailyCodingProblem.Solutions.Problem18;

// ReSharper disable CheckNamespace
namespace DailyCodingProblem.Tests.Problem18Tests
{
    [TestFixture]
    public class MaxOfAllSubArrary
    {

        [Test]
        public void MaxOfAllSubArraryOf_Given_Size_K_Iterative_Process()
        {
            Solution.Test();
        }
        [Test]
        public void MaxOfAllSubArraryOf_Given_Size_K_Using_Deque()
        {
            int[] arr = { 10, 5, 2, 7, 8, 7 };
            //int[] arr = { 10, 5, 2, 7};
            int k = 3;
            Solution.PrintMaxFromSubArrayDequeue(arr, arr.Length, k);
        }
        [Test]
        public void MaxOfAllSubArraryOf_Given_Size_K_Using_Deque_2()
        {
            int[] arr = { 12, 1, 78, 90, 57, 89, 56, 75 };
            int k = 3;
            var result = Solution.PrintMaxFromSubArrayDequeue(arr, arr.Length, k);

        }

        [TestCase(1, new [] { 10, 5, 2, 7, 8, 7 }, 3, new [] { 10, 7, 8, 8 })]
        [TestCase(2, new [] { 12, 1, 78, 90, 57, 89, 56, 75 }, 3, new [] { 78, 90, 90, 90, 89, 89 })]
        public void MaxOfAllSubArraryOf_Given_Size_K_Using_Deque_3(int _, int[] input, int k, int[] expectedResult)
        {
            var result = Solution.PrintMaxFromSubArrayDequeue(input, input.Length, k);

            CollectionAssert.AreEqual(expectedResult, result);
        }

    }
}
