using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace DailyCodingProblem.Tests.Problem01Tests
{
    [TestFixture]
    public class TwoNumbersEqualTests
    {
        [Test]
        public void TestProblem01Solution_NumbersAddUpToK_ShouldReturnTrue()
        {
            var numbers = new[] { 10, 15, 3, 7 }
                .ToList();
            var k = 17;

            var result = Solutions.Problem01.Solution.TwoNumbersEqual(numbers, k);

            Assert.IsTrue(result);
        }

        [Test]
        public void TestProblem01Solution_NumbersDoNotAddUpToK_ShouldReturnFalse()
        {
            var numbers = new[] { 10, 15, 3, 7 }
                .ToList();
            var k = 16;

            var result = Solutions.Problem01.Solution.TwoNumbersEqual(numbers, k);

            Assert.IsFalse(result);
        }
    }
}
