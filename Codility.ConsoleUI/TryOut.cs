using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility.ConsoleUI
{
    public static class TryOut
    {
        public static int[] Solution(int[] A, int K)
        {
            Queue<int> queue = new Queue<int>(A);
            Stack<int> stack = new Stack<int>();

            //while(K>0)
            //{
            //stack.Push(queue.Dequeue());
            //queue.Enqueue(stack.Pop());
            //K--;
            //}
            queue.Dequeue();
            return queue.ToArray();
        }
    }
}
