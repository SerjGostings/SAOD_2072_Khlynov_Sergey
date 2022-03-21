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
        public MyList()
        {

        }
        public void Prepend(T value)
        {
            first = new Node<T>(value, null, last);
        }
        public void Append(T value)
        {
            last = new Node<T>(value, first, null);
        }

    }
}
