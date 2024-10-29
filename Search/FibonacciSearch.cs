using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Search
{
    class FibonacciSearch
    {
        public int Search(int[] items, int target)
        {
            int n = items.Length;
            int fib2 = 0;
            int fib1 = 1;
            int fibM = fib2 + fib1;

            while (fibM < n)
            {
                fib2 = fib1;
                fib1 = fibM;
                fibM = fib2 + fib1;
            }

            int offset = -1;

            while (fibM > 1)
            {
                int i = Math.Min(offset + fib2, n - 1);
                if (items[i] < target)
                {
                    fibM = fib1;
                    fib1 = fib2;
                    fib2 = fibM - fib1;
                    offset = i;
                }
                else if (items[i] > target)
                {
                    fibM = fib2;
                    fib1 = fib1 - fib2;
                    fib2 = fibM - fib1;
                }
                else
                {
                    return i;
                }
            }
            if (fib1 == 1 && items[offset + 1] == target)
            {
                return offset + 1;
            }
            return -1;
        }
    }
}
