using ConsoleApp.DS;
using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var reverseArrayInput = new int[] { 1, 4, 3, 2 };
            ArrayDS.ReverseArray(reverseArrayInput);

            Console.ReadLine();
        }
    }
}
