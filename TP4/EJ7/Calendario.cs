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

        public Calendario(String pTitulo)
        {
            iListaEvento = new List<Evento>();
            iFechaCreacion = DateTime.Now;
            iTitulo = pTitulo;
        }

        public string Titulo
        {
            get { return this.iTitulo; }
            set { this.iTitulo = value; }
        }
        public DateTime FechaCreacion
        {
            get { return this.iFechaCreacion; }
            set { this.iFechaCreacion = value; }
        }
        
        public List<Evento> Evento
        {
            get { return this.iListaEvento; }
        }


        public void AgregarEvento(Evento pEvento)
        {
                this.Evento.Add(pEvento);
        
        }
            
        
        public void EliminarEvento(Evento pEvento) 
        {
            this.Evento.Remove(pEvento);

        }

        public void ModificarCalendario(string pTitulo)
        {
            this.iTitulo = pTitulo;
            
        }

        public string ListarEvento()
        {
            string variable = "- ";

            foreach (Evento elemento in this.Evento)
            {
                variable = variable + elemento.Titulo + " - ";

            }

            return variable;
        }

        public Calendario FiltrarPor(string pTituloEvento)
        {
            Calendario eventos = new Calendario(pTituloEvento);
            foreach (Evento elemento in this.Evento)
            {
                if (elemento.Titulo == pTituloEvento)
                {
                    eventos.AgregarEvento(elemento);
                }
            }
            return eventos;
        }



        public Calendario FiltrarPor(DateTime pFecha1, DateTime pFecha2)
        {
            Calendario eventos = new Calendario("EventosPorFechas");
            foreach (Evento elemento in this.Evento)
            {
                if (elemento.FechaInicio>= pFecha1 && elemento.FechaFin<=pFecha2
                    && elemento.FechaFin<=pFecha2 && elemento.FechaInicio>=pFecha1)
                {
                    eventos.AgregarEvento(elemento);
                }
            }
            return eventos;
        }

        // iListaEvento.Find(Evento => Evento == pEvento);



    }
}
