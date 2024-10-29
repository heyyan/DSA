using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.DataStructures
{
    public class Heap<T> where T : IComparable<T>
    {
        private List<T> elements;

        public Heap()
        {
            elements = new List<T>();
        }

        public int Size()
        { return elements.Count; }

        public bool IsEmpty()
        {
            return elements.Count == 0;
        }

        public T Peek()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Heap is empty");
            }
            return elements[0];
        }

        public void Insert(T item)
        {
            elements.Add(item);
            HeapifyUp(Size() - 1);
        }

        public T Pop()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Heap is empty");

            T root = elements[0];
            elements[0] = elements[Size() - 1];
            elements.RemoveAt(Size() - 1);
            HeapifyDown(0); // Maintain the heap property
            return root;
        }

        private void HeapifyUp(int index)
        {
            int parentIndex = (index - 1) / 2;

            while (index > 0 && elements[index].CompareTo(elements[parentIndex]) > 0)
            {
                Swap(index, parentIndex);
                index = parentIndex;
                parentIndex = (index - 1) / 2;
            }
        }

        private void HeapifyDown(int index)
        {
            int leftChild = 2 * index + 1;
            int rightChild = 2 * index + 2;
            int largest = index;

            if (leftChild < Size() && elements[leftChild].CompareTo(elements[largest]) > 0)
            {
                largest = leftChild;
            }

            if (rightChild < Size() && elements[rightChild].CompareTo(elements[largest]) > 0)
            {
                largest = rightChild;
            }

            if (largest != index)
            {
                Swap(index, largest);
                HeapifyDown(largest);
            }
        }
        private void Swap(int index1, int index2)
        {
            T temp = elements[index1];
            elements[index1] = elements[index2];
            elements[index2] = temp;
        }
    }
}
