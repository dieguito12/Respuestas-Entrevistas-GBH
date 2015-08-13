using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pregunta7
{
    class Program
    {
        /// <summary>
        /// Metodo para una lista doblemente enlazada hecha desde 0 (donde si puede ser ciclica)
        /// </summary>
        static bool is_cyclic2(ListaDoblementeEnlazada lista)
        {
            Nodo nodo = lista.Prim;
            while (null != nodo)
            {
                if (nodo.Siguiente == nodo)
                    return true;
                Nodo aux_node = lista.Prim;
                while (null != aux_node && aux_node != nodo)
                {
                    if (nodo.Siguiente == aux_node)
                        return true;
                    aux_node = aux_node.Siguiente;
                }
                nodo = nodo.Siguiente;
            }
            return false;
        }

        /// <summary>
        /// Metodo para la clase LinkedList de C# que representa una lista doblemente enlazada pero donde nunca puede ser ciclica.
        /// </summary>
        static bool is_cyclic(LinkedList<int> lista)
        {
            LinkedListNode<int> nodo = lista.First;
            while(null != nodo)
            {
                if (nodo.Next == nodo)
                    return true;
                LinkedListNode<int> aux_node = lista.First;
                while(null != aux_node && aux_node != nodo)
                {
                    if (nodo.Next == aux_node)
                        return true;
                    aux_node = aux_node.Next;
                }
                nodo = nodo.Next;
            }
            return false;
        }

        static void Main(string[] args)
        {
            ListaDoblementeEnlazada l = new ListaDoblementeEnlazada();
            l.Prim = new Nodo(1);
            l.Prim.Siguiente = new Nodo(4);
            l.Prim.Siguiente.Siguiente = new Nodo(6);
            l.Prim.Siguiente.Siguiente.Siguiente = l.Prim;
            LinkedList<int> lista = new LinkedList<int>();

            lista.AddFirst(37);
            lista.AddFirst(99);
            lista.AddFirst(12);
            lista.AddFirst(37);
            lista.AddFirst(99);
            lista.AddFirst(12);
            lista.AddFirst(37);
            lista.AddFirst(99);
            lista.AddFirst(12);

            System.Console.WriteLine("******** PREGUNTA 7 ********");


            System.Console.WriteLine("Lista: ");
            LinkedListNode<int> node = lista.First;
            while (null != node)
            {
                System.Console.WriteLine(node.Value);
                node = node.Next;
            }

            if (is_cyclic(lista))
                System.Console.WriteLine("Es ciclica!");
            else
                System.Console.WriteLine("No es ciclica!");

            System.Console.WriteLine("Lista2: ");
            Nodo nodo = l.Prim;

            /*while (null != nodo)
            {
                System.Console.WriteLine(nodo.Valor);
                nodo = nodo.Siguiente;
            }*/

            if (is_cyclic2(l))
                System.Console.WriteLine("Es ciclica!");
            else
                System.Console.WriteLine("No es ciclica!");
            System.Console.ReadKey();

            
        }
    }
}
