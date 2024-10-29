using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.DataStructures
{
    public class Array<T>
    {
        private T[] _items;
        private int _count;

        public Array(int capacity)
        {
            _items = new T[capacity];
            _count = 0;
        }


        public T this[int index]
        {
            get
            {
                if (index >= _count || index < 0)
                    throw new IndexOutOfRangeException();
                return _items[index];
            }

            set
            {
                if (index >= _count || index < 0)
                    throw new IndexOutOfRangeException();
                _items[index] = value;
            }
        }

        public void Add(T item)
        {
            if (_count == _items.Length)
            {
                Resize();
            }
            _items[_count++] = item;
        }

        public void RemoveAt(int index)
        {
            if (index >= _count || index < 0)
                throw new IndexOutOfRangeException();

            for (int i = index; i < _count - 1; i++)
            {
                _items[i] = _items[i + 1];
            }
            _count--;
        }

        public int Count
        {
            get { return _count; }
        }
        private void Resize()
        {
            T[] newArray = new T[_items.Length * 2];
            Array.Copy(_items, newArray, _items.Length);
            _items = newArray;
        }
    }
}
