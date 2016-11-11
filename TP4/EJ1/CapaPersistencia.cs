using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ1
{
    class CapaPersistencia
    {/// <summary>
    /// Metodo ejecutar que produce una excepcion por un error puntual
    /// </summary>
        public void Ejecutar()
        {
            ErrorPuntualException excepcion = new ErrorPuntualException("Excepcion generica ");
            throw excepcion;
        }
    }
}
