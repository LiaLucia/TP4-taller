using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ7
{/// <summary>
/// Excepcion que se produce cuando la fehca de fin de un evento es incorrecta
/// </summary>
    public class FechaFinInvalidaException : ApplicationException
    {
        public FechaFinInvalidaException(string eMensaje) : base(eMensaje)
        {

        }
    
    }
}
