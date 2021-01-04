using System.Collections.Generic;

namespace ConsoleApp.FromTheBook
{
    /// <summary>
    /// Implements Linked Lists questions from the book.
    /// </summary>
    public class LinkedLists
    {
        /// <summary>
        /// Write code to remove duplicates from an unsorted linked list.
        /// FOLLOW UP
        /// How would you solve this problem if a temporary buffer is not allowed?
        /// </summary>
        /// <param name="unsortedList"></param>
        public void RemoveDuplicates(LinkedList<int> unsortedList)
        {
        }

        /// <summary>
        /// Implement an algorithm to delete a node in the middle of a singly linked list,
        /// given only access to that node.
        /// EXAMPLE 
        /// Input: the node c from the linked list a -> b -> c -> d -> e
        /// Result: nothing is returned, but the new linked list looks like a-> b -> d -> e
        /// </summary>
        /// <param name="node"></param>
        /// <param name="list"></param>
        public void DeleteMiddleNode(LinkedListNode<char> node, LinkedList<char> list)
        {
            FindNode(node, list);
        }

        private void FindNode(LinkedListNode<char> node, LinkedList<char> list)
        {
        }
    }
}
