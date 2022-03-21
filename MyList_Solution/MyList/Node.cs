using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyList
{
    class Node <T>
    {
        Node<T> prev;
        Node<T> next;
        T value;
        public Node(T value, Node<T> prev, Node<T> next)
        {
            this.prev = prev;
            this.next = next;
            this.value = value;
        }
    }
}
