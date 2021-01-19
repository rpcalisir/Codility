using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility.ConsoleUI
{
    public static class TryOut
    {
        public static int[] MutateTheArray(int n, int[] a)
        {
            int[] b = new int[n];
            for (int i = 0; i < n; i++)
            {
                if (i == 0)
                {
                    b[i] = 0 + a[i] + a[i + 1];
                }
                else if (i == (n - 1))
                {
                    b[i] = a[i - 1] + a[i] + 0;
                }
                else
                {
                    b[i] = a[i - 1] + a[i] + a[i + 1];
                }
            }
            return b;
        }
    }
}
