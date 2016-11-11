using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ1
{
    class CapaVista
    {/// <summary>
    /// Metodo ejecutar que trata la excepcion que se produce en la capa controlador
    /// </summary>
        public void Ejecutar()
        {
            CapaControlador vCapaControlador = new CapaControlador();
            try
            {
                vCapaControlador.Ejecutar();
            }
            catch (CapaAplicacionException pExcepcion)
            {
                Console.WriteLine("Ha ocurrido un error en la capa de aplicacion: {0}", pExcepcion);
                Console.WriteLine("");
                Console.WriteLine("Se ha producido por: {0}  en la capa de persistencia el: {1}", pExcepcion.Data["fuente"], pExcepcion.Data["fecha"]);
                Console.WriteLine("");
                Console.WriteLine("CallStack: {0}", pExcepcion.StackTrace);

            }
        }
    }
}

