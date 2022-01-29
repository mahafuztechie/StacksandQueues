﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacksandQueues
{
    public class LinkedListStack
    {
        public Node top;
        /// add element into stack.
        public void Push(int value)
        {
            Node node = new Node(value);
            if (this.top == null)
                node.next = this.top;
            else
                node.next = this.top;
            this.top = node;
            Console.WriteLine("{0} pushed to stack", value);
        }
        /// display the stack elements.
        public void Display()
        {
            Node temp = this.top;
            if (top == null)
            {
                Console.WriteLine("Stack is empty");
            }
            while (temp != null)
            {
                Console.WriteLine("Data in Stack :" + temp.data);
                temp = temp.next;
            }
        }
        //method to find top element of stack
        public void Peek()
        {
            if (top == null)
            {
                Console.WriteLine("Stack is empty");
                return;
            }
            Console.WriteLine("{0} is Peek element of Stack", top.data);
        }
        /// remove the top element from stack.
        public void Pop()
        {
            Peek();
            int deleteNode = this.top.data;
            this.top = top.next;
            Console.WriteLine("{0} Poped from stack", deleteNode);
        }
        /// It will poped out all the elements from stack untill stack is empty.
        public void IsEmpty()
        {
            if (top == null)
            {
                Console.WriteLine("Stack is empty");
                return;
            }
            while (top != null)
            {
                Pop();
            }
            Console.WriteLine("All element Poped from Stack!");
        }
    }
}
