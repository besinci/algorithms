namespace Algorithms.SearchAlgorithms;

public static class BinarySearch
{
    /// <summary>
    /// In example:
    /// Given ordered array like: [1,2,3,4,5,6,7,8,9,10]
    /// We are looking to find 7.
    /// #Iteration: take middle index of the array and check is it the number we are looking for,
    /// if yes return index.
    /// if it's greater we must take right side of the array,
    /// if it's smaller we must take left side of the array,
    /// and repeat the iteration.
    /// </summary>
    /// <param name="arr">Given array, MUST BE ORDERED ARRAY.</param>
    /// <param name="number">Number we are looking to find.</param>
    /// <returns>Return index of the found element. If not returns -1</returns>
    public static int Search(int[] arr, int number)
    {
        int startIndex = 0;
        int endIndex = arr.Length - 1;
        
        while (startIndex <= endIndex)
        {
            int middle = startIndex + (endIndex - startIndex) / 2;

            // if number is present at the middle
            if (arr[middle] == number)
                return middle;

            // if the number is bigger than middle number
            if (arr[middle] < number)
            {
                // so, ignore left side and take right side of the array.
                startIndex = middle + 1;
            }
            else // if the number is smaller than middle number
            {
                // so, ignore right side and take left side of the array.
                endIndex = middle - 1;
            }
        }

        // not present.
        return -1;
    }
}