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

        public Evento(string pTitulo, DateTime pFechaInicio, DateTime pFechaFin, TipoFrecuencia pFrecuencia)
        {
            iTitulo = pTitulo;
            iFechaFin = pFechaFin;
            iFechaInicio = pFechaInicio;
            iFrecuencia = pFrecuencia;
        }

        public string Titulo
        {
            get { return this.iTitulo; }
            set { this.iTitulo = value; }
        }

        public DateTime FechaInicio
        {
            get { return this.iFechaInicio; }
            set { this.iFechaInicio = value; }
        }
        public DateTime FechaFin
        {
            get { return this.iFechaFin; }
            set { this.iFechaFin = value; }
        }

        public TipoFrecuencia Frecuencia
        {
            get { return this.iFrecuencia; }
            set { this.iFrecuencia = value; }
            
        }

        public void ModificarEvento(string pTitulo)
        {
            this.Titulo = pTitulo;
        }
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

        public void ModificarEvento(TipoFrecuencia pFrecuencia)
        {
            this.Frecuencia = pFrecuencia;
        }

    }
}
    
