using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DailyCodingProblem.Solutions.Problem25
{
    public class Solution
    {
        public static void Test()
        {
            var pattern = "ra.";
            var stringInput = "ray";

            Console.WriteLine(IsMatch(stringInput, pattern));


        }

        public static bool IsMatch(string text, string pattern)
        {
            if (string.IsNullOrEmpty(pattern)) return string.IsNullOrEmpty(text);

            var firstMatch = (!string.IsNullOrEmpty(text) && (pattern[0] == text[0] || pattern[0] == '.'));
            if (pattern.Length >= 2 && pattern[1] == '*')
            {
                return (IsMatch(text, pattern.Substring(2)) || (firstMatch && IsMatch(text.Substring(1), pattern)));
            }

            return firstMatch && IsMatch(text.Substring(1), pattern.Substring(1));
        }
    }
}