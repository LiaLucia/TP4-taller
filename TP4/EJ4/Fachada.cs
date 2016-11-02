using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ2
{
    class Fachada
    {
        public Cuentas Crear()
        {
            Cuentas admin = new Cuentas();
            return admin;
        }

        /// <summary>
        /// Metodo para acreditar una cuenta
        /// </summary>
        /// <param name="pCuenta"></param>
        /// <param name="aSaldo">Saldo que acreditará </param>
        public bool AcreditarCuenta (Cuenta pCuenta, double aSaldo) // acredita a una cuenta que ya posee un saldo inicial
        {
            return pCuenta.AcreditarSaldo(aSaldo);
        }
   
        /// <summary>
        /// Metodo para debitar una cuenta
        /// </summary>
        /// <param name="pCuenta"></param>
        /// <param name="aSaldo">Saldo que debitará</param>
        /// <returns>devuelve True si debita la cuenta, False si no</returns>
     
        public Boolean DebitarCuenta(Cuenta pCuenta, double aSaldo)
        {
            return pCuenta.DebitarSaldo(aSaldo);
        }
        /// <summary>
        /// Metodo para transferir saldo de una cuenta a otra
        /// </summary>
        /// <param name="pCuenta1">Cuenta de la que debitará el saldo</param>
        /// <param name="pCuenta2">Cuenta a la que le acreditará el saldo</param>
        /// <param name="pSaldo"></param>
        /// <returns>devuelve True si logra hacer la transferencia, False si no</returns>
        public Boolean Transferir(Cuenta pCuenta1, Cuenta pCuenta2, double pSaldo)
        {
            if (pCuenta1.DebitarSaldo(pSaldo) == true)
            {
                pCuenta2.AcreditarSaldo(pSaldo);
                return true;
            }
            else
            {
                return false;
            }
        }

       

    }
}
