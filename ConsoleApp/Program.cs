using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //var reverseArrayInput = new int[] { 1, 4, 3, 2 };
            //ArrayDS.ReverseArray(reverseArrayInput);

            //var rotateArray = new List<int>() { 1, 2, 3, 4, 5 };
            //ArrayDS.RotateLeft(4, rotateArray);

            //ArrayDS.MatchingStrings(
            //    new string[] { "aba", "baba", "aba", "xzxb" }, 
            //    new string[] { "aba", "xzxb", "ab" });

            //StringBuilderImp sbi = new StringBuilderImp();
            //sbi.Append('!');
            //sbi.Append(" Hello.");
            //Console.WriteLine(sbi.ToString());

            var result = Practice.ReverseWord("Muvaffakiyetsizleştiricileştiriveremeyebileceklerimizdenmişsinizcesine");
            Console.WriteLine(result);


            Console.ReadLine();
        }
    }
}
