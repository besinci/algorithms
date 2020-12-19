namespace ConsoleApp.Other
{
    /// <summary>
    /// Basic implementation of LinkedList class.
    /// </summary>
    /// <typeparam name="T">Type of the data LinkedList will have.</typeparam>
    public class MyLinkedList<T>
    {
        MyNode<T> HeadNode;

        public MyLinkedList()
        {
            HeadNode = null;
        }

        /// <summary>
        /// Add node to beginning of linked list.
        /// </summary>
        /// <param name="data">value to be added.</param>
        public void AddToBeginning(T data)
        {
            if (HeadNode == null)
            {
                HeadNode = new MyNode<T>(data);
            }
            else
            {
                MyNode<T> tempNode = new MyNode<T>(data);
                tempNode.Next = HeadNode;
                HeadNode = tempNode;
            }
        }

        /// <summary>
        /// Add node to end of linked list.
        /// </summary>
        /// <param name="data">value to be added.</param>
        public void AddToEnd(T data)
        {
            if (HeadNode == null)
            {
                HeadNode = new MyNode<T>(data);
            }
            else
            {
                HeadNode.Next.AddToEnd(data);
            }
        }
    }

    public class MyNode<T>
    {
        public T Data { get; set; }
        public MyNode<T> Next { get; set; }

        public MyNode(T data)
        {
            Data = data;
            Next = null;
        }

        public void AddToEnd(T value)
        {
            if (Next == null)
            {
                Next = new MyNode<T>(value);
            }
            else
            {
                Next.AddToEnd(value);
            }
        }
    }
}
