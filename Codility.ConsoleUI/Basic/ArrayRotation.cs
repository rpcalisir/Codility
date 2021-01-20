using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility.ConsoleUI.Basic
{
    /// <summary>
    /// 
    /// This method works as following;
    /// 3 8 9 7 6 
    /// 
    /// After one iteration
    /// 6 3 8 9 7 
    /// 
    /// Basically it brings the lates element of the array to the first
    /// 
    /// 
    /// An array A consisting of N integers is given. Rotation of the array means that each element is shifted right by one index, and the last element of the array is moved to the first place. For example, the rotation of array A = [3, 8, 9, 7, 6] is [6, 3, 8, 9, 7] (elements are shifted right by one index and 6 is moved to the first place).
    ///The goal is to rotate array A K times; that is, each element of A will be shifted to the right K times.
    ///Write a function:
    ///class Solution { public int[] solution(int[] A, int K); }
    ///that, given an array A consisting of N integers and an integer K, returns the array A rotated K times.
    ///For example, given
    ///    A = [3, 8, 9, 7, 6]
    ///    K = 3
    ///the function should return [9, 7, 6, 3, 8]. Three rotations were made:
    ///    [3, 8, 9, 7, 6] -> [6, 3, 8, 9, 7]
    ///    [6, 3, 8, 9, 7] -> [7, 6, 3, 8, 9]
    ///    [7, 6, 3, 8, 9] -> [9, 7, 6, 3, 8]
    ///        For another example, given
    ///     A = [0, 0, 0]
    ///     K = 1
    ///     the function should return [0, 0, 0]
    ///        Given
    ///     A = [1, 2, 3, 4]
    ///     K = 4
    ///     the function should return [1, 2, 3, 4]
    ///     Assume that:
    ///     N and K are integers within the range [0..100];
    ///     each element of array A is an integer within the range[−1, 000..1, 000].
    /// </summary>
    public static class ArrayRotation
    {
        public static int[] Solution(int[] A, int K)
        {
            Stack<int> st = new Stack<int>();

            for (int count = 0; count < K; count++)
            {
                for (int i = 0; i < A.Length; i++)
                {
                    st.Push(A[i]);
                }
                A[0] = st.Pop();
                for (int j = A.Length - 1; j >= 1; j--)
                {
                    A[j] = st.Pop();
                }
            }
            return A;
        }

        /// <summary>
        /// This method works as following;
        /// 3 8 9 7 6 
        /// 
        /// After one iteration
        /// 8 9 7 6 3 
        /// 
        /// Basically it brings the first element of the array to the last.
        /// 
        /// 
        /// 3 8 9 7 6
        /// Queue
        /// --------------------
        /// 67983
        /// --------------------
        /// queue.ToArray() -> 38976
        /// 
        /// 
        /// 3 8 9 7 6
        /// Queue
        /// --------------------
        /// 67983
        /// --------------------
        /// queue.Dequeue() -> ilk giren, 3 silinir
        /// queue.ToArray() -> 8976
        /// 
        /// </summary>
        /// <param name="A"></param>
        /// <param name="K"></param>
        /// <returns></returns>
        public static int[] ReverseSolution(int[] A, int K)
        {
            Queue<int> queue = new Queue<int>(A);
            Stack<int> stack = new Stack<int>();

            while (K > 0)
            {
                stack.Push(queue.Dequeue());
                queue.Enqueue(stack.Pop());
                K--;
            }

            return queue.ToArray();
        }
    }
}
