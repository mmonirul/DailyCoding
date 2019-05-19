using System;
using System.Collections;

namespace DailyCodingProblem.Solutions.Problem13
{
    public class Solution
    {
        public static void Test()
        {
            var result = LongestSubstringDistinctK("abcba", 2);
            Console.WriteLine(result);
        }

        public static string LongestSubstringDistinctK(string str, int k)
        {
            if (string.IsNullOrEmpty(str))
            {
                return str;
            }

            Hashtable htChars = new Hashtable();
            var back = 0;
            var front = back;
            var beginSolution = 0;
            var endSolution = 0;

            while (front < str.Length)
            {
                if ((htChars.Count < k && !htChars.ContainsKey(str[front])) ||
                    (htChars.Count <= k && htChars.ContainsKey(str[front])))
                {
                    if (front - back > endSolution - beginSolution)
                    {
                        beginSolution = back;
                        endSolution = front;
                    }
                    if (!htChars.ContainsKey(str[front]))
                    {
                        htChars.Add(str[front], 1);
                    }
                    else
                    {
                        htChars[str[front]] = (int)htChars[str[front]] + 1;
                    }
                    front++;
                }
                else
                {
                    //Remove the back and move it
                    htChars[str[back]] = (int)htChars[str[back]] - 1;
                    if ((int)htChars[str[back]] == 0)
                    {
                        htChars.Remove(str[back]);
                    }

                    back++;
                }
            }

            return str.Substring(beginSolution, endSolution - beginSolution + 1);
        }
    }
}

//TODO: More practice... 