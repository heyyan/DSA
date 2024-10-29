using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.DataStructures
{
    public class Dictionary<TKey, TValue>
    {
        public const int InitialCapicity = 16;
        private LinkedList<KeyValuePair<TKey, TValue>>[] buckets;
        private int size;

        public Dictionary()
        {
            buckets = new LinkedList<KeyValuePair<TKey, TValue>>[InitialCapicity];
            size = 0;
        }

        private int GetBucketIndex(TKey key)
        {
            int hash = key.GetHashCode();
            return Math.Abs(hash % buckets.Length);
        }

        public void Add(TKey key, TValue value)
        {
            int index = GetBucketIndex(key);

            if (buckets[index] == null)
            {
                buckets[index] = new LinkedList<KeyValuePair<TKey, TValue>>();
            }

            foreach (var kvp in buckets[index])
            {
                if (kvp.Key.Equals(key))
                {
                    throw new ArgumentException("An element with th same key already exists");
                }
            }

            buckets[index].AddLast(new KeyValuePair<TKey, TValue>(key, value));
            size++;
        }

        public TValue Get(TKey key)
        {
            int index = GetBucketIndex(key);
            if (buckets[index] != null)
            {
                foreach (var kvp in buckets[index])
                {
                    if (kvp.Key.Equals(key))
                    {
                        return kvp.Value;
                    }
                }
            }
            throw new KeyNotFoundException("The given key was not present in the dictionary");
        }
        public bool Remove(TKey key)
        {
            int index = GetBucketIndex(key);
            if (buckets[index] != null)
            {
                var current = buckets[index].First;
                while (current != null)
                {
                    if (current.Value.Key.Equals(key))
                    {
                        buckets[index].Remove(current);
                        size--;
                        return true;
                    }
                    current = current.Next;
                }
            }
            return false;
        }

        public bool ContainsKey(TKey key)
        {
            int index = GetBucketIndex(key);

            if (buckets[index] != null)
            {
                foreach (var kvp in buckets[index])
                {
                    if (kvp.Key.Equals(key))
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public int Count
        {
            get { return size; }
        }

        public TValue this[TKey key]
        {
            get { return Get(key); }
            set
            {
                if (ContainsKey(key))
                {
                    Remove(key);
                }
                Add(key, value);
            }
        }
    }
}
