using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    public class BubbleSort : ISorter
    {
        public IList<T> Sort<T>(IList<T> unsortedList) where T : IComparable<T>
        {
            for (int i = 0; i < unsortedList.Count(); i++)
            {
                for (int j = 0; j < unsortedList.Count(); j++)
                {
                    var outerItem = unsortedList[i];
                    var innerItem = unsortedList[j];
                    if (outerItem.CompareTo(innerItem) < 0)
                    {
                        swap(unsortedList, i, j);
                    }
                }
            }
            return unsortedList;
        }

        private void swap<T>(IList<T> list,int firstIndex, int secondIndex)
        {
            var firstItem = list[firstIndex];
            list[firstIndex] = list[secondIndex];
            list[secondIndex] = firstItem;
        }
    }
}
