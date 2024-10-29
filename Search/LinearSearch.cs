using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Search
{
    internal class LinearSearch
    {
        public int Search(int[] items, int n)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == n)
                    return i;
            }
            return -1;
        }
    }
}
