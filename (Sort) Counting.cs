﻿using System;
using System.Linq;

namespace Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { -5, -10, 0, -3, 8, 5, -1, 10 };
            CountSort(arr);
            PrintArray(arr);

        }

        static void CountSort(int[] arr)
        {
            int max = arr.Max();
            int min = arr.Min();

            int range = max - min + 1;

            int[] count = new int[range];
            int[] output = new int[arr.Length];


            for (int i = 0; i < arr.Length; i++)
                count[arr[i] - min]++;

            for (int i = 1; i < count.Length; i++)
                count[i] += count[i - 1];
           
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                output[count[arr[i] - min] - 1] = arr[i];
                count[arr[i] - min]--;
            }

            for (int i = 0; i < arr.Length; i++)         
                arr[i] = output[i];
            
        }

        static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine("");
        }
    }
}
