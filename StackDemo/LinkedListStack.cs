using System;
using System.Collections.Generic;
using System.Text;

namespace StackDemo
{
    public class LinkedListStack
    {
        private Node top;
        public LinkedListStack()
        {
            this.top = null;
        }

        internal void Push(int value)
        {
            Node node = new Node(value);
            if(this.top == null)
            {
                node.next = null;
            }
            else
            {
                node.next = this.top;
            }
            this.top = node;
            Console.WriteLine("{0} pushed to stack", node.data);
        }

        internal void Display()
        {
            Node temp = this.top;
            while(temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }
    }
}
