using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace DailyCodingProblem.Solutions.Problem18
{
    public class Solution
    {
        public static void Test()
        {
            //var result = LongestFilePathLength("dir\n\tsubdir1\n\tsubdir2\n\t\tfile.ext");
            //int[] arr = {1, 2, 3, 1, 4, 5, 2, 3, 6};
            int[] arr = { 1, 3, -1, -3, 5, 3, 6, 7 };

            //int[] arr = { 10, 5, 2, 7};
            int k = 3;
            PrintMaxFromSubArrayIterative(arr, arr.Length, k);

            Console.WriteLine("");
        }

        public static void PrintMaxFromSubArrayIterative(int[] arr, int n, int k)
        {
            int j, max;

            for (var i = 0; i <= n-k; i++)
            {
                max = arr[i];
                for (j = 1; j < k; j++)
                {
                    if (arr[i + j] > max)
                        max = arr[i + j];
                }
                Console.Write(max + " ");
            }
        }
        //Time Complexity : The outer loop runs n-k+1 times and the inner loop runs k times for every iteration of outer loop.
        //So time complexity is O((n-k+1)*k) which can also be written as O(nk).
        //Reference : http://www.geeksforgeeks.org/maximum-of-all-subarrays-of-size-k/
        public static int[] PrintMaxFromSubArrayDequeue(int[] arr, int n, int k)
        {
            var list = new List<int>();
            int i;
            for (i = 0; i < k; i++)
            {
                while (list.Count != 0 && arr[i] >= arr[list.IndexOf(0)])
                {
                    list.RemoveAt(list.Count - 1);
                }
                list.Insert(list.Count, i);
            }
            var result = new List<int>();
            for (; i < n; i++)
            {
                //Console.Write(arr[list[0]] + " ");
                result.Add(arr[list[0]]);
                while ((list.Count != 0) && list[0] <= i-k)
                {
                    list.RemoveAt(0);
                }

                while (list.Count != 0 && arr[i] >= arr[list[list.Count - 1]])
                {
                    list.RemoveAt(list.Count - 1);
                }
                list.Insert(list.Count, i);
            }
            // Print the maximum element of last window 
            //Console.Write(arr[list[0]]);
            result.Add(arr[list[0]]);

            return result.ToArray();
        }
        //Time Complexity : The outer loop runs n-k+1 times and the inner loop runs k times for every iteration of outer loop.
        //So time complexity is O((n-k+1)*k) which can also be written as O(nk).
    }
}