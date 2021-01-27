using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility.ConsoleUI.Demo
{
    /// <summary>
    /// Return the number of integers within the range [A..B] that are divisible by K.
    //  Args:
    //  A: is an integer within the range[0..2, 000, 000, 000]
    //  B: is an integer within the range[0..2, 000, 000, 000] and A <= B
    //  K: is an integer within the range[1..2, 000, 000, 000]
    /// </summary>
    public class FindMultiplesInRange
    {
        public static int Solution(int A, int B, int K)
        {
            return (B / K - A / K) + ((A % K) == 0 ? 1 : 0);
        }
    }
}
