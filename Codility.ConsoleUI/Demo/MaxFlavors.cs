using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility.ConsoleUI.Demo
{
    /// <summary>
    /// Rick is really fond of fruit juices, but he is bored of their traditional flavours. Therefore, he has decided to mix as many of them as possible to obtain something entirely new as a result.
    ///He has N glasses, numbered from 0 to N-1, each containing a different kind of juice.The J-th glass has capacity[J] units of capacity and contains juice[J] units of juice.In each glass there is at least one unit of juice.
    ///Rick want to create a multivitamin mix in one of the glasses. He is going to do it by pouring juice from several other glasses into the chosen one. Each of the used glasses must be empty at the end (all of the juice from each glass has to be poured out).
    ///What is the maximum number of flavours that Rick can mix?
    ///Write a function:
    ///class Solution { public int solution(int[] juice, int[] capacity); }
    ///that, given arrays juice and capacity, both of size N, returns the maximum number of flavours that Rick can mix in a single glass.
    ///Examples:
        ///1. Given juice = [10, 2, 1, 1] and capacity = [10, 3, 2, 2], your function should return 2. Rick can pour juice from the 3rd glass into the 2nd one.
        ///2. Given juice = [1, 2, 3, 4] and capacity = [3, 6, 4, 4], your function should return 3. Rick can pour juice from the 0th and 2nd glasses into the 1st one.
        ///3. Given juice = [2, 3] and capacity = [3, 4], your function should return 1. No matter which glass he chooses, Rick cannot pour juice from the other one into it. The maximum number of flavours in the chosen glass is 1.
        ///4. Given juice = [1, 1, 5] and capacity = [6, 5, 8], your function should return 3. Rick can mix all juices in the 2nd glass.
        ///Write an efficient algorithm for the following assumptions:
        ///N is an integer within the range[2..100, 000];
        ///each element of arrays juice, capacity is an integer within the range[1..1, 000, 000, 000];
        ///arrays juice and capacity have the same length, equal to N;
        ///for each J juice[J] ≤ capacity[J].
    /// </summary>
    public static class MaxFlavors
    {
        /// <summary>
        /// - Create empty spots array with substracting Juice from Capacity
        /// - Brute force through each empty spot with adding all juice elements into it;
        /// except same index because there is already a juice type in there
        /// - If sum doesn't exceed the amount of empty spot, then add that juice into it and increase count by 1
        /// - If sum exceeds the amount of empty spot, then substract that added juice and decrease count by 1
        /// - Replace max with each number at the end of iteration if it's bigger than before 
        /// - Return +1 with max because there is already a juice in each spot
        /// </summary>
        /// <param name="juice"></param>
        /// <param name="capacity"></param>
        /// <returns></returns>
        public static int Solution(int[] juice, int[] capacity)
        {
            //TODO find a more clever solution
            //My solution
            int[] empty = new int[juice.Length];
            for (int i = 0; i < juice.Length; i++)
            {
                empty[i] = capacity[i] - juice[i];
            }
            int counter = 0, sum = 0, max = 0;
            for (int e = 0; e < empty.Length; e++)
            {
                for (int j = 0; j < juice.Length; j++)
                {
                    if (e != j)
                    {
                        sum = sum + juice[j];
                        counter++;
                    }
                    if (sum > empty[e])
                    {
                        sum -= juice[j];
                        counter--;
                    }
                }
                if (counter > max)
                    max = counter;
                sum = 0;
                counter = 0;
            }
            return max + 1;
        }
    }
}
