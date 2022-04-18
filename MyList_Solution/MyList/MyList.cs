using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyList
{
    class MyList<T>
    {
        Node<T> last;
        Node<T> first;
        int count;
        public MyList()
        {
            first = null;
            last = null;
            count = 0;
        }
        public void Prepend(T value)
        {
            if (count == 0)
            {
                first = new Node<T>(value, null, null);
                last = first;
                count++;
            }
            else
            {
                Node<T> node = new Node<T>(value, null, first);
                first.prev = node;
                first = node;
                count++;
            }
            
        }
        public void Append(T value)
        {
            if (count == 0)
            {
                last = new Node<T>(value, null, null);
                first = last;
                count++;
            }
            else
            {
                Node<T> node = new Node<T>(value, first, null);
                last.next = node;
                last = node;
                count++;
            }
        }

    }
}
