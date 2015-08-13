using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pregunta8
{
    class Program
    {
        static bool es_palidromo(String palabra)
        {
            List<char> palabra1 = new List<char>(palabra.ToCharArray());
            List<char> aux = new List<char>();

            for (int i = palabra1.Count - 1; i >= 0; i-- )
            {
                if (palabra1[i] != ' ')
                aux.Add(palabra1[i]);
            }

            int k = 0;
            for(int i = 0; i < palabra1.Count; i++)
            {
                if (palabra1[i] != ' ')
                {
                    if (palabra1[i] != aux[k])
                        return false;
                    k++;
                }
            }
            return true;
                
        }

        static void Main(string[] args)
        {
            String palabra;
            System.Console.WriteLine("******** PREGUNTA 8 ********");

            System.Console.WriteLine("Ingrese una palabra o una frase: ");
            palabra = System.Console.ReadLine();

            if (es_palidromo(palabra))
                System.Console.WriteLine("Es un palindromo");
            else
                System.Console.WriteLine("No es un palindromo");

            System.Console.ReadKey();
        }
    }
}
