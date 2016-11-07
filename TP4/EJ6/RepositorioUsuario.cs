using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ5
{
     public class RepositorioUsuario : IRepositorioUsuario
    {
        private List<Usuario> iRepositorio = new List<Usuario>();

        public void Agregar(Usuario pUsuario)
        {
            if (!(iRepositorio.Contains(pUsuario)))
            {
            iRepositorio.Add(pUsuario);
            }
        }

        public void Eliminar(Usuario pUsuario)
        {
            iRepositorio.Remove(pUsuario);
        }

        public void Actualizar(Usuario pUsuario)
        {
            if (iRepositorio.Contains(pUsuario))
            {

                iRepositorio.Remove(pUsuario);
                iRepositorio.Add(pUsuario);
            }
            
        }

        public IList<Usuario> ObtenerTodos()
        {
            return iRepositorio;
        }

        public Usuario ObtenerPorCodigo(string pCodigo)
        {
            int c;
            int.TryParse(pCodigo, out c);
            return iRepositorio.Find(usuario => usuario.GetHashCode() == c);
        }

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


        public IList<Usuario> ObtenerComparadosPor(IComparer<Usuario> pComparador)
        {
            List<Usuario> ILista = iRepositorio;
            ILista.Sort(pComparador.Compare);
            return ILista;
        }

    }
}
