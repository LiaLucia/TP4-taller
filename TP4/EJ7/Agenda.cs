using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("TestingEJ7")]
namespace EJ7
{
    class Agenda
    {
        
        private List<Calendario> iListaCalendario;
        
        public Agenda()
        {
            iListaCalendario = new List<Calendario>();
        }

        public List<Calendario> Calendario
        {

            get { return this.iListaCalendario; }
        }

        public void AgregarCalendario(string pTitulo)
        {

            Calendario pCalendario = new Calendario(pTitulo);
            this.Calendario.Add(pCalendario);
            
            
        }

        public void EliminarCalendario(Calendario pCalendario)
        {
            this.Calendario.Remove(pCalendario);

        }
       
        public string ListarCalendario()
        {
            string variable = "- ";
            
            foreach (Calendario elemento in this.Calendario)
            {
                variable = variable + elemento.Titulo +" - ";

            }
            if (variable == "- ")
            {
                AgendaVaciaException Excepcion = new AgendaVaciaException("La agenda no contiene ningun calendario");
                throw Excepcion;
            }
            return variable;
        }

    


    }
}
