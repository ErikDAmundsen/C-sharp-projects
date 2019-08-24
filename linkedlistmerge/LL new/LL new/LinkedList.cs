using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LL_new
{
   public class LinkedList
    {

        private Node head;
        private int count;

        public LinkedList()
        {
            this.head = null;
            this.count = 0;
        }
        public bool empty
        {
            get { return this.count == 0; }
        }

        public int Count
        {
            get { return this.count; }
        }

        public object Add( int index, object o)

        {
            if (index< 0)
            {
                throw new ArgumentOutOfRangeException("Index: " + index);
               

            }
            if (index > count)
                index = count;

            Node current = this.head;

            if(this.empty || index==0)
            {
                this.head = new Node(o, this.head);
            }
            else
            {
                for (int i = 0; i<index-1; i++)
                {
                    current = current.Next;
                }
                current.Next = new Node(o, current.Next);
            }
            count++;
            return o;
        }

        public object Add(object o)
        {
            return this.Add(count, o);
        }




    }
}
