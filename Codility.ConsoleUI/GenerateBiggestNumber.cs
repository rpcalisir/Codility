using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility.ConsoleUI
{
    public static class GenerateBiggestNumber
    {
        public static int Solution(int number, int numToInsert)
        {
            //Edge case
            if (number==0)
            {
                return numToInsert * 10;
            }

            int negative = number / Math.Abs(number);
            int position = 1;
            int digitCounter = 0;

            number = Math.Abs(number);
            int num = number;
            while (num>0)
            {
                digitCounter++;
                num /= 10;
            }

            int maxValue = int.MinValue;
            for (int i = 0; i <= digitCounter; i++)
            {
                int newNumber = (((number/position)*(position*10)) + (numToInsert*position) + (number%position));
                if (newNumber*negative>maxValue)
                {
                    maxValue = newNumber * negative;
                }
                position *= 10;
            }
            return maxValue;
        }
    }
}
