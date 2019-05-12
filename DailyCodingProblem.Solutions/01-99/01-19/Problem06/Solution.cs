using System;

namespace DailyCodingProblem.Solutions.Problem06
{
    public class Solution
    {
        public static void Test()
        {
            InMemoryLinkedList<int> list = new InMemoryLinkedList<int>();

            for (int i = 0; i < 10; i++)
            {
                list.Add(i);
            }

            Console.WriteLine(list.Get(5));
        }
    }
}
