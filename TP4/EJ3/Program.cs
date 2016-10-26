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
            //string ruta = @"C:\Users\USER\Source\Repos\TP4-taller\TP4\EJ3\Prueba.txt";
            Console.WriteLine("");
            StreamReader vacio = null;

            try
            {
                StreamReader archivo = new StreamReader(ruta);
                Console.WriteLine(archivo.ReadToEnd());
                Console.ReadKey();
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("No se ingreso ninguna ruta del archivo");
                Console.ReadKey();
            }
            catch (ArgumentException)
            {
                Console.WriteLine("La ruta del archivo ingresada no tiene un formato valido");
                Console.ReadKey();
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("El archivo que desea buscar, no se encuentra en la ruta especificada.");
                Console.ReadKey();
            }
            catch (FileLoadException)
            {
                Console.WriteLine("No se pudo cargar el archivo deseado.");
                Console.ReadLine();

            }
            finally
            {
                if (vacio != null)
                {
                    vacio.Close();
                }
            }
        }
    }
}
