using System;

namespace Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 64, 25, 12, 22, 11 };
            InsertionSort(arr);
            Console.WriteLine("Sorted array");
            PrintArray(arr);
        }


        static void InsertionSort(int[] arr)
        {
            int n = arr.Length;

            for (int i = 0; i < n; ++i)
            {
                int key = arr[i];
                int j = i - 1;

                // Move elements of arr[0..i-1],
                // that are greater than key,
                // to one position ahead of
                // their current position
                while (j>=0 && arr[j]>key)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = key;


            }
        }

        static void PrintArray(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; i++)
                Console.WriteLine(arr[i] + " ");
            Console.WriteLine("\n");
        }
    }
}
