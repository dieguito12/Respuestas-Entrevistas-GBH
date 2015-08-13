using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pregunta9;

namespace Pregunta9_App_
{
    class Program
    {
        static void Main(string[] args)
        {
            Strategy ordenador;
            List<int> lista_matriculas = new List<int>();

            lista_matriculas.Add(20125412);
            lista_matriculas.Add(20125037);
            lista_matriculas.Add(20135001);
            lista_matriculas.Add(20105221);
            lista_matriculas.Add(20145534);
            lista_matriculas.Add(20095610);

            LinkedList<int> lista_ordenada;
            LinkedListNode<int> nodo;

            System.Console.WriteLine("******** PREGUNTA 9 ********");

            System.Console.WriteLine("Lista de matriculas:");
            for (int i = 0; i < lista_matriculas.Count; i++)
            {
                System.Console.WriteLine(lista_matriculas[i]);
            }

            System.Console.WriteLine("Orden Ascendente de matriculas: ");
            ordenador = new OrdenadorAscendente();
            lista_ordenada = ordenador.ordenar(lista_matriculas);
            nodo = lista_ordenada.First;
            while (null != nodo)
            {
                System.Console.WriteLine(nodo.Value);
                nodo = nodo.Next;
            }

            System.Console.WriteLine("Orden Descendente de matriculas: ");
            ordenador = new OrdenadorDescendente();
            lista_ordenada = ordenador.ordenar(lista_matriculas);
            nodo = lista_ordenada.First;
            while (null != nodo)
            {
                System.Console.WriteLine(nodo.Value);
                nodo = nodo.Next;
            }

            System.Console.ReadKey();

        }
    }
}
