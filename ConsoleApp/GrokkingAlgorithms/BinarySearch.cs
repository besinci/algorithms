namespace ConsoleApp.GrokkingAlgorithms
{
    public class BinarySearch
    {
        /// <summary>
        /// BinarySearch
        /// </summary>
        /// <param name="arr">1,2,3,4,5,6,7,8,9</param>
        /// <param name="search">8</param>
        /// <returns>index of found element</returns>
        public int Search(int[] arr, int search)
        {
            int lowPoint = 0;
            int highPoint = arr.Length - 1;
            while (lowPoint < highPoint)
            {
                int midPoint = (lowPoint + highPoint) / 2;

                if (arr[midPoint] == search)
                {
                    return midPoint;
                }

                if (arr[midPoint] > search)
                {
                    highPoint = midPoint - 1;
                }

                if (arr[midPoint] < search)
                {
                    lowPoint = midPoint + 1;
                }
            }
            return 0;
        }
 
        /*

        1.1 Suppose you have a sorted list of 128 names, and you’re searching
            through it using binary search. What’s the maximum number of
            steps it would take?
        Answer: 7

        1.2 Suppose you double the size of the list. What’s the maximum number of steps now?       
        Answer: 8

        1.3 You have a name, and you want to find the person’s phone number in the phone book.
        Answer: O(log n)

        1.4 You have a phone number, and you want to find the person’s name in the phone book. 
        Answer: O(n)

        1.5 You want to read the numbers of every person in the phone book.
        Answer: O(n)

        1.6 You want to read the numbers of just the As. 
        Answer: O(n)

        */
    }
}
