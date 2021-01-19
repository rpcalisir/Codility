using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSignal.Basic
{
    public static class CheckPalindrome
    {
        public static bool Solution(string inputString)
        {
            //Convert to Char Array
            char[] inputArr = inputString.ToCharArray();

            //Reverse char array
            Array.Reverse(inputArr);

            //Convert reversed char array to reverse string
            string reversedString = new String(inputArr);

            //Compare if string is same
            return true && String.Equals(inputString, reversedString);
        }
    }
}
