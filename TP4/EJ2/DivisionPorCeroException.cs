using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ2
{/// <summary>
/// Excepcion que se produce cuando se divide por cero
/// </summary>
    public class DivisionPorCeroException : ApplicationException
    {
        public DivisionPorCeroException(string pMensaje) : base(pMensaje)
        {
            
        }
    }
}
