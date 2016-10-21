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
        
        public void aDividir(int pDividendo, int pDivisor)
        {
            try
            {
               Console.WriteLine(Matematica.Dividir(pDividendo, pDivisor));
                
                
            }
            catch(DivisionPorCeroException excepcion)
            {
                Console.WriteLine("Se ha producido una excepcion {0}", excepcion.Message);
                Console.WriteLine("CallStack {0} ", excepcion.StackTrace);
            }
          
        }
        
  
    }
}
