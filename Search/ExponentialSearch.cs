using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Search
{
    internal class ExponentialSearch
    {
        public int Search(int[] items, int target)
        {
            if (target < items[0] || target > items[items.Length - 1]) return -1;
            int count = items.Length;
            if (items[0] == target) return 0;
            int i = 1;
            while (i < count && items[i] <= target)
            {
                i *= 2;
            }
            if (i >= items.Length)
            {
                i = items.Length - 1;
            }
            if (items[i] == target)
            {
                return i;
            }

            // do biranry search
            int left = i / 2;
            int right = Math.Min(i, count - 1);
            while (left < right)
            {
                int mid = left + (right - left) / 2;
                if (items[mid] == target) { return mid; }

                if (items[mid] < target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }

            }
            return -1;
        }
    }
}
