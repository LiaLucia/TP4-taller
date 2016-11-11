using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ7
{
   
    class Program
    {
        /// <summary>
        /// Metodo para modificar evento que trata las excepciones que se producen con las fechas del mismo
        /// </summary>
        /// <param name="pFechaInicio">Nueva fecha de inicio del evento</param>
        /// <param name="pFechaFin">Nueva fecha de fin del evento</param>
        /// <param name="pEvento">Evento que se va a modificar</param>
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
        /// <summary>
        /// Metodo para agregar evento que trata las excepciones que se producen con las fechas del mismo
        /// </summary>
        /// <param name="pTitulo">Titulo del evento</param>
        /// <param name="pFechaInicio">Fecha de inicio del evento</param>
        /// <param name="pFechaFin">Fecha de fin del evento</param>
        /// <param name="pFrecuencia">Frecuencia del evento</param>
        /// <param name="pCalendario">Calendario al cual que va a agregar el evento</param>
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
        /// <summary>
        /// Metodo para listar eventos que trata las excepciones que se producen
        /// cuando no se encuentran eventos
        /// </summary>
        /// <param name="pCalendario">Calendario del cual se listaran los eventos</param>
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
        /// <summary>
        /// Metodo para filtrar eventos que trata las excepciones que se 
        /// producen cuando no se encuentran eventos
        /// </summary>
        /// <param name="pTitulo">Titulo para buscar eventos</param>
        /// <param name="pCalendario">Calendario donde se buscan los eventos</param>
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
        /// <summary>
        /// Metodo para filtrar eventos entre dos fechas que trata
        /// las excepciones que se producen cuando las fechas son incorrectas
        /// </summary>
        /// <param name="pFecha1">Primer fecha</param>
        /// <param name="pFecha2">Segunda fecha</param>
        /// <param name="pCalendario">Calendario donde se buscan los eventos</param>
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
        /// <summary>
        /// Metodo listar calendarios que trata las excepciones que se producen
        /// cuando no se encuentran calendarios
        /// </summary>
        /// <param name="pAgenda">Agenda de la que se listan los calendarios</param>
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
