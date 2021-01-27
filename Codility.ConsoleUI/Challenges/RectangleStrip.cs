using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility.ConsoleUI.Challenges
{
    /// <summary>
    /// There are N rectangles numbered from 0 to N-1. The K-th rectangle has size A[K] × B[K].
    //    We want to arrange as many rectangles as possible into a strip.The rectangles can be arranged into a strip if they all share a
    //  side of the same length (which becomes the height of the strip). Note that rectangles can be rotated.
    //   Write a function:
    //  class Solution { public int solution(int[] A, int[] B); }
    //    that, given two arrays A and B of N integers each, returns the maximum number of rectangles that can be arranged into a strip.
    //    Examples:
    //  1. Given A = [2, 3, 2, 3, 5] and B = [3, 4, 2, 4, 2], the function should return 3. Choosing the 0th, 2nd and 4th rectangles we can 
    //  obtain the following strip of height 2 (note that the 0th rectangle was rotated):
    //  (3 × 2), (2 × 2), (5 × 2)
    //  We can also choose the 0th, 1st and 3rd rectangles to obtain a strip of height 3. Here we have rotated 1st and 3rd rectangles:
    //  (2 × 3), (4 × 3), (4 × 3)
    //  2. Given A = [2, 3, 1, 3] and B = [2, 3, 1, 3], the function should return 2. We can choose the 1st and 3rd rectangles:
    //  (3 × 3), (3 × 3)
    //  3. Given A = [2, 10, 4, 1, 4] and B = [4, 1, 2, 2, 5], the function should return 3. We can choose the 0th, 2nd and 4th rectangles to
    //  obtain a strip of height 4:
    //  (2 × 4), (2 × 4), (5 × 4)
    /// </summary>
    public class RectangleStrip
    {
        public static int Solution(int[] A, int[] B)
        {
            //Combine two arrays into single array, only add element into list where two elements are same in the same index
            List<int> arrList = new List<int>();
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == B[i])
                    arrList.Add(A[i]);
                else
                {
                    arrList.Add(A[i]);
                    arrList.Add(B[i]);
                }
            }
            //Find the most frequent element's occurance value
            int most = FindMostFrequent(arrList);

            return most;
        }
        private static int FindMostFrequent(List<int> arr)
        {
            Dictionary<int, int> occurances = new Dictionary<int, int>();
            foreach (var element in arr)
            {
                if (!occurances.ContainsKey(element))
                {
                    occurances.Add(element, 1);
                }
                else
                {
                    int value = occurances[element];
                    value++;
                    occurances[element] = value;
                }
            }

            //Return how many times the most frequent element is occured
            int max = 0;
            foreach (var pair in occurances)
            {
                if (max < pair.Value)
                {
                    max = pair.Value;
                }
            }
            return max;
        }
    }
}
