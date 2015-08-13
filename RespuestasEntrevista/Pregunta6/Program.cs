using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pregunta6
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> lista = new LinkedList<int>();

            lista.AddFirst(37);
            lista.AddFirst(99);
            lista.AddFirst(12);

            System.Console.WriteLine("******** PREGUNTA 6 ********");

            
            System.Console.WriteLine("Lista: ");
            LinkedListNode<int> node = lista.First;
            while (null != node)
            {
                System.Console.WriteLine(node.Value);
                node = node.Next;
            }
            System.Console.ReadKey();
        }
    }
}
