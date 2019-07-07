using NUnit.Framework;
using System;
using DailyCodingProblem.Solutions.Problem17;

// ReSharper disable CheckNamespace
namespace DailyCodingProblem.Tests.Problem17Tests
{
    [TestFixture]
    public class LongestAbsoluteFilePath
    {
        [Test]
        public void Longest_Absolute_File_Empty_Path_should_Return_0()
        {
            var pathString = "";

            var result = Solution.LongestFilePathLength(pathString);

            Assert.AreEqual(0, result);
        }
        [Test]
        public void Longest_Absolute_File_Path_Should_Return_32()
        {
            var pathString = "dir\n\tsubdir1\n\t\tfile1.ext\n\t\tsubsubdir1\n\tsubdir2\n\t\tsubsubdir2\n\t\t\tfile2.ext";

            var result = Solution.LongestFilePathLength(pathString);

            Assert.AreEqual(32, result);
        }
        [Test]
        public void Longest_Absolute_File_Path_Should_Return_20()
        {
            var pathString = "dir\n\tsubdir1\n\tsubdir2\n\t\tfile.ext";

            var result = Solution.LongestFilePathLength(pathString);

            Assert.AreEqual(20, result);
        }


        [TestCase(1, "dir\n\tsubdir1\n\t\tfile1.ext\n\t\tsubsubdir1\n\tsubdir2\n\t\tsubsubdir2\n\t\t\tfile2.ext", 32)]
        [TestCase(2, "dir\n\tsubdir1\n\tsubdir2\n\t\tfile.ext", 20)]
        [TestCase(3, "", 0)]
        public void Longest_Absolute_File_Path_Should_Return_Int(int _, string input, int expectedResult)
        {
            var result = Solution.LongestFilePathLength(input);

            Assert.AreEqual(expectedResult, result);
        }

    }
}
