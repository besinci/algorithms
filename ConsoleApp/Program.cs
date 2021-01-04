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

            //LinkedLists linkedLists = new LinkedLists();
            //LinkedList<int> test = new LinkedList<int>();
            //test.First.Value = 1;
            //test.First.Next.Value = 2;
            //test.First.Next.Next.Value = 3;

            BinarySearch search = new BinarySearch();
            search.Search(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, 8);

            Console.ReadLine();
        }
    }
}
