using System;
using System.Collections;
using System.IO;
using System.Reflection;

namespace DailyCodingProblem.Solutions.Problem17
{
    public class Solution
    {
        public static void Test()
        {
            var result = LongestFilePathLength("dir\n\tsubdir1\n\tsubdir2\n\t\tfile.ext");

            Console.WriteLine(result);
        }

        public static int LongestFilePathLength(string path)
        {
            var result = 0;

            if (path.Length == 0) return result;

            var dirsAndFiles = path.Split('\n');

            var stack = new Stack();

            stack.Push(0);

            foreach (var dirOrFile in dirsAndFiles)
            {
                var lastIdx = dirOrFile.LastIndexOf('\t');
                var level = lastIdx + 1;
                var len = dirOrFile.Length - level;

                while (level < stack.Count - 1)
                {
                    stack.Pop();
                }

                if (dirOrFile.Contains("."))
                {
                    result = Math.Max(result, len + (int)stack.Peek());
                }
                else
                {
                    stack.Push((int)stack.Peek() + len + 1);
                }
            }

            return result;
        }
    }
}

//TODO: More practice...