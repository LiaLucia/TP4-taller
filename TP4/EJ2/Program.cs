using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ2
{
    class Program
    {
        static void Main(string[] args)
        {
            Division Division = new Division();
            Console.WriteLine("Ingrese el dividendo: ");
            int dividendo;
            int.TryParse(Console.ReadLine(), out dividendo);
            Console.WriteLine("Ingrese el divisor: ");
            int divisor;
            int.TryParse(Console.ReadLine(), out divisor);
            Division.aDividir(dividendo, divisor);
            Console.ReadLine();

              
        }
    }
}
