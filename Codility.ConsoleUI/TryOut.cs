using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility.ConsoleUI
{
    /// <summary>
    ///Startindex(i++)'ten başlayarak dizinin sonuna kadar n'i arar, ilk gördüğü index'i döndürür, bulamazsa -1 döndürür.
    /// </summary>
    public static class TryOut
    {
        public static int Solution(int[] A, int X)
        {
            int currentPos = 0;
            int[] position = new int[X + 1];

            for (int i = 0; i < A.Length; i++)
            {
                if(position[A[i]]==0)
                {
                    position[A[i]] = A[i];
                    currentPos++;
                }
                if (currentPos== X)
                {
                    return i;
                }
            }
            return -1;
        }


        public static Predicate<int> Pre = delegate (int a)
        {
            return a % 2 == 0;
        };
    }
}
