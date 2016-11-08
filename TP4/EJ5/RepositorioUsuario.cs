using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ5
{

    /// <summary>
    /// Clase que implementa los metodos del Repositorio
    /// </summary>
    public class RepositorioUsuario : IRepositorioUsuario
    {
        /// <summary>
        /// Repositorio implementado como un Diccionario con SortedList
        /// </summary>
        private SortedList<string,Usuario> iRepositorio = new SortedList<string, Usuario>();

        /// <summary>
        /// Metodo para agregar un Usuario
        /// </summary>
        /// <param name="pUsuario"></param>
        public void Agregar(Usuario pUsuario)
        {
            iRepositorio.Add(pUsuario.Codigo,pUsuario);
        }

        /// <summary>
        /// Elimina un usuario del repositorio por su codigo
        /// </summary>
        /// <param name="pUsuario"></param>
        public void Eliminar(Usuario pUsuario)
        {
            iRepositorio.Remove(pUsuario.Codigo);
        }

        /// <summary>
        /// Actualiza los datos de un usuario accediendolo a traves de su codigo
        /// </summary>
        /// <param name="pUsuario"></param>
        public void Actualizar(Usuario pUsuario)
        {
            iRepositorio[pUsuario.Codigo] = pUsuario;
        }

        /// <summary>
        /// Devuelve una lista con los usuarios
        /// </summary>
        /// <returns></returns>
        public IList<Usuario> ObtenerTodos()
        {
            return iRepositorio.Values.ToList();
        }

        /// <summary>
        /// Devuelve un usuario que tenga por clave el parametro ingresado
        /// </summary>
        /// <param name="pCodigo"></param>
        /// <returns></returns>
        public Usuario ObtenerPorCodigo(string pCodigo)
        {
            return iRepositorio[pCodigo];
        }

        /// <summary>
        /// Devuelve una lista de usuarios ordenados por el parametro
        /// </summary>
        /// <param name="pComparador"></param>
        /// <returns></returns>
        public IList<Usuario> ObtenerComparadosPor(IComparer<Usuario> pComparador)
        {
            List<Usuario> pLista = iRepositorio.Values.ToList();
            pLista.Sort(pComparador.Compare);
            return pLista.ToList();
        }

    }
}
