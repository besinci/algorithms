namespace Algorihms.SortAlgorithms.SelectionSort;

public static class SelectionSort
{
    /// <summary>
    /// Check here for explanation: https://github.com/besinci/algorithms/blob/main/SortAlgorithms/SelectionSort/selection-sort.md
    /// </summary>
    /// <param name="arr"></param>
    /// <returns></returns>
    public static int[] Sort(int[] arr)
    {
        for (int iteration = 0; iteration < arr.Length - 1; iteration++)
        {
            int lowestValueIndex = iteration;
            for (int pointer = iteration + 1; pointer < arr.Length; pointer++)
            {
                if (arr[pointer] < arr[lowestValueIndex])
                    lowestValueIndex = pointer;
            }
            
            // if there is a difference make swap
            if (lowestValueIndex != iteration)
            {
                int tempValue = arr[iteration];
                arr[iteration] = arr[lowestValueIndex];
                arr[lowestValueIndex] = tempValue;
            }
        }
        return arr;
    }
}