using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ7
{
   
    class Program
    {
        public static void eModificarEvento(DateTime pFechaInicio, DateTime pFechaFin, Evento pEvento)
        {
            try
            {
                pEvento.ModificarEvento(pFechaInicio, pFechaFin);
            }
            catch (FechaInicioInvalidaException exception)
            {
                Console.WriteLine("Se ha producido una excepcion {0}", exception.Message);
            }
            catch (FechaFinInvalidaException exception)
            {
                Console.WriteLine("Se ha producido una excepcion {0}", exception.Message);
            }
        }

        public static void aAgregarEvento(string pTitulo, DateTime pFechaInicio, DateTime pFechaFin, TipoFrecuencia pFrecuencia, Calendario pCalendario)
        {
            
            try
            {
                
                pCalendario.AgregarEvento(pTitulo, pFechaInicio, pFechaFin,pFrecuencia);



            }
            catch (FechaFinInvalidaException excepcion)
            {
                Console.WriteLine("Se ha producido una excepcion {0}", excepcion.Message);
            }
            catch (FechaInicioInvalidaException exception)
            {
                Console.WriteLine("Se ha producido una excepcion {0}", exception.Message);
            }
           
        }


        static void Main(string[] args)
        {
            Agenda agenda = new Agenda();
            agenda.AgregarCalendario("MiCalendario1");
            agenda.AgregarCalendario("MiCalendario2");
            agenda.AgregarCalendario("MiCalendario3");
            agenda.AgregarCalendario("MiCalendario4");
            string a = agenda.ListarCalendario();
            Console.WriteLine("ingrese la fecha de fin del evento");
            DateTime result;
            DateTime.TryParse(Console.ReadLine() , out result);
            Console.WriteLine(result);
            aAgregarEvento("miEvento", new DateTime(2016,12,11), result,TipoFrecuencia.UnaPorAño, agenda.Calendario[1]);            
           
            /* string b = agenda.Calendario[1].ListarEvento();
             Console.WriteLine(b);
             Console.WriteLine("Ingrese Fecha de inicio y fecha de fin: ");
             DateTime fechaInicio;
             DateTime.TryParse(Console.ReadLine(), out fechaInicio);
             DateTime fechaFin;
             DateTime.TryParse(Console.ReadLine(), out fechaFin);
             eModificarEvento(fechaInicio, fechaFin, agenda.Calendario[1].Evento[0] );*/

             string c = agenda.Calendario[1].ListarEvento();
             Console.WriteLine(c);
            // Console.WriteLine(a); */
           // agenda.Calendario[1].ListarEvento();
            Console.ReadLine();

           
            



        }

        
    }
}
