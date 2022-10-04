using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure
{
    internal class Node<T>
    {
        public T data;
        public Node<T> next;

        /*Constructor to set Node initial values*/
        public Node(T item)
        {
            data = item;
            next = null;

        }
    }

}
