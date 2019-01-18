using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] testArray = { 2,55,23,1,5,48,65,32,1,2,4,88};
            testArray = SelectionSort(testArray);
            for (int i = 0; i < testArray.Length; i++)
            {
                Console.Write("  " + testArray[i]);
            }
            Console.WriteLine();
            testArray = selectionSort(testArray);
            for (int i = 0; i < testArray.Length; i++)
            {
                Console.Write("  " + testArray[i]);
            }
            Console.ReadKey();
        }

        static int[] SelectionSort(int[] arr)
        {
            int len = arr.Length;
            int minIndex, temp;
            for (int i = 0; i < len - 1; i++)
            {
                minIndex = i;
                for (int j=i+1;j<len;j++)
                {
                    if (arr[j]<arr[minIndex])
                    {
                        minIndex = j;
                    }
                }
                temp = arr[i];
                arr[i] = arr[minIndex];
                arr[minIndex] = temp;
            }
            return arr;
        }
        static int[] selectionSort(int[] arr)
        {
            int len = arr.Length;
            int minIndex, temp;
            for (int i = 0; i < len - 1; i++)
            {
                minIndex = i;
                for (int j = i + 1; j < len; j++)
                {
                    if (arr[j] > arr[minIndex])
                    {
                        minIndex = j;
                    }
                }
                temp = arr[i];
                arr[i] = arr[minIndex];
                arr[minIndex] = temp;
            }
            return arr;
        }
    }
}
