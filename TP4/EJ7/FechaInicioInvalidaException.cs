using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ7
{
    public class FechaInicioInvalidaException : ApplicationException
    {
        public FechaInicioInvalidaException(string pMensaje) : base(pMensaje)
        {

        }
    }
}
