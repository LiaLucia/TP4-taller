using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ1
{
    class CapaDominio
    {/// <summary>
    /// Metodo que ejecuta el metodo Ejecutar de la capa de persistencia
    /// </summary>
        public void Ejecutar()
        {
            CapaPersistencia vCapaPersistencia = new CapaPersistencia();
            vCapaPersistencia.Ejecutar();
        }
    }
}
