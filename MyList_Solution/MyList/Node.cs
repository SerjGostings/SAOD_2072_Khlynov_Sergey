using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyList
{
    class Node <T>
    {
        public Node<T> prev;
        public Node<T> next;
        T value;
        public Node(T value, Node<T> prevN, Node<T> nextN)
        {
            this.prev = prevN;
            this.next = nextN;
            this.value = value;
        }
    }
}
