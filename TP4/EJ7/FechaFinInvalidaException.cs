using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ7
{
    class FechaFinInvalidaException : ApplicationException
    {
        public FechaFinInvalidaException(string pMensaje) : base(pMensaje)
        {

        }
    
    }
}
