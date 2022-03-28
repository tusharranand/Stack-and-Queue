using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_and_Queue
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Stack and Queue using Linked List");

            Node node_one = new Node(56);
            Node node_two = new Node(30);
            Node node_three = new Node(70);

            Stack stack = new Stack();
            stack.Push(node_one);
            stack.Push(node_two);
            stack.Push(node_three);
            stack.Display();
        }
    }
}