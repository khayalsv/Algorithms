using System;
using System.Linq;

namespace Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 12, 11, 13, 5, 6, 7 };
            Sort(arr);
            PrintArray(arr);
        }

        static void Sort(int[] arr)
        {
            int n = arr.Length;

            // Build heap (rearrange array)
            for (int i = n / 2 - 1; i >= 0; i--)
                Heapify(arr, n, i);


            // One by one extract an element from heap
            for (int i = n - 1; i > 0; i--)
            {
                // Move current root to end
                int temp = arr[0];
                arr[0] = arr[i];
                arr[i] = temp;

                // call max heapify on the reduced heap
                Heapify(arr, i, 0);
            }
        }



        // To heapify a subtree rooted with node i which is
        // an index in arr[]. n is size of heap
        static void Heapify(int[] arr, int n,int i)
        {
            int largest = i;     // Initialize largest as root
            int a = 2 * i + 1;   // left = 2*i + 1
            int b = 2 * i + 2;   // right = 2*i + 2

            // If left child is larger than root
            if (a < n && arr[a] > arr[largest])
                largest = a;

            // If right child is larger than largest so far
            if (b < n && arr[b] > arr[largest])
                largest = b;

            // If largest is not root
            if (largest != i)
            {
                int swap = arr[i];
                arr[i] = arr[largest];
                arr[largest] = swap;

                // Recursively heapify the affected sub-tree
                Heapify(arr, n, largest);
            }

        }

        static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
