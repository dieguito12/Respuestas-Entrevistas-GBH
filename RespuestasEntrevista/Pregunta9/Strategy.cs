using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pregunta9
{
    /// <summary>
    /// Clase abstracta que define la estrategia para ordenar
    /// </summary>
    /// <typeparam name="T">Debe ser un objeto comparable</typeparam>
    public abstract class Strategy
    {
        public abstract LinkedList<int> ordenar(List<int> lista);
    }
}
