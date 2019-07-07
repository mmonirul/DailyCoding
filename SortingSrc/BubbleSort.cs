using System;
using System.Collections.Generic;
using Sorting.Src.Interfaces;

namespace Sorting.Src
{
    public class BubbleSort<T> : IGenericSortingAlgorithm<T> where T : IComparable
    {
        public IList<T> Sort(IList<T> list)
        {
            for (var i = 0; i < list.Count - 1; i++)
            {
                for (var j = 1; j < list.Count - i; j++)
                {
                    if (list[j - 1].CompareTo(list[j]) > 0)
                    {
                        Swap(list, j, j - 1);
                    }
                }
            }

            return list;
        }
        

        private static void Swap(IList<T> list, int a, int b)
        {
            var temp = list[a];
            list[a] = list[b];
            list[b] = temp;
        }
    }
}
