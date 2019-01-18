using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] testArray = { 2,5,41,56,2,35,99,58};
            testArray = BubbleSort(testArray);
            for (int i = 0; i < testArray.Length; i++) {
                Console.Write("  "+testArray[i]);
            }
            Console.WriteLine();
            testArray = bubbleSort(testArray);
            for (int i = 0; i < testArray.Length; i++)
            {
                Console.Write("  " + testArray[i]);
            }
            Console.ReadKey();
        }
        //小到大
        static int[] BubbleSort(int[] arr)
        {
            for (int i=0;i<arr.Length-1;i++)
            {
                for (int j=0;j<arr.Length-1-i;j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            return arr;
        }
        //大到小
        static int[] bubbleSort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length-1-i;j++)
                {
                    if (arr[j] < arr[j + 1])
                    {
                        int tem = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = tem;
                    }

                }
            }
            return arr;
        }
    }
}
