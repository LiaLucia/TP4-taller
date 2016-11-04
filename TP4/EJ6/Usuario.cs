﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ5
{
    public class Usuario : IComparable<Usuario>
    {
        private string iCodigo;
        private string iNombreCompleto;
        private string iCorreoElectronico;

        public int CompareTo(Usuario pUsario)
        {
            return String.Compare(this.Codigo, pUsario.Codigo);
        }

        public Usuario Copy()
        {
            Usuario us = new Usuario();
            us.Codigo = this.iCodigo;
            us.CorreoElectronico = this.iCorreoElectronico;
            us.NombreCompleto = this.iNombreCompleto;
            return us;
        }
        
        public override int GetHashCode()
        {
            int c;
            int.TryParse(this.Codigo, out c);
            return c;
        }

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

    public class OrdenarPorNombreDesc : IComparer<Usuario>
    {
        public int Compare(Usuario x, Usuario y)
        {
            return string.Compare(x.NombreCompleto, y.NombreCompleto);
        }
    }

    public class OrdenarPorNombreAsc : IComparer<Usuario>
    {
        public int Compare(Usuario x, Usuario y)
        {
            return -(string.Compare(x.NombreCompleto, y.NombreCompleto));
        }
    }

    public class OrdenarPorCorreo : IComparer<Usuario>
    {
        public int Compare(Usuario x, Usuario y)
        {
            return string.Compare(x.CorreoElectronico, y.CorreoElectronico);
        }
    }

}
