using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pregunta2
{
    class Program
    {
        static List<int> lista = new List<int>();

        static Dictionary<int, string> secuencia = new Dictionary<int, string>();
        static void sumatoria (int num, List<int> lista)
        {
            int aux = 0;
            for(int i = num; i>0; i--)
            {
                if(secuencia.ContainsKey(i))
                {
                    lista.Add(i);
                    sumatoria(aux, lista);
                    return;
                }
                aux++;
                
            } 
        }

        static String determinar_receta(int num)
        {

            String receta = "La receta es: ";

            secuencia.Add(1,"cafe");
            secuencia.Add(2,"mantequilla");
            secuencia.Add(4,"arroz");
            secuencia.Add(8,"habichuela");
            secuencia.Add(16,"carne");
            secuencia.Add(32,"jugo");
            secuencia.Add(64,"ensalada");


            if (secuencia.ContainsKey(num))
            {
                receta += secuencia[num];
            }
            else
            {
                sumatoria(num, lista);

                for (int i = 0; i < lista.Count; i++)
                {
                    receta += secuencia[lista[i]];
                    if (i + 1 != lista.Count)
                    {
                        receta += " con ";
                    }
                }
            }

            return receta;
            
        }

        static void Main(string[] args)
        {
            Random r = new Random();
            int x = r.Next(1, 256);

            System.Console.WriteLine("******** PREGUNTA 2 ********");

            System.Console.WriteLine("El numero es: " + x);
            System.Console.WriteLine(determinar_receta(x));

            System.Console.ReadKey();

        }
    }
}
