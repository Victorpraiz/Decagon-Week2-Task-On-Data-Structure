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
        
        public bool IsEmpty()
        {
            return top == null;
        }


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


        public T Pop()
        {
            Node<T> temp = top;
            top = temp.next;
            temp = null;
            return top.data;
            count--;
        }

        public T Peek() { return top.data; }


        public int Size()
        {
            return count;
        }

        public void PrintStack()
        {
            Node<T> temp = top;
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;

            }

        }

    }
}
