using System;

namespace Linkedlist
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Welcome to stack operation");
            ///<summary>
            ///UC1:Added node in the stack
            /// </summary>
            Stack stack = new Stack();
            Node node1 = new Node(70);
            Node node2 = new Node(30);
            Node node3 = new Node(56);

            stack.Push(node1);
            stack.Push(node2);
            stack.Push(node3);

            stack.DisplayStack();
            stack.Top();
            
            

           

        }
    }
}
