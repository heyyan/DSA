using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Search
{
    internal class BinarySearch
    {
        public int Search(int[] items, int n)
        {
            int startIndex = 0;
            int endIndex = items.Length - 1;

            while (startIndex <= endIndex)
            {
                int middleIndex = startIndex + (endIndex - startIndex) / 2;

                if (items[middleIndex] == n)
                {
                    return middleIndex;
                }
                else if (items[middleIndex] < n)
                {
                    startIndex = middleIndex + 1;
                }
                else
                {
                    endIndex = middleIndex - 1;
                }
            }
            return -1;
        }
    }
}
