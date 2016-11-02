using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej2
{
    class FachadaCuentas
    {
        private Cuentas iCuenta;

        public Cliente CrearCliente(string nombre, string nroDoc, TipoDocumento tipoDoc)
        {
            Cliente cliente = new Cliente(tipoDoc, nroDoc, nombre);
            return cliente;

        }

        public Cuenta CrearCuenta(double pAcuerdo, double pSaldo)
        {
                Cuenta cuenta = new Cuenta(pAcuerdo, pSaldo);
                return cuenta;

        }
        public Cuenta CrearCuenta(double pAcuerdo)
        {
                Cuenta cuenta = new Cuenta(pAcuerdo);
                return cuenta;
        }


        public void CrearCuentas(Cliente pCliente, Cuenta pCuentaCorriente, Cuenta pCajaAhorro)
        {
            this.iCuenta = new Cuentas(pCliente, pCuentaCorriente, pCajaAhorro);
        }

        public Cuenta ConsultarCC()
        {
            return this.iCuenta.CuentaCorriente;
        }
        public Cuenta ConsultarCA()
        {
            return this.iCuenta.CajaAhorro;
        }
        public Boolean TransferirCCaCA(double monto)
        {
            Boolean b;
            b = this.iCuenta.CuentaCorriente.DebitarSaldo(monto);
            if (b == true)
            {
                this.iCuenta.CajaAhorro.AcreditarSaldo(monto);
            }
            return b;
        }
        public Boolean TransferirCAaCC(double monto)
        {
            Boolean b;
            b = this.iCuenta.CajaAhorro.DebitarSaldo(monto);
            if (b == true)
            {
                this.iCuenta.CuentaCorriente.AcreditarSaldo(monto);
            }
            return b;
        }
        public Boolean DebitarCC(double monto)
        {
            return this.iCuenta.CuentaCorriente.DebitarSaldo(monto);
        }
        public Boolean DebitarCA(double monto)
        {
            return this.iCuenta.CajaAhorro.DebitarSaldo(monto);
        }
        public void AcreditarCA(double monto)
        {
            this.iCuenta.CajaAhorro.AcreditarSaldo(monto);
        }
        public void AcreditarCC(double monto)
        {
            this.iCuenta.CuentaCorriente.AcreditarSaldo(monto);
        }

    }
}
