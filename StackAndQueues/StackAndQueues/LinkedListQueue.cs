using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueues
{
    internal class LinkedListQueue
    {
        Node head = null;
        internal void Enqueue(int data) //use of Enqueue for adding elements in Queue like we used Push in stack 
        {
            Node node = new Node(data);
            if (head == null)
            {
                head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} inserted into Queue", node.data);
        }
        internal void Display() // method for displaying 
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Queue is empty");
                return;
            }
            while (temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
            }


        }
        internal void Dequeue(int data)//use of Dequeue to delete element in Queue like we used Pop in Stacks 
        {
            if (this.head == null)
            {
                Console.WriteLine("Queue is Empty");
            }
            Node temp = this.head;
            this.head = this.head.next;
            if (this.head == null)
            {
                this.head = null;
            }
            Console.WriteLine("Item Delete is {0}", temp.data);
        }

    }
}
