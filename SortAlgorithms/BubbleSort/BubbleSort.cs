namespace Algorihms.SortAlgorithms.BubbleSort;

public static class BubbleSort
{
    /// <summary>
    /// Check here for explanation: https://github.com/besinci/algorithms/blob/main/SortAlgorithms/BubbleSort/bubble-sort.md
    /// </summary>
    /// <param name="arr">Given array.</param>
    /// <returns>Ordered Array</returns>
    public static int[] Sort(int[] arr)
    {
        bool swapped;
        for (int iterationIndex = 0; iterationIndex < arr.Length - 1; iterationIndex++)
        {
            swapped = false;
            for (int pointerIndex = 0; pointerIndex < arr.Length - iterationIndex - 1; pointerIndex++)
            {
                if (arr[pointerIndex] > arr[pointerIndex + 1])
                {
                    // swap
                    int tempElement = arr[pointerIndex];
                    arr[pointerIndex] = arr[pointerIndex + 1];
                    arr[pointerIndex + 1] = tempElement;
                    swapped = true;
                }
            }

            if (swapped == false)
                break;
        }

        return arr;
    }
}