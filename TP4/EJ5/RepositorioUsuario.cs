using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ5
{
     public class RepositorioUsuario : IRepositorioUsuario
    {
        private SortedList<string,Usuario> iRepositorio = new SortedList<string, Usuario>();

        public void Agregar(Usuario pUsuario)
        {
            iRepositorio.Add(pUsuario.Codigo,pUsuario);
        }

        public void Eliminar(Usuario pUsuario)
        {
            iRepositorio.Remove(pUsuario.Codigo);
        }

        public void Actualizar(Usuario pUsuario)
        {
            iRepositorio[pUsuario.Codigo] = pUsuario;
        }

        public IList<Usuario> ObtenerTodos()
        {
            return iRepositorio.Values.ToList();
        }

        public Usuario ObtenerPorCodigo(string pCodigo)
        {
            return iRepositorio[pCodigo];
        }

        public IList<Usuario> ObtenerComparadosPor(IComparer<Usuario> pComparador)
        {
            List<Usuario> pLista = iRepositorio.Values.ToList();
            pLista.Sort(pComparador.Compare);
            return pLista.ToList();
        }

    }
}
