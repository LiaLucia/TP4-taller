using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
// Hace que sea visible para el Testing unitario
[assembly: InternalsVisibleTo("TestingEJ7")]
namespace EJ7
{
    class Agenda
    {
       
        private List<Calendario> iListaCalendario;
        
        /// <summary>
        /// Constructor de la clase Agenda
        /// </summary>
        public Agenda()
        {
            iListaCalendario = new List<Calendario>();
        }
        /// <summary>
        /// Accesor a lista de calendarios
        /// </summary>
        public List<Calendario> Calendario
        {

            get { return this.iListaCalendario; }
        }
        /// <summary>
        /// Metodo para agregar un calendario a la lista de calendarios de la agenda
        /// </summary>
        /// <param name="pTitulo"> Titulo del calendario a crear</param>
        public void AgregarCalendario(string pTitulo)
        {

            Calendario pCalendario = new Calendario(pTitulo);
            this.Calendario.Add(pCalendario);
            
            
        }
        /// <summary>
        /// Metodo para eliminar un calendario de la lista de calendarios
        /// </summary>
        /// <param name="pCalendario">Calendario que se va a eliminar</param>
        public void EliminarCalendario(Calendario pCalendario)
        {
            this.Calendario.Remove(pCalendario);

        }
       /// <summary>
       /// Metodo para listar los calendarios que se encuentran en la lista
       /// </summary>
       /// <returns>Devuelve los titulos de los calendarios</returns>
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
