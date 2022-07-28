using System;

namespace Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 64, 25, 12, 22, 11 };
            int n = arr.Length;
            QuickSort(arr, 0, n - 1);
            Console.WriteLine("Sorted array");
            PrintArray(arr,n);

        }

        // A utility function to swap two elements
        static void swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }



        static int Partition(int[] arr, int low, int high)
        {
            // pivot
            int pivot = arr[high];

            // Index of smaller element and
            // indicates the right position
            // of pivot found so far
            int i = (low - 1);

            for (int j = low; j <= high - 1; j++)
            {

                // If current element is smaller 
                // than the pivot
                if (arr[j] < pivot)
                {

                    // Increment index of 
                    // smaller element
                    i++;
                    swap(arr, i, j);
                }
            }
            swap(arr, i + 1, high);
            return (i + 1);
        }

        static void QuickSort(int[] arr, int low, int high)
        {
            if (low < high)
            {

                // pi is partitioning index, arr[p]
                // is now at right place 
                int pi = Partition(arr, low, high);

                // Separately sort elements before
                // partition and after partition
                QuickSort(arr, low, pi - 1);
                QuickSort(arr, pi + 1, high);
            }
        }


        static void PrintArray(int[] arr, int size)
        {
            for (int i = 0; i < size; i++)
                Console.Write(arr[i] + " ");

            Console.WriteLine();
        }
    }
}
