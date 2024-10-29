using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.DataStructures
{

    public class TreeNode<T>
    {
        public T Value { get; set; }
        public List<TreeNode<T>> Children { get; set; }

        public TreeNode(T value)
        {
            Value = value;
            Children = new List<TreeNode<T>>();
        }

        public void AddChild(TreeNode<T> node) { Children.Add(node); }

        public void RemoveChild(TreeNode<T> node)
        {
            Children.Remove(node);
        }
    }

    public class Tree<T>
    {
        public TreeNode<T> Root { get; set; }

        public Tree(T rootValue)
        {
            this.Root = new TreeNode<T>(rootValue);
        }

        public void TraverseDFS(TreeNode<T> node)
        {
            if (node == null)
            {
                return;
            }

            Console.WriteLine(node.Value.ToString());
            foreach (var child in node.Children)
            {
                TraverseDFS(child);
            }
        }

        public void TraverseBFS(TreeNode<T> node)
        {
            if (node == null) return;
            System.Collections.Generic.Queue<TreeNode<T>> queue = new System.Collections.Generic.Queue<TreeNode<T>>();
            queue.Enqueue(node);
            while (queue.Count > 0)
            {
                var current = queue.Dequeue();
                Console.WriteLine(current.Value.ToString());
                foreach (var child in current.Children)
                {
                    queue.Enqueue(child);
                }
            }
        }
    }
}
