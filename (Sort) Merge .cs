using System;

namespace Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 64, 25, 12, 22, 11 };
            Sort(arr, 0, arr.Length - 1);
            Console.WriteLine("Sorted array");
            PrintArray(arr);

        }

        // Merges two subarrays of []arr.
        // First subarray is arr[a..b]
        // Second subarray is arr[b+1..c]
        static void Merge(int[] arr,int a,int b,int c)
        {
            // Find sizes of two
            // subarrays to be merged
            int n1 = b - a + 1;
            int n2 = c - b;


            // Create temp arrays
            int[] A = new int[n1];
            int[] C = new int[n2];



            int i, j;
            // Copy data to temp arrays
            for (i = 0; i < n1; ++i)
                A[i] = arr[a + i];
            for (j = 0; j < n2; ++j)
                C[j] = arr[b + 1 + j];


            // Merge the temp arrays

            // Initial indexes of first
            // and second subarrays
            i = 0;
            j = 0;

            // Initial index of merged
            // subarray array
            int k = a;

            while (i<n1&& j<n2)
            {
                if (A[i]<=C[j])
                {
                    arr[k] = A[i];
                    i++;
                }
                else
                {
                    arr[k] = C[j];
                    j++;
                }
                k++;
            }

            // Copy remaining elements
            // of L[] if any
            while (i < n1)
            {
                arr[k] = A[i];
                i++;
                k++;
            }

            // Copy remaining elements
            // of R[] if any
            while (j < n2)
            {
                arr[k] = C[j];
                j++;
                k++;
            }

        }

        // Main function that
        // sorts arr[l..r] using
        // merge()
        static void Sort(int[] arr, int a, int c)
        {
            if (a < c)
            {
                // Find the middle
                // point
                int b = a + (c - a) / 2;

                // Sort first and
                // second halves
                Sort(arr, a, b);
                Sort(arr, b + 1, c);

                // Merge the sorted halves
                Merge(arr, a, b, c);
            }
        }

        static void PrintArray(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; i++)
                Console.WriteLine(arr[i] + " ");
            Console.WriteLine();
        }
    }
}
