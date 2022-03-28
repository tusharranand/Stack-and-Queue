using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_and_Queue
{
    public class Stack
    {
        Linked_List linked_list;

        public Stack()
        {
            linked_list = new Linked_List();
        }
        public void Push(Node node)
        {
            linked_list.AddNode(node);
        }
        public void Display()
        {
            linked_list.Display();
        }
    }
}
