using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility.ConsoleUI
{
    /// <summary>
    /// Mod 10, then divide by 10
    /// </summary>
    public static class NumToDigits
    {
        public static int[] Solution(int number)
        {
            Stack<int> digits = new Stack<int>();
            int digit;

            while(number>0)
            {
                digit = number % 10;
                digits.Push(digit);

                number /= 10;
            }
            return digits.ToArray();
        }
    }
}
