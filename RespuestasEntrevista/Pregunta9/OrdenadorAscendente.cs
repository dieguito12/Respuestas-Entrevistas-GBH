using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pregunta9
{
    /// <summary>
    /// Clase que ordena ascendentemente una lista 
    /// </summary>
    /// <typeparam name="T">Debe ser un objeto comparable</typeparam>
    public class OrdenadorAscendente : Strategy
    {
        public override LinkedList<int> ordenar(List<int> lista)
        {
            LinkedList<int> ordenada = new LinkedList<int>();
            if (null == lista || lista.Count == 0)
                return null;
            if (ordenada.Count == 0)
                ordenada.AddFirst(lista[0]);
            for (int i = 1; i < lista.Count; i++)
            {
                if (lista[i] < ordenada.First.Value)
                {
                    ordenada.AddFirst(lista[i]);
                }
                else
                {
                    LinkedListNode<int> node = ordenada.First;
                    while (null != node)
                    {
                        if (null != node.Next)
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
    }
}
