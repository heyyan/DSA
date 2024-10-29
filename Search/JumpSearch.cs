using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Search
{
    internal class JumpSearch
    {
        public int Search(int[] items, int n)
        {
            int len = items.Length;
            int step = (int)Math.Floor(Math.Sqrt(len));
            int prev = 0;

            while (items[Math.Min(step, len) - 1] < n)
            {
                prev = step;
                step += step;
                if (prev >= len) return -1;
            }

            while (items[prev] < n)
            {
                prev++;
                if (prev >= len) return -1;
                if (prev == Math.Min(step, len)) return -1;
            }

            if (items[prev] == n)
            {
                return prev;
            }

            return -1;
        }

        public int Search2(int[] items, int target)
        {
            if (target < items[0] || target > items[items.Length - 1]) return -1;

            int jumpStep = (int)Math.Floor(Math.Sqrt(items.Length));
            int nextIndex = 0;

            while (items[nextIndex] < target)
            {
                nextIndex += jumpStep;
                if (nextIndex >= items.Length)
                {
                    nextIndex = items.Length - 1;
                    break;
                }
            }

            if (items[nextIndex] == target)
            {
                return nextIndex;
            }

            int inlearStart = nextIndex - jumpStep + 1;
            if (inlearStart < 0) return -1;


            while (items[inlearStart] < target)
            {
                inlearStart++;
                if (inlearStart >= items.Length) return -1;
            }

            if (items[inlearStart] == target)
            {
                return inlearStart;
            }

            return -1;
        }
    }
}
