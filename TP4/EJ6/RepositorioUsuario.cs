using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ6
{ 

    /// <summary>
    /// Clase que implementa los metodos del Repositorio
    /// </summary>
     public class RepositorioUsuario : IRepositorioUsuario
    {
        /// <summary>
        /// Repositorio implementado como una Lista con List
        /// </summary>
        private List<Usuario> iRepositorio = new List<Usuario>();

        /// <summary>
        /// Metodo para agregar un Usuario
        /// </summary>
        /// <param name="pUsuario"></param>
        public void Agregar(Usuario pUsuario)
        {
            if (!(iRepositorio.Contains(pUsuario)))
            {
            iRepositorio.Add(pUsuario);
            }
        }

        /// <summary>
        /// Elimina un usuario del repositorio por su codigo
        /// </summary>
        /// <param name="pUsuario"></param>
        public void Eliminar(Usuario pUsuario)
        {
            iRepositorio.Remove(pUsuario);
        }

        /// <summary>
        /// Actualiza los datos de un usuario accediendolo a traves de su codigo
        /// </summary>
        /// <param name="pUsuario"></param>
        public void Actualizar(Usuario pUsuario)
        {
            if (iRepositorio.Contains(pUsuario))
            {

                iRepositorio.Remove(pUsuario);
                iRepositorio.Add(pUsuario);
            }
            
        }

        /// <summary>
        /// Devuelve una lista con los usuarios
        /// </summary>
        /// <returns></returns>
        public IList<Usuario> ObtenerTodos()
        {
            return iRepositorio;
        }

        /// <summary>
        /// Este metodo permite obtener un usuario por su codigo, utilizando nuestra implementacion de GetHashCode.
        /// </summary>
        /// <param name="pCodigo">debe traducirse de string a integer</param>
        /// <returns></returns>
        public Usuario ObtenerPorCodigo(string pCodigo)
        {
            int c;
            int.TryParse(pCodigo, out c);
            return iRepositorio.Find(usuario => usuario.GetHashCode() == c);
        }

        /// <summary>
        /// Este metodo devuelve una lista de usuarios cuyos nombres cumplen con la subcadena ingresada, 
        /// utiliza el concepto de defensive copy por lo cual devuelve una copia del usuario
        /// </summary>
        /// <param name="pNombre"> subcadena para buscar</param>
        /// <returns></returns>
        public IList<Usuario> BuscarAproximado (string pNombre)
        {
            List<Usuario> lista = new List<Usuario>();
            IEnumerator<Usuario> enumerador = this.iRepositorio.GetEnumerator();
            while (enumerador.MoveNext())
            {
                if (enumerador.Current.NombreCompleto.StartsWith(pNombre))
                {
                    lista.Add(enumerador.Current.Copy());
                }
            }
            return lista;

        }

        /// <summary>
        /// Devuelve una lista de usuarios ordenados por el parametro
        /// </summary>
        /// <param name="pComparador"></param>
        /// <returns></returns>
        public IList<Usuario> ObtenerComparadosPor(IComparer<Usuario> pComparador)
        {
            List<Usuario> ILista = iRepositorio;
            ILista.Sort(pComparador.Compare);
            return ILista;
        }

    }
}
