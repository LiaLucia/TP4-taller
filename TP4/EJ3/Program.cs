using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la ruta (path) del archivo:"); 
            string ruta = Console.ReadLine();
            //string ruta = @"C:\Users\USER\Source\Repos\TP4-taller\TP4\EJ3\Prueba.txt";// RUTA CREADA PARA PROBAR EL EJERCICIO.
            Console.WriteLine("");
            StreamReader vacio = null; //Crea el objeto, y le asigna vacio.

            try
            {
                StreamReader archivo = new StreamReader(ruta); //Crea un objeto nuevo de lectura, y le asigna lo existente en la ruta que el usuario le pasa.
                Console.WriteLine(archivo.ReadToEnd()); // Lee desde principio al final, lo que se encuentre en el archivo.
                Console.ReadKey();
            }
            catch (ArgumentNullException) // La excepción se realiza cuando no se le otorga ninguna ruta .
            {
                Console.WriteLine("No se ingreso ninguna ruta del archivo");
                Console.ReadKey();
            }
            catch (ArgumentException) // La excepción se realiza cuando el formato de la ruta, no tiene un formato válido.
            {
                Console.WriteLine("La ruta del archivo ingresada no tiene un formato valido");
                Console.ReadKey();
            }
            catch (FileNotFoundException) // La excepción se realiza cuando el archivo no se encuentra en la ruta especificada.
            {
                Console.WriteLine("El archivo que desea buscar, no se encuentra en la ruta especificada.");
                Console.ReadKey();
            }
            catch (FileLoadException) // La excepción se realiza cuando no se puede cargar el archivo deseado.
            {
                Console.WriteLine("No se pudo cargar el archivo deseado.");
                Console.ReadLine();

            }
            finally
            {
                if (vacio != null)
                {
                    vacio.Close(); //se cierra el objeto
                }
            }
        }
    }
}
