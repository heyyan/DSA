using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.DataStructures
{
    internal class Queue<T>
    {
        private T[] elements;
        private int front;
        private int rear;
        private int size;
        private int capacity;

        public Queue(int capacity)
        {
            this.capacity = capacity;
            elements = new T[capacity];
            front = 0;
            rear = -1;
            size = 0;
        }

        public bool IsFull()
        {
            return size == capacity;
        }

        public bool IsEmpty()
        {
            return size == 0;
        }


        public void Enqueue(T item)
        {
            if (IsFull())
            {
                Console.WriteLine("Queue is full");
                return;
            }

            rear = (rear + 1) % capacity;
            elements[rear] = item;
            size++;
            Console.WriteLine($"{item} added to the queue");
        }

        public T Dequeue()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue is empty");
                throw new InvalidOperationException("Queue is empty");
            }

            T item = elements[front];
            front = (front + 1) % capacity;
            size--;
            return item;
        }

        public T Peek()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Queue is empty");
            }

            return elements[front];
        }

        // Get the current size of the queue
        public int GetSize()
        {
            return size;
        }
    }
}
