using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ2
{
    class Cuenta
    {
        private double iSaldo;
        /// <summary>
        /// propiedad de solo lectura del atributo Saldo
        /// </summary>
        public double Saldo
        {
            get { return this.iSaldo; }
           
        }
      

        private double iAcuerdo;
        /// <summary>
        /// propiedad de solo lectura del atributo Acuerdo
        /// </summary>
        public double Acuerdo
        {
            get { return this.iAcuerdo; }

        }
        /// <summary>
        /// Contructor de la cuenta 
        /// </summary>
        /// <param name="pAcuerdo">Ingresa un Acuerdo de la cuenta</param>
        public Cuenta(double pAcuerdo)
        {
            this.iAcuerdo = pAcuerdo;
        }
        /// <summary>
        /// Contructor de la cuenta
        /// </summary>
        /// <param name="pSaldoInicial">Ingresa un Saldo inicial de la cuenta</param>
        /// <param name="pAcuerdo">Ingresa un Acuerdo de la cuenta</param>
        public Cuenta(double pSaldoInicial, double pAcuerdo)
        {
            this.iAcuerdo = pAcuerdo;
            this.iSaldo = pSaldoInicial;
        }
        /// <summary>
        /// Metodo para acreditar Saldo a una cuenta
        /// </summary>
        /// <param name="pSaldo">Saldo que se acreditará</param>
        public bool AcreditarSaldo(double pSaldo)
        {
            if (pSaldo<=0)
            {
                throw new SaldoInvalidoException("Se produjo una Excepcion por saldo a acreditar inválido");
            }
            else
            {
                this.iSaldo = this.iSaldo + pSaldo;
                return true;
            } 
        }
        /// <summary>
        /// Metodo que debita Saldo en una cuenta
        /// </summary>
        /// <param name="pSaldo">Saldo que se debitará</param>
        /// <returns>Devuelve True si debita el saldo luego de verificar si tenia
        /// saldo suficiente, False si no debita</returns>
        public Boolean DebitarSaldo(double pSaldo)
        {
            if (pSaldo <= 0)
            {
                throw new SaldoInvalidoException("Se produjo una Excepcion por saldo a acreditar inválido");
            }
            else
            {
                if (this.iAcuerdo + this.iSaldo >= pSaldo)
                {
                    this.iSaldo = this.iSaldo - pSaldo;
                    return true;
                }
                else
                {
                    throw new SaldoInsuficienteException("Se produjo una Excepcion por saldo insuficiente");
                }
            }
        }
    }
}
