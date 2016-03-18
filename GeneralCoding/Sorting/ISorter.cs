using System;
using System.Collections.Generic;

namespace Sorting
{
    public interface ISorter
    {
        IList<T> Sort<T>(IList<T> unsortedList) where T : IComparable<T>;
    }
}