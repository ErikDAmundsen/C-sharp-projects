using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace implementLL
{
    class Node
    {

        private object data;
        private Node next;


        public Node()
        {
            data = null;
            next = null;
        }
        public Node(object o)
        {
            data = o;
            next = null;
        }
        public Node(object o,Node n)
        {
            data = o;
            next = n;
        }

        public void setNextNode(Node n)
        { next = n;
        }
        public Node getNextNode()
        {
            return next;
        }

        public void setData(object o)
        {
            data = o;
        }

        public object getData()
        {
            return data;
        }
    }
}
