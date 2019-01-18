using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShellSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 49, 38, 100, 97, 76, 13, 27, 49, 55, 4 };
            int[] d = { 5, 3, 1 };
            shellsort(a,10,d,3);
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("  " + a[i]);
            }
            Console.ReadKey();
        }

        static void ssort(int[] a, int n, int sp)
        {
            int i, j, t;
            for (i = 0; i < n - sp; i++)
                for (j = i; j < n - sp; j += sp)
                    if (a[j] > a[j + sp])
                    {
                        t = a[j]; a[j] = a[j + sp]; a[j + sp] = t;
                    }
        }

        static void shellsort(int[] a, int n, int[] d, int dn)
        {
            int i;
            for (i = 0; i < dn; i++)
                ssort(a, n, d[i]);
        }

    }
}
