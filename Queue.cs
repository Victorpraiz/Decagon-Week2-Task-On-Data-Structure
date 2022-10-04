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

        public Queue()
        {
            first = last = null;
        }

        public bool isEmpty()
        {
            return first == null;
        }

        public void Enqueue(T item)
        {
            Node<T> newNode = new Node<T>(item);
            count++;

            if (first == null)
            {
                first = last = newNode;
            }
            last.next = newNode;
            last = newNode;
        }


        public T Dequeue()
        {
            if (first == null)
            {
                throw new InvalidOperationException("Queue is empty");
            }
            Node<T> temp = first;
            first = first.next;
            count--;


            if (first == null)
            {
                last = null;
            }
            return temp.data;
        }

        public int Size()
        {
            return count;
        }
    }
}
