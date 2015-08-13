using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pregunta7
{
    public class ListaDoblementeEnlazada
    {
        Nodo prim;

        public Nodo Prim
        {
            get { return prim; }
            set { prim = value; }
        }

        int count;

        public int Count
        {
            get { return count; }
        }

        public ListaDoblementeEnlazada()
        {
            Prim = null;
            count = 0;
        }

        public Nodo addFirst(Nodo n)
        {
            Prim = n;
            Prim.Anterior = null;
            Prim.Siguiente = null;
            return Prim;
        }

        public Nodo addAfter(Nodo viejo, Nodo nuevo)
        {
            return null;
        }
    }

    public class Nodo
    {
        int valor;

        public int Valor
        {
            get { return valor; }
            set { valor = value; }
        }

        Nodo anterior;

        public Nodo Anterior
        {
            get { return anterior; }
            set { anterior = value; }
        }
        Nodo siguiente;

        public Nodo Siguiente
        {
            get { return siguiente; }
            set { siguiente = value; }
        }

        public Nodo(int x)
        {
            Valor = x;
            Anterior = null;
            Siguiente = null;
        }
    }
}
