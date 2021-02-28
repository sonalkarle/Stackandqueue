using System;
using System.Collections.Generic;
using System.Text;

namespace Linkedlist
{
    public class LinkedList
    {
        public Node head;
        public Node tail;

        public LinkedList()
        {
            this.head = null;
            this.tail = null;
        }


        public void AddNode(Node node)
        {
            if (head == null && tail == null)
            {
                head = node;
                tail = node;
            }
            else
            {
                node.next = head;
                head = node;
            }
        }
       



        public void Display()
        {
            Node temp = head;
            if (this.head == null)
            {
                Console.WriteLine("Linked list is empty");

            }
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                if (temp.next != null)
                {
                    Console.Write("->");
                }
                temp = temp.next;
            }
            Console.WriteLine();


        }
       
        public Node Pop()
        {
            Node temp = head;
            if (head != null)
            {
                head = head.next;
            }
            return temp;
        }
        public void AppendNode(Node node)
        {
            if (head == null && tail == null)
            {
                head = node;
                tail = node;
            }
            else
            {
                tail.next = node;
                tail = node;
            }
        }
    }
}
