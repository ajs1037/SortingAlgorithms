using System;
using System.Diagnostics;

/*
 * 
 * Adolfo Segura
 * 
 */

namespace SortingAlgorithms
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            int[] arr = { 1, 5, 10, 12, 20, 26, 30, 31, 35, 39, 43, 56, 58, 67, 78, 85, 87, 92, 94, 111};


            Console.WriteLine("Linear Search: ");
            TimeLinearSearch(arr, 26);
            TimeLinearSearch(arr, 22);

            Console.WriteLine("Binary Search: ");
            TimeBinarySearch(arr, 26);
            TimeBinarySearch(arr, 22);


           
        }

        public static int LinearSearch(int[] array, int item)
        {
            int N = array.Length;
            for (int i = 0; i < N; i++)
                if (array[i] == item)
                    return i;
            return -1;
        }

        public static int BinarySearch(int[] array, int item)
        {
            int min = 0;
            int size = array.Length;
            int max = size - 1;
            do
            {
                int mid = (min + max) / 2;
                if (item > array[mid])
                    min = mid + 1;
                else
                    max = mid - 1;
                if (array[mid] == item)
                    return mid;

            } 
            while (min <= max);
                return -1;
        }


        public static void TimeLinearSearch(int[] data, int num)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();

            LinearSearch(data, num);

            watch.Stop();

            string elapsed = watch.Elapsed.ToString();

            Console.WriteLine("Time it took to find " + num + " : "  + elapsed);
           
        }

        public static void TimeBinarySearch(int[] data, int num)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();

            BinarySearch(data, num);

            watch.Stop();

            string elapsed = watch.Elapsed.ToString();

            Console.WriteLine("Time it took to find " + num + " : " + elapsed);
        }

    }
}