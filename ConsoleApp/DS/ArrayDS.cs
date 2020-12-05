using System.Collections;
using System.Collections.Generic;
using System.Linq;

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

        /// <summary>
        /// https://www.hackerrank.com/challenges/array-left-rotation/problem
        /// </summary>
        /// <param name="leftRotationGap">4</param>
        /// <param name="arr">1 2 3 4 5</param>
        /// <returns>5 1 2 3 4</returns>
        public static List<int> RotateLeft(int leftRotationGap, List<int> arr)
        {
            int arrayLength = arr.Count;
            int[] rotatedArray = new int[arrayLength];

            int rightRotationGap = arrayLength - leftRotationGap;
            for (int index = 0; index < arrayLength; index++)
            {
                int newIndex = (index + rightRotationGap) % arrayLength;
                rotatedArray[newIndex] = arr[index];
            }

            return rotatedArray.ToList();
        }

        /// <summary>
        /// https://www.hackerrank.com/challenges/sparse-arrays/problem
        /// </summary>
        /// <param name="strings"></param>
        /// <param name="queries"></param>
        /// <returns></returns>
        public static int[] MatchingStrings(string[] strings, string[] queries)
        {
            var output = new List<int>();

            for (int i = 0; i < queries.Length; i++)
            {
                var count = 0;
                var checkElement = queries[i]; 
                for (int j = 0; j < strings.Length; j++)
                {
                    if (checkElement == strings[j])
                    {
                        count++;
                    }
                }
                output.Add(count);
            }
            
            return output.ToArray();
        }


    }
}
