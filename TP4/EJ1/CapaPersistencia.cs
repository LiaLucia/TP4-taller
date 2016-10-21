using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ1
{
    class CapaPersistencia
    {
        public void Ejecutar()
        {
            ErrorPuntualException excepcion = new ErrorPuntualException("Excepcion generica ");
            throw excepcion;
        }
    }
}
