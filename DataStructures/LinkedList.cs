using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.DataStructures
{
    public class DSA_LinkedList<T>
    {
        private class Node
        {
            public T Data { get; set; }
            public Node Next { get; set; }

            public Node(T data)
            {
                Data = data;
                Next = null;
            }
        }


        private Node head;
        private int size;

        public DSA_LinkedList()
        {
            head = null;
            size = 0;
        }

        public void AddFirst(T data)
        {
            Node newNode = new Node(data);
            newNode.Next = head;
            head = newNode;
            size++;
        }

        public void AddLast(T data)
        {
            Node newNode = new Node(data);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }
            size++;
        }

        public bool Remove(T data)
        {
            if (head == null)
            {
                return false;
            }

            if (head.Data.Equals(data))
            {
                head = head.Next;
                size--;
                return true;
            }

            Node current = head;
            while (current.Next != null && !current.Next.Data.Equals(data))
            {
                current = current.Next;
            }

            if (current.Next != null)
            {
                current.Next = current.Next.Next;
                size--;
                return true;
            }
            return false;
        }
    }
}
