using System;
using System.Collections.Generic;
using System.Text;

namespace Linkedlist
{
    public class Stack
    {
        LinkedList linkedList;

        public Stack()
        {
            linkedList = new LinkedList();
        }

        public void Push(Node  node)
        {
            linkedList.AddNode(node);
        }

        public void DisplayStack()
        {
            Console.WriteLine("Stack:");
            linkedList.Display();
        }

        public Node Top()
        {
            return linkedList.head;
        }

        public Node Pop()
        {
            return linkedList.Pop();
        }
    }
}
