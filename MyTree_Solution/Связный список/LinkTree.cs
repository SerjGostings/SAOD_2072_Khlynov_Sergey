using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Связный_список
{
    class LinkTree
    {
        public LinkTree Left;
        public LinkTree Right;
        public LinkTree Prev;
        public MyData Data;
        public LinkTree(MyData data)
        {
            Data = data;
        }
        public LinkTree()
        {

        }
    }
}
