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
        
        4.2 Write a recursive function to count the number of items in a list.
        4.3 Find the maximum number in a list.
        4.4 Remember binary search from chapter 1? It’s a divide-and-conquer
            algorithm, too. Can you come up with the base case and recursive
            case for binary search?

         */


        // 4.1 Write out the code for the earlier sum function. { 6, 4, 2 } = 12
    
        int total = 0;
        public int RecursionSum(int[] arr, int index = 0)
        {
            if (arr.Length != index)
            { 
                total += arr[index];
                index++;
                RecursionSum(arr, index);
            }

            return total;
        }
    }
}
