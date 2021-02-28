using System;
using System.Collections.Generic;
using System.Text;

namespace Linkedlist
{
    public class LinkedList
    {
        //Create node variables 
        public Node head;
        public Node tail;

        public LinkedList()
        {
            this.head = null;
            this.tail = null;
        }


        public void AddNode(Node node)
        {
            //Check wheather the list is empty then creates node as head
            if (head == null && tail == null)
            {
                head = node;
                tail = node;
            }
            else
            {
                //If node than add new node as head 
                node.next = head;
                head = node;
            }
        }
       



        public void Display()
        {
            //Put head in temp variable and check head is null or not
            Node temp = head;
            if (this.head == null)
            {
                Console.WriteLine("Linked list is empty");

            }
            while (temp != null)
            {
                //Check until head is null so display all the nodes in list
                Console.Write(temp.data + " ");
                if (temp.next != null)
                {
                    Console.Write("->");
                }
                //change temp data for the  next Node
                temp = temp.next;
            }
            Console.WriteLine();


        }
       
        public Node Pop()
        {
            //Put head in temp variable and check head is null or not
            Node temp = head;
            if (head != null)
            {
                //Create new head for next position
                head = head.next;
            }
            //Temp will return for next node
             return temp;
        }
        public void AppendNode(Node node)
        {
            //Check wheather queue is empty or not 
            if (head == null && tail == null)
            {
                //If empty then created not put as head node
                head = node;
                tail = node;
            }
            else
            {
                //Not empty then add new node after head node
                tail.next = node;
                tail = node;
            }
        }
    }
}
