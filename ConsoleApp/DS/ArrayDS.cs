namespace ConsoleApp.DS
{
    public class ArrayDS
    {
        /// <summary>
        /// https://www.hackerrank.com/challenges/arrays-ds/problem
        /// </summary>
        /// <param name="arrayInput">1 4 3 2</param>
        /// <returns>2 3 4 1</returns>
        public static int[] ReverseArray(int[] arrayInput)
        {
            int[] reversedArray = new int[arrayInput.Length];

            for (int i = 0; i < arrayInput.Length; i++)
            {
                var indexNumber = arrayInput.Length - 1 - i;
                reversedArray[i] = arrayInput[indexNumber];
            }

            return reversedArray;
        }
    }
}
