using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_and_Queue
{
    public class Queue
    {
        Linked_List linked_list;

        public Queue()
        {
            linked_list = new Linked_List();
        }
        public void Enqueue(Node node)
        {
            linked_list.AppendNode(node);
        }
        public void Display()
        {
            linked_list.Display();
        }
    }
}
