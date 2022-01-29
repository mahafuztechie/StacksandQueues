using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacksandQueues
{
    internal class LinkedListQueue
    {
        //variable
        private Node front;
        /// Enqueues the specified value.
        public void Enqueue(int value)
        {
            Node node = new Node(value);
            if (this.front == null)
                this.front = node;
            else
            {
                Node rear = front;
                while (rear.next != null)
                {
                    rear = rear.next;
                }
                rear.next = node;
            }
            Console.WriteLine("{0} Enqueued into Queue", value);
        }
        /// display the elements of Queue.
        public void Display()
        {
            if (front == null)
            {
                Console.WriteLine("Queue is empty");
            }
            else
            {
                Node temp = front;
                while (temp != null)
                {
                    Console.WriteLine("Element in Queue:" + temp.data);
                    temp = temp.next;
                }
            }
        }
    }
}
