using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility.ConsoleUI.Demo
{
    /// <summary>
    /// Write a function that returns the maximum possible value obtained by inserting any single digit inside the decimal
    /// representation of integer N.
    /// 
    /// forming of the formula:
    /// newVal = ((num / position) * (position * 10)) + (digit * position) + (num % position)
    /// suppose, num = 276, starting from position = 1, and the digit = 3.
    /// 
    /// number will be in three parts: [left of 3] + [3] + [right of 3]
    /// 
    /// step 1: ((276/1) * (1*10)) + (3*1) + (276%1) = [2760]+[3]+[0] = [2763]
    /// step 2: ((276/10) * (10*10)) + (3*10) + (276%10) = [2700]+[30]+[6] = [2736]
    /// step 3: ((276/100) * (100*10)) + (3*100) + (276%100) = [2000]+[300]+[76] = [2376]
    /// step 4: ((276/1000) * (1000*10)) + (3*1000) + (276%1000) = [0]+[3000]+[276] = [3276]
    /// </summary>
    public static class MaximumPossibleValue
    {
        public static int Solution(int number, int numToInsert) //5,276
        {
            bool sign = false;
            if (number<0)
            {
                sign = true;
                number = Math.Abs(number);
            }
            List<int> digits = new List<int>();

            int digit = 0;
            while(number!=0)
            {
                digit = number % 10; //  digit = 6
                number /= 10; // number = 27
                digits.Add(digit);
            }
            digits.Add(numToInsert);
            digits.Sort((a, b) => b.CompareTo(a));
            Console.WriteLine(String.Join(",",digits));

            int max = 0;
            foreach (var d in digits)
            {
                max = max * 10 + d;
            }

            if (sign)
                max *= -1;
            return max;


            //Not working correctly
            ////Edge case
            //if (number==0)
            //{
            //    return numToInsert * 10;
            //}

            //int negative = number / Math.Abs(number);
            //int position = 1;
            //int digitCounter = 0;

            //number = Math.Abs(number);
            //int num = number;
            //while (num>0)
            //{
            //    digitCounter++;
            //    num /= 10;
            //}

            //int maxValue = int.MinValue;
            //for (int i = 0; i <= digitCounter; i++)
            //{
            //    int newNumber = ((number/position)*(position*10)) + (numToInsert*position) + (number%position);
            //    if (newNumber*negative>maxValue)
            //    {
            //        maxValue = newNumber * negative;
            //    }
            //    position *= 10;
            //}
            //return maxValue;
        }
    }
}
