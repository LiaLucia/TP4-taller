using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ2
{/// <summary>
/// Fachada del programa
/// </summary>
    class Division
    {
        Matematica Matematica = new Matematica();
        /// <summary>
        /// Metodo que devuelve el resultado de una division
        /// </summary>
        /// <param name="pDividendo">Dividendo</param>
        /// <param name="pDivisor">Divisor</param>
        /// <returns></returns>
        public double Dividiendo(int pDividendo, int pDivisor)
        {
            return Matematica.Dividir(pDividendo, pDivisor);
        }
       
  
    }
}
