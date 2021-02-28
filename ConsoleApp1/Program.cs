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
            
            

            ///<summary>
            ///UC2: Delete the Node from the stcak
            /// </summary>

            stack.Pop();
            stack.Pop();
            stack.Pop();
            stack.DisplayStack();
           
            
            ///<summary>
            ///UC3: Check enqueue operation in queue
            /// </summary>
            Queue queue = new Queue();
            Node nodeA = new Node(56);
            Node nodeB = new Node(30);
            Node nodeC = new Node(70);

            queue.Enqueue(nodeA);
            queue.Enqueue(nodeB);
            queue.Enqueue(nodeC);
            queue.DisplayQueue();
            queue.Top();
         

            
            ///<summary>
            ///TC4: Check denqueu operation queue
            /// </summary>
            queue.Dequeue();
            queue.DisplayQueue();
           




        }
    }
}
