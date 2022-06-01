using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackQueues
{
    class StackList
    {
        public Node top;
        public StackList()
        {
            this.top = null;
        } 
        internal void push(int value)
        {
            Node node = new Node(value);
            if (this.top == null)
            {
                node.next = null;
            }
            else
            {
                node.next = this.top;
            }
            this.top = node;
            Console.WriteLine(" Push value in list " + value);
        }
        internal void Display()
        {
            Node temp = this.top;
            while (temp != null)
            {
                Console.WriteLine("Inserted into the stack Successfully  " + temp.data);
                temp = temp.next;
            }
        }

    }
}
