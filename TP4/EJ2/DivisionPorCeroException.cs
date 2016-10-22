using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ2
{
    public class DivisionPorCeroException : ApplicationException
    {
        public DivisionPorCeroException(string pMensaje) : base(pMensaje)
        {
            
        }
    }
}
