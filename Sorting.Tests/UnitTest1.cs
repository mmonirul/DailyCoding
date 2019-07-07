using NUnit.Framework;
using Sorting.Src;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void Test1()
        {
            var sort = new BubbleSort<int>();
            var items = new int[] { 1, 9, 4, 5 };
            var result = sort.Sort(items);

            Assert.AreEqual(result, new int[] { 1, 4, 5, 9 });
        }
    }
}