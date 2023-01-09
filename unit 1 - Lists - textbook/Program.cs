using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unit_1___Lists___textbook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a new LinkedList.
            LinkedList<string> myLinkedlist = new LinkedList<string>();

            // Create a new LinkedListNode of type String
            LinkedListNode<string> lln = new LinkedListNode<string>("Rebekah");

            // Add Rebekah node to the empty linkedlist
            myLinkedlist.AddLast(lln);

            // Add more nodes to the linked list, but specify where ...
            myLinkedlist.AddFirst("Josie");
            myLinkedlist.AddLast("Christopher");
            myLinkedlist.AddFirst("Matthew");

            // display the linked list using a for loop
            Console.WriteLine("We currently have {0} students stored in the list.", myLinkedlist.Count);
            foreach (var student in myLinkedlist)
            {
                Console.WriteLine("Node's data is {0}", student);
            }

            Console.ReadKey();
        }
    }
}
