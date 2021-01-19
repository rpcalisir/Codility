using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSignal.Basic
{
    public static class MutateTheArray
    {
        public static int[] Solution(int n, int[] a)
        {
            int[] b = new int[n];
            if (n==1)
            {
                return a;
            }
            for (int i = 0; i < n; i++)
            {
                b[i] = (i == 0 ? 0 : a[i - 1]) + a[i] + (i == n - 1 ? 0 : a[i + 1]);
            }
            return b;
        }
    }
}
