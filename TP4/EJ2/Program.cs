using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ2
{
    class Program
    {/// <summary>
    /// Metodo que divide dos elementos y que trata la excepcion que se produce cuando
    /// el divisor es igual a cero
    /// </summary>
    /// <param name="dividendo">Dividendo</param>
    /// <param name="divisor">Divisor</param>
        public static void aDividir(int dividendo, int divisor)
        {
            Division Division = new Division();
            try
            {
                Console.WriteLine(Division.Dividiendo(dividendo, divisor));


            }
            catch (DivisionPorCeroException excepcion)
            {
             
                
                Console.WriteLine("Se ha producido una excepcion {0}", excepcion.Message);
                Console.WriteLine("CallStack {0} ", excepcion.StackTrace);
            }

        }
        static void Main(string[] args)
        
        {

            Console.WriteLine("Ingrese el dividendo: ");
            int dividendo;
            int.TryParse(Console.ReadLine(), out dividendo);
            Console.WriteLine("Ingrese el divisor: ");
            int divisor;
            int.TryParse(Console.ReadLine(), out divisor);

            aDividir(dividendo, divisor);
            
            Console.ReadLine();


        }
      
    }
}
