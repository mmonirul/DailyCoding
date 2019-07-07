using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DailyCodingProblem.Solutions.Problem22
{
    public class Solution
    {
        public static void Test()
        {
            var dictionary1 = new string[]{"quick", "brown", "the", "fox"};
            var dictionary = new[] { "bed", "bath", "bedbath", "and", "beyond" };

            var inputHashArray = new HashSet<string>(new[] {"mobile","samsung","sam","sung", "man","mango", "icecream","and", "go","i","love","ice","cream"});

            const string inputString = "iloveicecreamandmango"; //Console.ReadLine();

            var items = WordBreakUtil(inputString, inputHashArray, "");

            //if (dictionary == null) return;
            var hashSet = new HashSet<string>(dictionary);

            //var words = GetWordsFromDictionary(input, hashSet);

            Console.WriteLine(string.Join(" ", items));
        }
        private static IList<string> _listString = new List<string>();

        public static IList<string> WordBreakUtil(string inputString, HashSet<string> inputHashArray, string result = "")
        {
            for (var i = 1; i <= inputString.Length; i++)
            {
                var str = inputString.Substring(0, i);

                if (!inputHashArray.Contains(str)) continue;
                if (i == inputString.Length)
                {
                    result += str;
                    Console.WriteLine(result);
                    _listString.Add(result);
                }
                WordBreakUtil(inputString.Substring(i, inputString.Length -i), inputHashArray, result +str+" ");
            }

            return _listString;
        }


        public static IEnumerable<string> GetWordsFromDictionary(string input, HashSet<string> dictionary)
        {
            var builder = new StringBuilder();

            var result = new List<string>();

            foreach (var t in input)
            {
                builder.Append(t);
                var word = builder.ToString();

                if (!dictionary.Contains(word)) continue;
                result.Add(word);

                builder = builder.Clear();
            }

            return result;
        }
    }


}