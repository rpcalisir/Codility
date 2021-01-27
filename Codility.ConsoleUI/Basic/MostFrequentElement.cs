using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility.ConsoleUI.Basic
{
    /// <summary>
    /// Find the most frequent element in an array.
    /// </summary>
    public class MostFrequentElement
    {
        public static int Solution(int[] A)
        {
            //Create a new dictionary to hold the number of occurances as key-value pairs(array element-occurance value)
            Dictionary<int, int> occurances = new Dictionary<int, int>();

            //Increase the value of each key in the dictionary each time an array element is seen
            foreach (var element in A)
            {
                if (!occurances.ContainsKey(element))
                {
                    occurances.Add(element, 1);//Initial value of an element when first added is 1
                }
                else
                {
                    int value = occurances[element];
                    value++;
                    occurances[element] = value;
                }
            }

            //Find the max value in the dictionary as it is the most frequent element's occurance number
            int max = 0, result = -1;
            foreach (var pair in occurances)
            {
                if (max<pair.Value)
                {
                    max = pair.Value;
                    result = pair.Key;
                }
            }
            return result;
        }
    }
}
