using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ5
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
        /// Propiedad del atributo Codigo
        /// </summary>
        public string Codigo
        {
            get { return this.iCodigo; }
            set { this.iCodigo = value; }
        }
        /// <summary>
        /// Propiedad del atributo NombreCompleto
        /// </summary>
        public string NombreCompleto
        {
            get { return this.iNombreCompleto; }
            set { this.iNombreCompleto = value; }
        }
        /// <summary>
        /// Propedad del atributo CorreoElectronico
        /// </summary>
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
