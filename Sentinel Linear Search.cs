using System;

namespace Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 10, 20, 180, 30, 60, 50 };
            int n = arr.Length;
            int key = 180;

            sentinalSearch(arr, n, key);
        }

        static void sentinalSearch(int[] arr,int n,int key)  //array,array length,key
        {
            //n = arr.Length;

            int i = 0;
            while (arr[i] != key)
                i++;

            if((i<n-1) || (arr[n-1]==key))
                Console.WriteLine(key+ " is present" + " ar index "+ i);
            else
                Console.WriteLine("Element Not found");
        }
    }
}
