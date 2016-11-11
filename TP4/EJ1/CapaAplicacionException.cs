using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ1
{/// <summary>
/// Excepcion que se produce en la capa de aplicación
/// </summary>
    class CapaAplicacionException: ApplicationException
    {
        public CapaAplicacionException(string pMensaje, DateTime pFecha, string oMensaje) : base(pMensaje)
        {
            this.Data.Add("fecha", pFecha);
            this.Data.Add("fuente", oMensaje);
        }
    }
}
