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

            var arr = new int[] { 6, 4, 2,  12, 5874, 3 };
            RecursionAndQuickSort recursionAndQuickSort = new RecursionAndQuickSort();
            var result = recursionAndQuickSort.MaximumNumber(arr);
            

            Console.ReadLine();
        }
    }
}
