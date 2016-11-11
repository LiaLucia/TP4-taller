using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ7
{
    /// <summary>
    /// Excepcion que se produce cuando una agenda no posee calendarios
    /// </summary>
    public class AgendaVaciaException : ApplicationException
    {
        public AgendaVaciaException(string eMensaje) : base(eMensaje)
        {

        }
    }
}
