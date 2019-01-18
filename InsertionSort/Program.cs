using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] testArray = { 2, 5, 41, 56, 2, 35, 99, 58 };
            testArray = InsertionSort(testArray);
            for (int i = 0; i < testArray.Length; i++)
            {
                Console.Write("  " + testArray[i]);
            }
            Console.WriteLine();
            testArray = insertionSort(testArray);
            for (int i = 0; i < testArray.Length; i++)
            {
                Console.Write("  " + testArray[i]);
            }
            Console.ReadKey();
        }

        static int[] InsertionSort(int[] arr)
        {
            int len = arr.Length;
            int preIndex, current;
            for (int i=1;i<len;i++)
            {
                preIndex = i - 1;
                current = arr[i];
                while (preIndex>=0&&arr[preIndex]>current)
                {
                    arr[preIndex + 1] = arr[preIndex];
                    preIndex--;
                }
                arr[preIndex + 1] = current;
            }
            return arr;
        }
        static int[] insertionSort(int[] arr)
        {
            int len = arr.Length;
            int preIndex, current;
            for (int i = 1; i < len; i++)
            {
                preIndex = i - 1;
                current = arr[i];
                while (preIndex >= 0 && arr[preIndex] < current)
                {
                    arr[preIndex + 1] = arr[preIndex];
                    preIndex--;
                }
                arr[preIndex + 1] = current;
            }
            return arr;
        }
    }
}
