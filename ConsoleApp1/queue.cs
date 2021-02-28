using System;
using System.Collections.Generic;
using System.Text;

namespace Linkedlist
{
    public class Queue
    {
        LinkedList linkedList;

        public Queue()
        {
            linkedList = new LinkedList();
        }

        public void Enqueue(Node node)
        {
            linkedList.AppendNode(node);
        }

        public void DisplayQueue()
        {
            Console.WriteLine("Queue:");
            linkedList.Display();
        }

        public Node Top()
        {
            return linkedList.head;
        }
        public Node Dequeue()
        {
            return linkedList.Pop();
        }
    }
}