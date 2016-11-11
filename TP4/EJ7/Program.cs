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

        public static void eAgregarEvento(string pTitulo, DateTime pFechaInicio, DateTime pFechaFin, TipoFrecuencia pFrecuencia, Calendario pCalendario)
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

        public static void elistarEventos(Calendario pCalendario)
        {
            try
            {
                pCalendario.ListarEvento();
            }
            catch (CalendarioVacioException excepcion)
            {
                Console.WriteLine("Se ha producido una exception {0}",excepcion.Message);
            }
        }

        public static void eFiltrarPor(string pTitulo, Calendario pCalendario)
        {
            try
            {
                pCalendario.FiltrarPor(pTitulo);
            }
            catch (CalendarioVacioException excepcion)
            {
                Console.WriteLine("Se ha producido una exception {0}", excepcion.Message);
            }
        }

        public static void eFiltrarPor(DateTime pFecha1, DateTime pFecha2, Calendario pCalendario)
        {
            try
            {
                pCalendario.FiltrarPor(pFecha1,pFecha2);
            }
            catch (CalendarioVacioException excepcion)
            {
                Console.WriteLine("Se ha producido una exception {0}", excepcion.Message);
            }
        }
        public static void elistarCalendarios(Agenda pAgenda)
        {
            try
            {
                pAgenda.ListarCalendario();
            }
            catch (AgendaVaciaException excepcion)
            {
                Console.WriteLine("Se ha producido una exception {0}", excepcion.Message);
            }
        }

        static void Main(string[] args)
        {
            
           
        }

        
    }
}
