using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility.ConsoleUI.Demo
{
    /// <summary>
    /// Write a function:
    //  class Solution { public int solution(int[] A); }
    //  that, given an array A of N integers, returns the smallest positive integer(greater than 0) that does not occur in A.
    //  For example, given A = [1, 3, 6, 4, 1, 2], the function should return 5.
    //  Given A = [1, 2, 3], the function should return 4.
    //  Given A = [−1, −3], the function should return 1.
    //  Write an efficient algorithm for the following assumptions:
    //  N is an integer within the range[1..100, 000];
    //  each element of array A is an integer within the range[−1, 000, 000..1, 000, 000].
    /// </summary>
    public class SmallestNotContained
    {
        public int Solution(int[] A)
        {
            //BEST PRACTICE
            //int flag = 1;
            //A = A.OrderBy(x => x).ToArray();

            //for (int i = 0; i < A.Length; i++)
            //{
            //    if (A[i] < 0)
            //        continue;
            //    else if (A[i] == flag)
            //        flag++;
            //}
            //return flag;

            //CLEVER
            //var i = 0;
            //return A.Where(a => a > 0).Distinct().OrderBy(a => a).Any(a => a != (i = i + 1)) ? i : i + 1;

            //My latest solution %100
            if (A.Max() < 0)
                return 1;
            Array.Sort(A);

            int flag = 1;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == flag)
                    flag++;
            }
            return flag;

            //My old Solution
            //int result = 1;

            //for (int i = 0; i < A.Length; i++)
            //{
            //    if (A[i]<0)
            //    {
            //        continue;
            //    }
            //    if (A.Contains(result))
            //    {
            //        result++;
            //    }
            //}
            //return result;
        }
    }
}
