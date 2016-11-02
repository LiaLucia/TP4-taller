using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ2
{
    class Cuentas
    {
        private Cuenta iCajaAhorro;

        /// <summary>
        /// propiedad de solo lectura del atributo Caja de ahorro de Cuentas
        /// </summary>
        public Cuenta CajaAhorro
        {
            get { return this.iCajaAhorro; }
        }

        private Cuenta iCuentaCorriente;
        
        /// <summary>
        /// propiedad de solo lectura del atributo Cuenta corriente de Cuentas
        public Cuenta CuentaCorriente
        {
            get { return this.iCuentaCorriente; }
        }

        private Cliente iCliente;
       
        /// <summary>
        /// Constructor
        /// </summary>
        public Cuentas()
        {
            this.iCajaAhorro =new Cuenta(1000,200);
            this.iCuentaCorriente = new Cuenta(300,200);
            this.iCliente= new Cliente(0,"38171725", "Juan Perez");
        }
        
    }
}
