using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSignal.Basic
{
    /// <summary>
    /// Write a C# program to find the pair of adjacent elements that has the highest product of an given array of integers.
    ///     For inputArray = [3, 6, -2, -5, 7, 3], the output should be
    ///     adjacentElementsProduct(inputArray) = 21.
    ///     7 and 3 produce the largest product.
    /// </summary>
    public static class AdjascentElementsProduct
    {
        public static int Solution(int[] inputArray)
        {
            int max = inputArray[0] * inputArray[1];
            for (int i = 0; i < inputArray.Length-1; i++)
            {
                max = Math.Max(max,inputArray[i]*inputArray[i+1]);
            }
            return max;
        }
    }
}
