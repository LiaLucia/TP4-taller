using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ2
{
    /// <summary>
    /// Clase de excepcion producida cuando ingresa un saldo menor o igual a 0
    /// </summary>
    class SaldoInvalidoException : ApplicationException
    {
        public SaldoInvalidoException(string pMensaje) : base(pMensaje)
        {  }
    }
}
