using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Search
{
    internal class HashTableSearch
    {
        public List<int> Search(int[] items, int n)
        {
            var hashTable = ConvertToHashTable(items);
            int key = n.GetHashCode();
            if (hashTable.ContainsKey(key))
            {
                return hashTable[key];
            }

            return new List<int>();
        }


        private Dictionary<int, List<int>> ConvertToHashTable(int[] items)
        {
            var hashTable = new Dictionary<int, List<int>>();

            for (int i = 0; i < items.Length; i++)
            {
                int hash = items[i].GetHashCode();
                if (!hashTable.ContainsKey(hash))
                {
                    hashTable.Add(hash, new List<int>() { i });
                }
                else
                {
                    hashTable[hash].Add(i);
                }
            }

            return hashTable;
        }
    }
}
