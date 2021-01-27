using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility.ConsoleUI.Basic
{
    public class NumberOfDiscIntersections
    {
        public static int Solution(int[] A)
        {
            //My Solution
            //long fBot, fTop, sBot, sTop, result = 0;
            //for (int J = 0; J < A.Length - 1; J++)
            //{
            //    for (int K = J + 1; K < A.Length; K++)
            //    {
            //        fBot = J - A[J];
            //        fTop = J + A[J];
            //        sBot = K - A[K];
            //        sTop = K + A[K];
            //        if ((fBot <= sBot && sBot <= fTop) || (sBot <= fTop && fTop <= sTop) || (sBot <= fBot && fBot <= sTop) || (fBot <= sTop && sTop <= fTop))
            //            result++;
            //    }
            //}
            //return result > 10000000 ? -1 : (int)result;


            //Check this first
            int[] start = new int[A.Length];
            int[] end = new int[A.Length];
            int counts = 0;
            int result = 0;

            for (int i = 0; i < A.Length; i++)
            {
                start[i] = i - A[i];
                end[i] = i + A[i];
            }
            Array.Sort(start);
            for (int s = 0; s < A.Length; s++)
            {
                for (int e = 0; e < A.Length; e++)
                {
                    if (start[s] <= end[e])
                    {
                        counts++;
                    }
                }
                result += counts - 1 - s;
                counts = 0;
            }
            return result > 10000000 ? -1 : result;

            //Check this second
            //int N = A.Length;
            //long[] AX = new long[N];
            //long[] AY = new long[N];

            //for (int i = 0; i < N; i++)
            //{
            //    AX[Math.Max(0, (long)i - A[i])]++;
            //    AY[Math.Min(N - 1, (long)i + A[i])]++;
            //}
            //long result = 0;
            //long discsAtIndex = 0;
            //for (int i = 0; i < N; i++)
            //{
            //    if (AX[i] > 0)
            //    {
            //        result += discsAtIndex * AX[i] + (AX[i] * (AX[i] - 1) / 2);

            //        discsAtIndex += AX[i];
            //    }
            //    discsAtIndex -= AY[i];
            //}
            //if (result <= 10000000)
            //    return (int)result;
            //else return -1;
        }
    }
}
