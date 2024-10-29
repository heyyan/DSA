using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.DataStructures
{
    public class Stack<T>
    {
        private T[] elements;
        private int top;
        private int capacity;

        public Stack(int size = 10)
        {
            elements = new T[size];
            top = -1;
            capacity = size;
        }

        public void Push(T element)
        {
            if (IsFull())
            {
                Console.WriteLine("Stack Overflow");
                return;
            }
            elements[++top] = element;
        }

        public T Pop()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Stack Underflow");
            }
            return elements[top--];
        }

        public T Peek()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Stack is empty");
            }
            return elements[top];
        }

        public bool IsEmpty()
        {
            return top == -1;
        }

        public bool IsFull()
        {
            return top == capacity - 1;
        }

        public int Size()
        {
            return top + 1;
        }

        public void Clear()
        {
            top = -1;
        }
    }
}
