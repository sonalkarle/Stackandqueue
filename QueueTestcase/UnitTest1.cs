using System;
using System.Collections.Generic;
using System.Text;
using Linkedlist;
using NUnit.Framework;

namespace NUnitTestProject
{
    class QueueUnitTest
    {
        Queue queue;
        [SetUp]
        public void Setup()
        {
            queue = new Queue();
        }
        /// <summary>
        /// TC1: Check enque operation in queue
        /// </summary>
        [Test]
        public void GivenNodes_WhenAddedToQueue_ShouldPassQueueTest()
        {
            Node node1 = new Node(56);
            Node node2 = new Node(30);
            Node node3 = new Node(70);

            queue.Enqueue(node1);
            queue.Enqueue(node2);
            queue.Enqueue(node3);

            Node Top = queue.Top();

            Assert.AreEqual(node1, Top);
        }
        /// <summary>
        /// TC2:Check Denqueu operation in queue
        /// </summary>
        [Test]
        public void GivenNodes_WhenDeqtueued_ShouldPassQueueTest()
        {
            Node node1 = new Node(56);
            Node node2 = new Node(30);
            Node node3 = new Node(70);

            queue.Enqueue(node1);
            queue.Enqueue(node2);
            queue.Enqueue(node3);

            queue.Dequeue();
            Node Top = queue.Dequeue();

            Assert.AreEqual(node2, Top);
        }
    }
}