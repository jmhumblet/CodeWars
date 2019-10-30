using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars.ConsoleApp
{
    public class Trees
    {
        public static List<int> TreeByLevels(Node node)
        {
            List<int> results = new List<int>();

            if (node == null) return results;
            
            var queue = new Queue<Node>();
            queue.Enqueue(node);

            while (queue.TryDequeue(out Node next))
            {
                if (next.Left != null) queue.Enqueue(next.Left);
                if (next.Right != null) queue.Enqueue(next.Right);
                results.Add(next.Value);
            }

            return results;
        }
    }

    public class Node
    {
        public Node Left;
        public Node Right;
        public int Value;

        public Node(Node l, Node r, int v)
        {
            Left = l;
            Right = r;
            Value = v;
        }
    }
}
