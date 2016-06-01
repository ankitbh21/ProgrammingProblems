using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Node first = new Node { Value = 1 };
            Node second = new Node { Value = 2 };
            Node third = new Node { Value = 3 };

            first.Next = second;
            second.Next = third;

            PrintList(first);
            Console.ReadLine();
        }

        private static void PrintList(Node node)
        {
            while (node != null)
            {
                Console.WriteLine(node.Value);
                node = node.Next;
            }
        }
    }
}
