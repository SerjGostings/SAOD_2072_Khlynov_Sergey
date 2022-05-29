using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Связный_список
{
    public class Node
    {
        public Node Next;
        public MyData Data;
        public Node(MyData mydata)
        {
            Data = mydata;
            Next = null;
        }
        public Node(MyData mydata, Node next)
        {
            Data = mydata;
            Next = next;
        }
        public Node()
        {

        }

    }
}
