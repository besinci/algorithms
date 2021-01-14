using ConsoleApp.FromTheBook;
using ConsoleApp.GrokkingAlgorithms;
using System;
using System.Collections.Generic;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var arr = new int[] { 72, 12, 6, 33 };
            RecursionAndQuickSort recursionAndQuickSort = new RecursionAndQuickSort();
            recursionAndQuickSort.Sort(arr, 0, arr.Length - 1);

            Console.ReadLine();
        }
    }
}
