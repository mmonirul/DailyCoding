using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace DailyCodingProblem.Tests.Problem04Tests
{
    [TestFixture]
    public class GetArrayOfProductsTest
    {
        [TestCase(1, new[] { 3, 4, -1, 1 }, 2)]
        [TestCase(2, new[] { 1, 2, 0 }, 3)]
        public void TestGetArrayOfProducts_ShouldReturnCorrectly(int _, int[] input, int expectedResult)
        {

            var result = Solutions.Problem04.Solution.GetMinimalPositiveNumber(input.ToHashSet());

            Assert.AreEqual(expectedResult, result);
        }
    }
}
