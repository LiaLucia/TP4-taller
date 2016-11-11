using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ1
{/// <summary>
/// Excepcion que se produce por un error puntual
/// </summary>
    class ErrorPuntualException : ApplicationException
    {
        public ErrorPuntualException(string pMensaje) : base(pMensaje)
        {
            this.Data.Add("fecha", DateTime.Now);
        }
    }
}
