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

        public static void CrearEvento(string pTitulo, DateTime pFechaInicio, DateTime pFechaFin, TipoFrecuencia pFrecuencia, Calendario pCalendario)
        {
            try
            {
                Evento evento = new Evento(pTitulo, pFechaInicio, pFechaFin, pFrecuencia);

                pCalendario.AgregarEvento(evento);
                
                
            }
            catch (FechaInicioInvalidaException exception)
            {
                Console.WriteLine("Se ha producido una excepcion {0}", exception.Message);
            }
            catch (FechaFinInvalidaException excepcion)
            {
                Console.WriteLine("Se ha producido una excepcion {0}", excepcion.Message);
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
            CrearEvento("MiEvento1", new DateTime(2016 / 12 / 12), new DateTime(2017 / 10 / 10), 0,agenda.Calendario[1]);
            CrearEvento("MiEvento2", new DateTime(2016 / 12 / 12), new DateTime(2017 / 10 /10), 0, agenda.Calendario[1]);
            CrearEvento("MiEvento1", new DateTime(2016 / 12 / 12), new DateTime(2017 / 10 /10), 0, agenda.Calendario[1]);
            CrearEvento("MiEvento2", new DateTime(2016 / 12 / 12), new DateTime(2017 / 10 /10), 0, agenda.Calendario[1]);
           
            /* string b = agenda.Calendario[1].ListarEvento();
             Console.WriteLine(b);
             Console.WriteLine("Ingrese Fecha de inicio y fecha de fin: ");
             DateTime fechaInicio;
             DateTime.TryParse(Console.ReadLine(), out fechaInicio);
             DateTime fechaFin;
             DateTime.TryParse(Console.ReadLine(), out fechaFin);
             eModificarEvento(fechaInicio, fechaFin, agenda.Calendario[1].Evento[0] );

             string c = agenda.Calendario[1].ListarEvento();
             Console.WriteLine(c);
             Console.WriteLine(a); */
            agenda.Calendario[1].FiltrarPor("MiEvento1").ListarEvento();
            Console.ReadLine();

           
            



        }
    }
}
