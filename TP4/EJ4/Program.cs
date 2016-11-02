using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ2
{
    class Program
    {
        static Fachada facade = new Fachada();
        static void Main(string[] args)
        {
            Cuentas admin = facade.Crear();
            int condicion;
            
            do //Repite el menu principal mientras la condicion sea distinto de 0 para salir
            {
                Console.WriteLine("¿Que desea ralizar?");
                Console.WriteLine("1 - Mostrar detalles de cuenta");
                Console.WriteLine("2 - Acreditar Saldo");
                Console.WriteLine("3 - Debitar Saldo");
                Console.WriteLine("4 - Transferir");
                Console.WriteLine("0 - Salir");
                int.TryParse(Console.ReadLine(), out condicion);
                
                    switch (condicion) //Segun la opcion ingresada realiza distintas acciones.
                    {
                        case 1: //Detalla una o ambas cuentas mostrando su saldo actual y su acuerdo
                            int c;
                        do //Repite la accion hasta que selecciona 0, y vuelve al menu principal
                        {
                            Console.WriteLine("Seleccione la cuenta que desea ver: ");
                            Console.WriteLine("1- Cuenta Corriente. 2- Caja de Ahorro. 3- Ambas. 0- Salir.");
                            int.TryParse(Console.ReadLine(), out c);
                        
                            switch (c)
                            {
                                case 1:
                                    Console.WriteLine("Saldo: " + admin.CuentaCorriente.Saldo);
                                    Console.WriteLine("Acuerdo: " + admin.CuentaCorriente.Acuerdo);
                                    break;
                                case 2:
                                    Console.WriteLine("Saldo: " + admin.CajaAhorro.Saldo);
                                    Console.WriteLine("Acuerdo: " + admin.CajaAhorro.Acuerdo);
                                    break;
                                case 3:
                                    Console.WriteLine("Cuenta Corriente: ");
                                    Console.WriteLine("Saldo: " + admin.CuentaCorriente.Saldo);
                                    Console.WriteLine("Acuerdo: " + admin.CuentaCorriente.Acuerdo);
                                    Console.WriteLine("Caja de Ahorro: ");
                                    Console.WriteLine("Saldo: " + admin.CajaAhorro.Saldo);
                                    Console.WriteLine("Acuerdo: " + admin.CajaAhorro.Acuerdo);
                                    break;
                            }
                    } while (c != 0) ;
                    break;
                
                    case 2: //Acredita saldo a una cuenta que desee
                        int d;
                        do {  //Repite la accion hasta que selecciona 0 y vuelve al menu principal
                        Console.WriteLine("Seleccione la cuenta: ");
                        Console.WriteLine("1- Cuenta Corriente. 2-Caja de Ahorro. 0-Salir.");
                        int.TryParse(Console.ReadLine(), out d);
                        int saldoA;
                        
                        switch (d)
                        {
                            case 1:
                                Console.WriteLine("Ingrese el monto que desea acreditar: ");
                                int.TryParse(Console.ReadLine(), out saldoA);
                                    bool resacr1=false;
                                    try
                                    {
                                       resacr1= facade.AcreditarCuenta(admin.CuentaCorriente, saldoA);
                                    }
                                    catch (ClaseSaldoException excepcion)
                                    {
                                        Console.WriteLine(excepcion.Message);
                                    }
                                    if (resacr1)
                                    { 
                                        Console.WriteLine("¡Saldo acreditado correctamente!");
                                    }
                                break;
                            case 2:
                                Console.WriteLine("Ingrese el monto que desea acreditar: ");
                                int.TryParse(Console.ReadLine(), out saldoA);
                                    bool resacr2 = false;
                                    try
                                    {
                                       resacr2= facade.AcreditarCuenta(admin.CajaAhorro, saldoA);
                                    }
                                    catch (ClaseSaldoException excepcion)
                                    {
                                        Console.WriteLine(excepcion.Message);
                                    }
                                    if (resacr2)
                                    {
                                        Console.WriteLine("¡Saldo acreditado correctamente!");
                                    }
                                break;
                        }
                        } while (d != 0);
                        break;
                    case 3: //Debita saldo a una cuenta que desee
                        int e;
                        do //Repite la accion hasta que selecciona 0 y vuelve al menu principal
                        {
                            Console.WriteLine("Seleccione la cuenta: ");
                        Console.WriteLine("1- Cuenta Corriente. 2-Caja de Ahorro. 0-Salir.");
                        int.TryParse(Console.ReadLine(), out e);
                        int saldoD;
                            switch (e)
                            {
                                case 1:
                                    bool resDeb1=false;
                                    Console.WriteLine("Ingrese el monto que desea debitar: ");
                                    int.TryParse(Console.ReadLine(), out saldoD);
                                    try
                                    {
                                        resDeb1=facade.DebitarCuenta(admin.CuentaCorriente, saldoD);
                                    }
                                    catch (ClaseSaldoException excepcion)
                                    {
                                        Console.WriteLine(excepcion.Message);
                                    }
                                    if (resDeb1)
                                    {
                                        Console.WriteLine("¡Saldo debitado correctamente!");
                                    }
                                break;
                            case 2:
                                Console.WriteLine("Ingrese el monto que desea debitar: ");
                                int.TryParse(Console.ReadLine(), out saldoD);
                                    bool resDeb2=false;
                                    try
                                    {
                                        resDeb2= facade.DebitarCuenta(admin.CajaAhorro, saldoD);
                                    }
                                    catch (ClaseSaldoException excepcion)
                                    {
                                        Console.WriteLine(excepcion.Message);
                                    }
                                    if (resDeb2)
                                    {
                                        Console.WriteLine("¡Saldo debitado correctamente!");
                                    }

                                break;
                        }
                        } while (e != 0);
                        break;
                    case 4: //Transfiere saldo desde una cuenta hacia otra
                        int f, saldoT;
                        do //Repite la accion hasta que selecciona 0 y vuelve al menu principal
                        {  
                        Console.WriteLine("Seleccione la transferencia que desea ralizar: ");
                        Console.WriteLine("1- De Cuenta Corriente a Caja de ahorro.");
                        Console.WriteLine("2- De Caja de Ahorro a Cuenta Corriente");
                        Console.WriteLine("0- Salir");
                        int.TryParse(Console.ReadLine(), out f);
                        
                        switch (f)
                        {
                            case 1:
                                    Console.WriteLine("Ingrese el saldo a transferir: ");
                                    int.TryParse(Console.ReadLine(), out saldoT);
                                    bool restr1 = false;
                                    try
                                    {
                                       restr1= facade.Transferir(admin.CuentaCorriente, admin.CajaAhorro, saldoT);
                                    }
                                    catch (ClaseSaldoException excepcion)
                                    {
                                        Console.WriteLine(excepcion.Message);
                                    }
                                    if (restr1)
                                    {
                                        Console.WriteLine("¡Transferencia realizada con exito!");
                                    }                                    
                                break;
                            case 2:
                                    Console.WriteLine("Ingrese el saldo a transferir: ");
                                    int.TryParse(Console.ReadLine(), out saldoT);
                                    bool restr2 = false;
                                    try
                                    {
                                        facade.Transferir(admin.CajaAhorro, admin.CuentaCorriente, saldoT);
                                    }
                                    catch (ClaseSaldoException excepcion)
                                    {
                                        Console.WriteLine(excepcion.Message);
                                    }
                                    if (restr2)
                                    {
                                        Console.WriteLine("¡Transferencia realizada con exito!");
                                    }
                                break;
                        }
                        
                        } while (f != 0);
                        break;

                }

            } while (condicion != 0);
        }
    }
}