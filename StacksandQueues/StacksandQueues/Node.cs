using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacksandQueues
{
        public class Node
        {
            // variables
            public int data;
            public Node next;
            /// constructor is used to initialized the data.
            public Node(int data)
            {
                this.data = data;
                this.next = null;
            }
        }
   
}
