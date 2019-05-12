using NUnit.Framework;
using System;

// ReSharper disable CheckNamespace
namespace DailyCodingProblem.Tests.Problem07Tests
{
    [TestFixture]
    public class NumberOfWaysToDecodeTest
    {
        [Test]
        public void NumberOfWaysToDecode_WithValidInputTest()
        {
            const string numberString = "111";
            var _expected = 3;

            var result = Solutions.Problem07.Solution.NumberOfWaysToDecode(numberString, 0);

            Console.WriteLine(result);
            Assert.AreEqual(_expected, result);
        }

        [Test]
        public void NumberOfWaysToDecode_WithInvalidInputTest()
        {
            const string numberString = "001";
            var _expected = 0;

            var result = Solutions.Problem07.Solution.NumberOfWaysToDecode(numberString, 0);

            Console.WriteLine(result);
            Assert.AreEqual(_expected, result);
        }
    }
}
