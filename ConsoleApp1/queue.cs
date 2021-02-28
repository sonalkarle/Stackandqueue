using System;
using System.Collections.Generic;
using System.Text;

namespace Linkedlist
{
    public class Queue
    {
        //Use linkedlist to perform operations
        LinkedList linkedList;

        public Queue()
        {
            linkedList = new LinkedList();
        }

        public void Enqueue(Node node)
        {
            //Adding node in  queue
            linkedList.AppendNode(node);
        }

        public void DisplayQueue()
        {
            //Display the nodes in queue
            Console.WriteLine("Queue:");
            linkedList.Display();
        }

        public Node Top()
        {
            //Display the topmost node in queue
            return linkedList.head;
        }
        public Node Dequeue()
        {
            //Delete the node from queue
            return linkedList.Pop();
        }
    }
}