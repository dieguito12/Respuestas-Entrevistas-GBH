using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pregunta1
{
    class Program
    {
        
        static List<int> load()
        {

            int index = 94843; //Ejemplo
            int x = 455; //Ejemplo
            List<int> secuencia = new List<int>();
            for(int i=0; i<1000000; i++)
            {
                if(i==index)
                {
                    secuencia.Add(x);
                }
                secuencia.Add(i+1);
            }
            return secuencia;
        }

        /**
         * Retorna el numero repetido de una lista de numeros enteros
         **/
        static int num_repetido(List<int> lista)
        {
            List<int> aux = new List<int>();
            aux.Add(lista[0]);
            for(int i = 1; i<lista.Count; i++)
            {
                if (aux.Contains(lista[i]))
                    return lista[i];
                aux.Add(lista[i]);
            }

            return -1;
        }

        static void Main(string[] args)
        {
            List<int> lista = new List<int>(load());
            System.Console.WriteLine("******** PREGUNTA 1 ********");

            /*for (int i = 0; i < lista.Count;i++ )
            {
                System.Console.WriteLine(lista[i]);
            }*/

            System.Console.WriteLine("El numero repetido es:" + num_repetido(lista));
            System.Console.ReadKey();
        }
    }
}
