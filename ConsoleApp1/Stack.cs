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
            //Use linkedlist to perform operations
            linkedList = new LinkedList();
        }

        public void Push(Node  node)
        {
            //Adding new node in stack 
            linkedList.AddNode(node);
        }

        public void DisplayStack()
        {
            //Display the details of node
            Console.WriteLine("Stack:");
            linkedList.Display();
        }

        public Node Top()
        {
            //Return top value of stack
            return linkedList.head;
        }

        public Node Pop()
        {
            //Delete the node from stack
            return linkedList.Pop();
        }
    }
}
