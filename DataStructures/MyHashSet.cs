using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.DataStructures
{
    public class MyHashSet<T>
    {
        private const int InitialCapacity = 16;
        private LinkedList<T>[] _buckets;
        private int _size;

        public MyHashSet()
        {
            _buckets = new LinkedList<T>[InitialCapacity];
            _size = 0;

        }

        public void Add(T item)
        {
            int bucketIndex = GetBucketIndex(item);
            if (_buckets[bucketIndex] == null)
            {
                _buckets[bucketIndex] = new LinkedList<T>();
            }
            if (!_buckets[bucketIndex].Contains(item))
            {
                _buckets[bucketIndex].AddLast(item);
                _size++;
            }
        }

        public bool Contains(T item)
        {
            int bucketIndex = GetBucketIndex(item);
            if (_buckets[bucketIndex] != null)
            {
                return _buckets[bucketIndex].Contains(item);
            }
            return false;
        }

        public bool Remove(T item)
        {
            int bucketIndex = GetBucketIndex(item);
            if (_buckets[bucketIndex] != null)
            {
                if (_buckets[bucketIndex].Remove(item))
                {
                    _size--;
                    return true;
                }
            }
            return false;
        }

        public int Count { get { return _size; } }

        private int GetBucketIndex(T? item)
        {
            return Math.Abs(item.GetHashCode()) % _buckets.Length;
        }
    }
}
