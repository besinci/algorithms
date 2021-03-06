﻿using System.Collections.Generic;

namespace ConsoleApp.GrokkingAlgorithms
{
    public class RecursionAndQuickSort
    {
        /*

        3.2 Suppose you accidentally write a recursive function that runs
            forever. As you saw, your computer allocates memory on the
            stack for each function call. What happens to the stack when your
            recursive function runs forever? 
        Answer: stack overflow
        
        */


        // 4.1 Write out the code for the earlier sum function. { 6, 4, 2 } = 12
        int sumTotal = 0;
        public int RecursionSum(int[] arr, int index = 0)
        {
            if (arr.Length != index)
            { 
                sumTotal += arr[index];
                index++;
                RecursionSum(arr, index);
            }

            return sumTotal;
        }

        // 4.2 Write a recursive function to count the number of items in a list.
        int listItemCount = 0;
        public int CountNumberInTheList(int[] arr, int index = 0)
        {
            if (arr.Length != index)
            {
                index++;
                listItemCount++;
                CountNumberInTheList(arr, index);
            }

            return listItemCount;
        }

        // 4.3 Find the maximum number in a list.
        int maxNumber = 0;
        public int MaximumNumber(int[] arr, int index = 0)
        {
            if (arr.Length != index)
            {
                if (arr[index] > maxNumber)
                    maxNumber = arr[index];

                index++;
                MaximumNumber(arr, index);
            }

            return maxNumber;
        }

        // 4.4 Remember binary search from chapter 1? 
        //     It’s a divide-and-conquer algorithm, too.
        //     Can you come up with the base case and recursive case for binary search? 
        // Answer: I'm not sure but I believe best case would be that the middle number is what we are looking for.
        //         recursive case would be take middle element if element is bigger take right side of list, 
        //         if element is smaller take the left side of the list.
        
        public void Sort(int[] arr, int low, int high)
        {
            if (low < high)
            {
                int partitionIndex = Partition(arr, low, high);

                Sort(arr, low, partitionIndex - 1);
                Sort(arr, partitionIndex + 1, high);
            }
        }

        private int Partition(int[] arr, int low, int high)
        {
            int pivot = arr[high];
            int lowIndex = (low - 1);

            // reorder list
            for (int i = low; i < high; i++)
            {
                if (arr[i] <= pivot)
                {
                    lowIndex++;

                    int temp = arr[lowIndex];
                    arr[lowIndex] = arr[i];
                    arr[i] = temp;
                }
            }

            int temp1 = arr[lowIndex + 1];
            arr[lowIndex + 1] = arr[high];
            arr[high] = temp1;

            return lowIndex + 1;
        }

        /*
         
            How long would each of these operations take in Big O notation?
            4.5 Printing the value of each element in an array.
            Answer: O(n)

            4.6 Doubling the value of each element in an array.
            Answer: O(n)    

            4.7 Doubling the value of just the first element in an array.
            Answer: O(1)

            4.8 Creating a multiplication table with all the elements in the array. 
                So if your array is [2, 3, 7, 8, 10], you first multiply every element by 2,
                then multiply every element by 3, then by 7, and so on.
            Answer: O(n2)

         */
    }
}
