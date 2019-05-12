using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace DailyCodingProblem.Tests.Problem02Tests
{
    [TestFixture]
    public class GetArrayOfProductsTest
    {
        [TestCase(1, new[] { 1, 2, 3, 4, 5 }, new[] { 120, 60, 40, 30, 24 })]
        [TestCase(2, new[] { 3, 2, 1 }, new[] { 2, 3, 6 })]
        public void TestGetArrayOfProducts_ShouldReturnCorrectly(int _, int[] input, int[] expectedResult)
        {
            var result = Solutions.Problem02.Solution.GetArrayOfProducts(input);

            CollectionAssert.AreEqual(expectedResult, result);
        }
    }
}
