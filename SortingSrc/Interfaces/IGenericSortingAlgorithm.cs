using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting.Src.Interfaces
{
    public interface IGenericSortingAlgorithm<T> where T : IComparable
    {
        IList<T> Sort(IList<T> list);
    }
}
