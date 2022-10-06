using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure
{
    internal class Queue<T>
    {
        Node<T> first;
        Node<T> last;
        int count = 0;

        //ctor
        public Queue()
        {
            first = last = null;
        }

        //Check if Quueue is empty
        public bool isEmpty()
        {
            return first == null;
        }

        //Method to add at the end of the list
        public void Enqueue(T item)
        {
            Node<T> newNode = new Node<T>(item);
            count++;

            if (first == null)
            {
                first = last = newNode;
            }
            newNode.next = null;
            var temp = first;
            while (temp.next != null)
            {
                last = temp.next;
            }
            temp.next = newNode;
        }

        //remove from the front of a Queue
        public T Dequeue()
        {
            if (first == null)
            {
                throw new InvalidOperationException("Queue is empty");
            }
            Node<T> temp = first;
            first = first.next;
            count--;


            
            return temp.data;
        }

        //Get the size of the Queue
        public int Size()
        {
            return count;
        }
    }
}
