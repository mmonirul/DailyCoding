using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyCodingProblem.Solutions.Problem21
{
    public class PlatformsRequired
    {
        public static void PlatformCount()
        {
            int[] arr = {900, 940, 950, 1100, 1500, 1800};
            int[] dep = {910, 1200, 1120, 1130, 1900, 2000};
            var n = arr.Length;
            Console.Write("Minimum Number of " + " Platforms Required = " + FindPlatform(arr, dep, n));
        }

        static int FindPlatform(int[] arr, int[] dep, int n)
        {
            // Sort arrival and departure arrays 
            Array.Sort(arr);
            Array.Sort(dep);

            // plat_needed indicates number of 
            // platforms needed at a time 
            int platNeeded = 1, result = 1;
            int i = 1, j = 0;

            // Similar to merge in merge sort to process all events in sorted order 
            while (i < n && j < n)
            {
                // If next event in sorted order is arrival, increment count of platforms needed 
                if (arr[i] <= dep[j])
                {
                    platNeeded++;
                    i++;
                    // Update result if needed 
                    if (platNeeded > result)
                        result = platNeeded;
                }
                // Else decrement count of platforms needed 
                else
                {
                    platNeeded--;
                    j++;
                }
            }

            return result;
        }

    }
}
