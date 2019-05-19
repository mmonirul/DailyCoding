using NUnit.Framework;
using System;

// ReSharper disable CheckNamespace
namespace DailyCodingProblem.Tests.Problem12Tests
{
    [TestFixture]
    public class StairsClimbTest
    {
        [Test]
        public void Five_unique_ways_for_four_steps()
        {
            //Solutions.Problem12.Solution.Test();
            var n = 4;
            var x = new[] {1, 2};

            var expected = 5;

            var result = Solutions.Problem12.Solution.Climb(0, n, x);

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Should_return_One_for_Singe_step()
        {
            //Solutions.Problem12.Solution.Test();
            var n = 1;
            var x = new[] { 1, 2 };

            var expected = 1;

            var result = Solutions.Problem12.Solution.Climb(0, n, x);
            Console.WriteLine(result);

            Assert.AreEqual(expected, result);
        }
        [Test]
        public void For_any_number_of_set()
        {
            //Solutions.Problem12.Solution.Test();
            var n = 5;
            var x = new[] { 1, 3, 5 };

            var expected = 5;

            var result = Solutions.Problem12.Solution.Climb(0, n, x);
            Console.WriteLine(result);

            Assert.AreEqual(expected, result);
        }
    }
}
