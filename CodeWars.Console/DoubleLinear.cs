using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars.ConsoleApp
{
    public class DoubleLinear
    {
        public static int DblLinear(int i)
        {
            var twoQueue = new Queue<int>(new[] {3});
            var threeQueue = new Queue<int>(new[] { 4 });
            int next = 1;
 
            for (int n = 0; n < i; n++)
            {
                var queue = twoQueue.Peek() <= threeQueue.Peek() ? twoQueue : threeQueue;
                
                next = queue.Dequeue();
                if (threeQueue.Peek() == next) threeQueue.Dequeue();
                
                twoQueue.Enqueue(2 * next + 1);
                threeQueue.Enqueue(3 * next + 1);
                
            }

            return next;
        }
    }
}
