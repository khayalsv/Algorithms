using System;

namespace Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 3, 4, 10, 40 };
            int n = arr.Length;
            int x = 10;

            int result = binarySearch(arr, 0, n - 1, x);

            if (result == -1)
                Console.WriteLine("Element not present");
            else
                Console.WriteLine("Element found at index "
                                  + result);
        }


        // Returns index of x if it is present in
        // arr[l..r], else return -1
        static int binarySearch(int[] arr ,int a,int z,int x)
        {
            if (z>=a)
            {
                int mid = a + (z - 1) / 2;


                // If the element is present at the
                // middle itself
                if (arr[mid] == x)
                    return mid;


                // If element is smaller than mid, then
                // it can only be present in left subarray
                if (arr[mid] > x)
                    return binarySearch(arr, a, mid - 1, x);

                return binarySearch(arr, mid + 1, z, x);
            }

            // We reach here when element is not present
            // in array
            return -1;
        }
    }
}
