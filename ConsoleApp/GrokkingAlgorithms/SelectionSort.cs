namespace ConsoleApp.GrokkingAlgorithms
{
    public class SelectionSort
    {
        /*
        
        2.1 Suppose you’re building an app to keep track of your finances.
            Every day, you write down everything you spent money on. At the
            end of the month, you review your expenses and sum up how much
            you spent. So, you have lots of inserts and a few reads. Should you
            use an array or a list? 
        
        Answer: Linked List.
         
        2.2 Suppose you’re building an app for restaurants to take customer
            orders. Your app needs to store a list of orders. Servers keep adding
            orders to this list, and chefs take orders off the list and make them.
            It’s an order queue: servers add orders to the back of the queue, and
            the chef takes the first order off the queue and cooks it.
            Would you use an array or a linked list to implement this queue?
            (Hint: Linked lists are good for inserts/deletes, and arrays are good
            for random access. Which one are you going to be doing here?) 

        Answer: Linked List.

        2.3 Let’s run a thought experiment. Suppose Facebook keeps a list of
            usernames. When someone tries to log in to Facebook, a search is
            done for their username. If their name is in the list of usernames,
            they can log in. People log in to Facebook pretty often, so there are
            a lot of searches through this list of usernames. Suppose Facebook
            uses binary search to search the list. Binary search needs random
            access—you need to be able to get to the middle of the list of
            usernames instantly. Knowing this, would you implement the list
            as an array or a linked list? 
        Answer: Array.

         */



        public void Sort(int[] arr)
        {
            int minIndex = 0; // bulunan en küçük sayının index bilgisini tutacak değer.
            int foundMinimumValue = 0; // bulunan en küçük değer.

            for (int mainIndex = 0; mainIndex < arr.Length; mainIndex++)
            {
                minIndex = mainIndex;

                for (int remainingIndex = mainIndex + 1; remainingIndex < arr.Length; remainingIndex++)
                {
                    if (arr[remainingIndex] < arr[minIndex])
                    {
                        minIndex = remainingIndex;
                    }
                }

                foundMinimumValue = arr[minIndex];
                arr[minIndex] = arr[mainIndex];
                arr[mainIndex] = foundMinimumValue;
            }

        }
    }
}
