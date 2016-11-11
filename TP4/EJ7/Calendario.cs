using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ7
{
    class Calendario
    {
        List<Evento> iListaEvento;
        String iTitulo;
        DateTime iFechaCreacion;
        /// <summary>
        /// Constructor de la clase Calendario
        /// </summary>
        /// <param name="pTitulo">Titulo del calendario</param>
        public Calendario(String pTitulo)
        {
            iListaEvento = new List<Evento>();
            iFechaCreacion = DateTime.Now;
            iTitulo = pTitulo;
        }
        /// <summary>
        /// Propiedad del atributo Titulo del calendario
        /// </summary>
        public string Titulo
        {
            get { return this.iTitulo; }
            set { this.iTitulo = value; }
        }
        /// <summary>
        /// Propiedad del atributo FechaCreacion del calendario
        /// </summary>
        public DateTime FechaCreacion
        {
            get { return this.iFechaCreacion; }
            set { this.iFechaCreacion = value; }
        }
        /// <summary>
        /// Accesor a la lista de eventos
        /// </summary>
        public List<Evento> Evento
        {
            get { return this.iListaEvento; }
        }

        /// <summary>
        /// Metodo para agregar un evento a la lista
        /// </summary>
        /// <param name="pTitulo">Titulo del evento</param>
        /// <param name="pFechaInicio">Fecha de inicio del evento</param>
        /// <param name="pFechaFin">Fecha de fin del evento</param>
        /// <param name="pFrecuencia">Frecuencia del evento</param>
        public void AgregarEvento(string pTitulo, DateTime pFechaInicio, DateTime pFechaFin, TipoFrecuencia pFrecuencia)
        {
            if (pFechaFin < pFechaInicio)
            {
                FechaFinInvalidaException Exception = new FechaFinInvalidaException("La Fecha de Fin de evento ingresada es inválida");
                throw Exception;
            }
            else if(pFechaInicio < DateTime.Today) 
            {
                FechaInicioInvalidaException Excepcion = new FechaInicioInvalidaException("La Fecha de Inicio de evento ingresada es inválida");
                throw Excepcion;
            }
        
            else
            {
                Evento evento = new Evento(pTitulo, pFechaInicio, pFechaFin, pFrecuencia);
                this.Evento.Add(evento);
            }
        
        }
            
        /// <summary>
        /// Metodo para eliminar un evento de la lista
        /// </summary>
        /// <param name="pEvento">Evento a eliminar</param>
        public void EliminarEvento(Evento pEvento) 
        {
            this.Evento.Remove(pEvento);

        }
        /// <summary>
        /// Metodo para modificar el titulo de un calendario
        /// </summary>
        /// <param name="pTitulo">Titulo del calendario a eliminar</param>
        public void ModificarCalendario(string pTitulo)
        {
            this.iTitulo = pTitulo;
            
        }
        /// <summary>
        /// Metodo para listar eventos que se encuentran en la lista
        /// </summary>
        /// <returns>Devuelve los titulos de los eventos</returns>
        public string ListarEvento()
        {
            string variable = "- ";
            if (this.Evento.Count == 0)
            {
                CalendarioVacioException Excepcion = new CalendarioVacioException("El calendario seleccionado se encuentra vacío");
                throw Excepcion;

            }
            else
            {
                foreach (Evento elemento in this.Evento)
                {
                    variable = variable + elemento.Titulo + " - ";

                }
            }
            return variable;
        }
        /// <summary>
        /// Metodo para filtrar eventos por su titulo
        /// </summary>
        /// <param name="pTituloEvento">Titulo por el cual se desea buscar eventos</param>
        /// <returns> Devuelve una lista de eventos con el titulo pTituloEvento </returns>
        public Calendario FiltrarPor(string pTituloEvento)
        {
            Calendario eventos = new Calendario(pTituloEvento);
            foreach (Evento elemento in this.Evento)
            {
                if (elemento.Titulo == pTituloEvento)
                {
                    eventos.AgregarEvento(elemento.Titulo, elemento.FechaInicio, elemento.FechaFin, elemento.Frecuencia);
                }
            }
            if (eventos.Evento.Count==0)
            {
                CalendarioVacioException Excepcion = new CalendarioVacioException("No se han encontrado eventos");
                throw Excepcion;
            }
            return eventos;
        }


        /// <summary>
        /// Metodo para filtrar eventos entre la primer fecha y la segunda fecha
        /// </summary>
        /// <param name="pFecha1">Primer fecha </param>
        /// <param name="pFecha2">Segunda Fecha</param>
        /// <returns>Devuelve una lista de los eventos que cumplan la condición </returns>
        public Calendario FiltrarPor(DateTime pFecha1, DateTime pFecha2)
        {
            Calendario eventos = new Calendario("EventosPorFechas");
            foreach (Evento elemento in this.Evento)
            {
                if (elemento.FechaInicio>= pFecha1 && elemento.FechaFin<=pFecha2
                    && elemento.FechaFin<=pFecha2 && elemento.FechaInicio>=pFecha1)
                {
                    eventos.AgregarEvento(elemento.Titulo, elemento.FechaInicio, elemento.FechaFin, elemento.Frecuencia);
                }
            }
            if (eventos.Evento.Count == 0)
            {
                CalendarioVacioException Excepcion = new CalendarioVacioException("No se han encontrado eventos");
                throw Excepcion;
            }
            return eventos;
        }




    }
}
