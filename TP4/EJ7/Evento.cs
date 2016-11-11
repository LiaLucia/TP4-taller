using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ7
{
    class Evento
    {
        string iTitulo;
        DateTime iFechaInicio;
        DateTime iFechaFin;
        TipoFrecuencia iFrecuencia;
        /// <summary>
        /// Constructor de la clase Evento
        /// </summary>
        /// <param name="pTitulo">Titulo del evento</param>
        /// <param name="pFechaInicio">Fecha de inicio del evento</param>
        /// <param name="pFechaFin">Fecha de fin del evento</param>
        /// <param name="pFrecuencia">Frecuencia del evento</param>
        public Evento(string pTitulo, DateTime pFechaInicio, DateTime pFechaFin, TipoFrecuencia pFrecuencia)
        {
            iTitulo = pTitulo;
            iFechaFin = pFechaFin;
            iFechaInicio = pFechaInicio;
            iFrecuencia = pFrecuencia;
        }
        /// <summary>
        /// Propiedad del atributo Titulo del evento
        /// </summary>
        public string Titulo
        {
            get { return this.iTitulo; }
            set { this.iTitulo = value; }
        }
        /// <summary>
        /// Propiedad del atributo FechaInicio del evento
        /// </summary>
        public DateTime FechaInicio
        {
            get { return this.iFechaInicio; }
            set { this.iFechaInicio = value; }
        }
        /// <summary>
        /// Propiedad del atributo FechaFin del evento
        /// </summary>
        public DateTime FechaFin
        {
            get { return this.iFechaFin; }
            set { this.iFechaFin = value; }
        }
        /// <summary>
        /// Propiedad del atributo Frecuencia del evento
        /// </summary>
        public TipoFrecuencia Frecuencia
        {
            get { return this.iFrecuencia; }
            set { this.iFrecuencia = value; }
            
        }
        /// <summary>
        /// Metodo para modificar el titulo de un evento
        /// </summary>
        /// <param name="pTitulo">Nuevo titulo del evento que se va a modificar</param>
        public void ModificarEvento(string pTitulo)
        {
            this.Titulo = pTitulo;
        }
        /// <summary>
        /// Metodo para modificar las fechas de un evento
        /// </summary>
        /// <param name="pFechaInicio">Nueva fecha de inicio del evento</param>
        /// <param name="pFechaFin">Nueva fecha de fin del evento</param>
        public void ModificarEvento(DateTime pFechaInicio, DateTime pFechaFin)
        {

            if (pFechaFin > pFechaInicio)
            {
                this.FechaFin = pFechaFin;
            }
            else
            {
                FechaFinInvalidaException Excepcion = new FechaFinInvalidaException("La Fecha de Fin de evento ingresada es inválida");
                throw Excepcion;

            }

            if (this.FechaInicio > DateTime.Now)
            {
                this.FechaInicio = pFechaInicio;
            }
            else
            {
                FechaInicioInvalidaException Exception = new FechaInicioInvalidaException("La Fecha de Inicio de evento ingresada es inválida");
                throw Exception;
            }


        }
        /// <summary>
        /// Metodo para modificar la frecuencia de un evento
        /// </summary>
        /// <param name="pFrecuencia">Nueva frecuencia del evento</param>
        public void ModificarEvento(TipoFrecuencia pFrecuencia)
        {
            this.Frecuencia = pFrecuencia;
        }

    }
}
    
