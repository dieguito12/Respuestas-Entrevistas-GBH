using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pregunta3
{
    class Program
    {
        static List<int> IntegerArray = new List<int>();
        static LinkedList<int> SortedList = new LinkedList<int>();

        static LinkedList<int> sort_list(List<int> lista, LinkedList<int> ordenada)
        {
            if (null == lista || lista.Count == 0)
                return null;
            if(null == ordenada)
                ordenada = new LinkedList<int>();
            if(ordenada.Count==0)
                ordenada.AddFirst(lista[0]);
            for (int i = 1; i < lista.Count; i++ )
            {
                if (lista[i] < ordenada.First.Value)
                {
                    ordenada.AddFirst(lista[i]);
                }
                else
                {
                    LinkedListNode<int> node = ordenada.First;
                    while(null != node)
                    {
                        if(null != node.Next)
                        {
                            if (lista[i] > node.Value)
                            {
                                node = node.Next;
                            }
                            else
                            {
                                ordenada.AddBefore(node, lista[i]);
                                break; 
                            }
                        }
                        else
                        {
                            if (lista[i] > node.Value)
                                ordenada.AddAfter(node, lista[i]);
                            else
                                ordenada.AddBefore(node, lista[i]);
                            break; 
                        }
                        
                    }
                }
                    
            }

            return ordenada;

        }

        static void load_array()
        {
            string linea;

            System.IO.StreamReader file = new System.IO.StreamReader(@"IntegerArray.txt");
            while ( null != (linea = file.ReadLine()))
            {
                IntegerArray.Add(int.Parse(linea));
            }

            file.Close();
        }

        static void Main(string[] args)
        {

            load_array();

            System.Console.WriteLine("******** PREGUNTA 3 ********");

            if(null == sort_list(IntegerArray, SortedList))
            {
                System.Console.WriteLine("La lista esta vacia.");
            }
            else
            {
                System.Console.WriteLine("Lista ordeanada: ");
                LinkedListNode<int> node = SortedList.First;
                while(null!=node)
                {
                    System.Console.WriteLine(node.Value);
                    node = node.Next;
                }
            }
            
            System.Console.ReadKey();
        }
    }
}
