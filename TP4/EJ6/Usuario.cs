using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ6
{
    /// <summary>
    /// Clase que representa cada uno de los usuarios almacenados en el repositorio, hereda de IComparable para poder ser comparados
    /// </summary>
    public class Usuario : IComparable<Usuario>
    {
        private string iCodigo;
        private string iNombreCompleto;
        private string iCorreoElectronico;

        /// <summary>
        /// Implementacion de CompareTo, comparador por defecto,
        /// compara el codigo de este usuario con el codigo del us parametro
        /// </summary>
        /// <param name="pUsario"></param>
        /// <returns></returns>
        public int CompareTo(Usuario pUsario)
        {
            return String.Compare(this.Codigo, pUsario.Codigo);
        }

        /// <summary>
        /// Este metodo devuelve una copia del usuario 
        /// </summary>
        /// <returns></returns>
        public Usuario Copy()
        {
            Usuario us = new Usuario();
            us.Codigo = this.iCodigo;
            us.CorreoElectronico = this.iCorreoElectronico;
            us.NombreCompleto = this.iNombreCompleto;
            return us;
        }
        
        /// <summary>
        /// Esta implementacion de GetHashCode simplemente devuelve el codigo del usuario como integer
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            int c;
            int.TryParse(this.Codigo, out c);
            return c;
        }

        /// <summary>
        /// Esta implementacion de Equals compara el usuario con el usuario parametro
        /// </summary>
        /// <param name="pUsuario"></param>
        /// <returns></returns>
        public override bool Equals(object pUsuario)
        {
            if (this==pUsuario)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string Codigo
        {
            get { return this.iCodigo; }
            set { this.iCodigo = value; }
        }

        public string NombreCompleto
        {
            get { return this.iNombreCompleto; }
            set { this.iNombreCompleto = value; }
        }

        public string CorreoElectronico
        {
            get { return this.iCorreoElectronico; }
            set { this.iCorreoElectronico = value; }
        }

    }

    /// <summary>
    /// Clase heredada de IComparer
    /// </summary>
    public class OrdenarPorNombreDesc : IComparer<Usuario>
    {
        /// <summary>
        /// Implementacion de Compare, permite devolver usuarios ordenados por nombre descendente
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public int Compare(Usuario x, Usuario y)
        {
            return string.Compare(x.NombreCompleto, y.NombreCompleto);
        }
    }

    /// <summary>
    /// Clase heredada de IComparer
    /// </summary>
    public class OrdenarPorNombreAsc : IComparer<Usuario>
    {
        /// <summary>
        /// Implementacion de Compare, permite devolver usuarios ordenados por nombre ascendente
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public int Compare(Usuario x, Usuario y)
        {
            return -(string.Compare(x.NombreCompleto, y.NombreCompleto));
        }
    }

    /// <summary>
    /// Clase heredada de IComparer
    /// </summary>
    public class OrdenarPorCorreo : IComparer<Usuario>
    {
        /// <summary>
        /// Implementacion de Compare, permite devolver usuarios ordenados por correo
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public int Compare(Usuario x, Usuario y)
        {
            return string.Compare(x.CorreoElectronico, y.CorreoElectronico);
        }
    }

}
