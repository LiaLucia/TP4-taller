using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ2
{
    class Division
    {
        Matematica Matematica = new Matematica();

        public double Dividiendo(int pDividendo, int pDivisor)
        {
            return Matematica.Dividir(pDividendo, pDivisor);
        }
       
  
    }
}
