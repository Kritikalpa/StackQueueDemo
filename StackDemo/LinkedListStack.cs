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

        internal void Peek()
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack is empty");
                return;
            }
            Console.WriteLine("\n{0} is in the top of stack", this.top.data);
        }

        internal void Pop()
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack is empty. Deletion is not possible");
                return;
            }
            Console.WriteLine("Value poped is {0}", this.top.data);
            this.top = this.top.next;
        }

        internal void isEmpty()
        {
            while (this.top != null)
            {
                Peek();
                Pop();
            }
        }
    }
}
