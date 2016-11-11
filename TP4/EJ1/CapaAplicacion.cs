using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ1
{
    class CapaAplicacion
    {/// <summary>
    /// Metodo ejecutar que trata la excepcion que se produce en la capa de dominio
    /// </summary>
        public void Ejecutar()
        {
            CapaDominio vCapaDominio = new CapaDominio();
            try
            {
                vCapaDominio.Ejecutar();
            }
            catch (ErrorPuntualException error)
            {

                CapaAplicacionException excepcionAplicacion = new CapaAplicacionException("Error de Aplicacion", (DateTime)error.Data["fecha"], error.Message);
                throw excepcionAplicacion;
            }
        }
    }
}
