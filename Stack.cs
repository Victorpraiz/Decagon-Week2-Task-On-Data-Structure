using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure
{
    internal class Stack<T>
    {
        Node<T> top;
        int count = 0;

        public Stack()
        {
            top = null;
        }
        

        //check if Stack is empty
        public bool IsEmpty()
        {
            return top == null;
        }


        //push an item to top of stack
        public void Push(T item)
        {
            Node<T> newNode = new Node<T>(item);
            count++;
            if (IsEmpty())
            {
                top = newNode;
               
            }

            newNode.next = top;
            top = newNode;
            
        }


        //Remove an item from top of list and return the value of the item

        public T Pop()
        {
            Node<T> temp = top;
            top = temp.next;
            
            return temp.data;
            count--;
        }

        //Check if an item exists in the Stack
        public T Peek() { return top.data; }


        public int Size()
        {
            return count;
        }

        public void PrintStack()
        {
            Node<T> temp = top;
            while (temp.next != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;

            }

        }

    }
}
