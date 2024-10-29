using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Search
{
    internal class TernarySearch
    {
        public int Search(int[] items, int n)
        {
            int left = 0;
            int right = items.Length - 1;

            while (left <= right)
            {

                int mid1 = left + (right - left) / 3;
                int mid2 = right - (right - left) / 3;

                if (items[mid1] == n) return mid1;
                if (items[mid2] == n) return mid2;

                if (n < items[mid1])
                {
                    right = mid1 - 1;
                }
                else if (n > items[mid2])
                {
                    left = mid2 + 1;
                }
                else
                {
                    left = mid1 + 1;
                    right = mid2 - 1;
                }

            }

            return -1;
        }
    }
}

