using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ5
{
    /// <summary>
    /// Interfaz del Repositorio que define los metodos abstractos
    /// </summary>
    interface IRepositorioUsuario
    {
        void Eliminar(Usuario pUsuario);

        void Agregar(Usuario pUsuario);


        void Actualizar(Usuario pUsuario);

        IList<Usuario> ObtenerTodos();

        Usuario ObtenerPorCodigo(string pCodigo);

        IList<Usuario> ObtenerComparadosPor(IComparer<Usuario> pComparador);
    }
}
