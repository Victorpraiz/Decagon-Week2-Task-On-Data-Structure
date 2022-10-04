using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Data_Structure
{
    public class LinkedList<T>
    {
        /*declare head and tail variables*/
        Node<T> head; 
        Node<T> tail;
        int count = 0;

        /*New method to add item to the end of the linkedlist*/
        public int Add(T item)
        {
            count++;
            Node<T> newNode = new Node<T>(item);

            if (head == null)
            {
                head = newNode;
                return count;
            }

            newNode.next = null;
            tail = head;
            while (tail.next != null)
            {
                tail = tail.next;
            }
            tail.next = newNode;
            
            return count;
        }


        /*Method to find and remove an item from the linkedList and return true
        if found or false if not found*/
        public bool Remove(T item)
        {
            if (head == null)
            {
                return false;
            }

            Node<T> temp = head;

            while (temp.next != null)
            {
                if (temp.next.data.Equals(item))
                {
                    temp.next = temp.next.next;
                    
                    count--;

                    return true;

                }
                temp = temp.next;

            }
            return false;

        }


        /*Method to check if an item exists in the list*/
        public bool Check(T item)
        {
            Node<T> temp = head;

            while (temp != null)
            {
                if (temp.data.Equals(item))
                {
                    return true;
                      
                }
                temp = temp.next;

            }
            return false;
        }

        /*Method to find and return the index of an item*/
        public int Index(T item)
        {
            int index = 0;
            Node<T> temp = head;
            
            while (temp != null)
            {
                if (temp.data.Equals(item))
                {
                    return index;
                }
                temp = temp.next;
                index++;
            }
            return -1;
        }


        /*Method to print nodes data of a linkedlist*/
        public void PrintList()
        {
            Node<T> temp = head;
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }

        public int Count()
        {
            return count;
        }

    }
}
