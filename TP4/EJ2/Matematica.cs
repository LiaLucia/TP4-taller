using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ2
{
    class Matematica
    {
       

        public double Dividir (int pDividendo, int pDivisor)
        {
            if (pDivisor != 0)
            {
                return (pDividendo / pDivisor);
            }
            else
            {
                DivisionPorCeroException Excepcion = new DivisionPorCeroException("No se puede dividir por cero.");
                throw Excepcion;
            }
        }
    }
}
