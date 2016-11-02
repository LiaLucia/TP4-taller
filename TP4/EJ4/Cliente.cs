using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ2
{
    class Cliente
    {
        private string iNroDocumento;
        /// <summary>
        /// Propiedad de solo lectura del atributo Numero de documento
        /// </summary>

        private string NroDocumento
        {
            get { return this.iNroDocumento; }
        
        }

        private string iNombre;
        /// <summary>
        /// propiedad de solo lectura del atributo Nombre
        /// </summary>
        public string Nombre
        {
            get { return this.iNombre; }
        }

        private TipoDocumento iTipoDocumento;
        /// <summary>
        /// propiedad de solo lectura del tipo de documento
        /// </summary>
        public TipoDocumento TipoDocumento
        {
            get { return this.iTipoDocumento; }
        }
        /// <summary>
        /// Constructor de la clase Cliente
        /// </summary>
        /// <param name="pTipoDocumento">Atributo Tipo de documento del cliente</param>
        /// <param name="pNroDocumento">Atributo Numero de documento del cliente</param>
        /// <param name="pNombre">Atributo Nombre del cliente</param>
        public Cliente ( TipoDocumento pTipoDocumento, string pNroDocumento, string pNombre)
        {
            this.iNombre = pNombre;
            this.iNroDocumento = pNroDocumento;
            this.iTipoDocumento = pTipoDocumento;
         }

    }
}
