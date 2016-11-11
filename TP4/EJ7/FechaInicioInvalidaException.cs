using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ7
{/// <summary>
/// Excepcion que se produce cuando la fecha de inicio de un evento es incorrecta
/// </summary>
    public class FechaInicioInvalidaException : ApplicationException
    {
        public FechaInicioInvalidaException(string pMensaje) : base(pMensaje)
        {

        }
    }
}
