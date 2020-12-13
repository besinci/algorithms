using ConsoleApp.FromTheBook;
using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            ArrayAndStrings arrayAndStrings = new ArrayAndStrings();
            var result = arrayAndStrings.CompressString("aaabbccccc");

            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
