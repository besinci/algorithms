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

            var arr = new int[] { 5, 3, 6, 2, 10 };
            SelectionSort selectionSort = new SelectionSort();
            selectionSort.Sort(arr);

            Console.ReadLine();
        }
    }
}
