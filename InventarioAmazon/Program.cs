using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace InventarioAmazon
{
    class Program
    {
        static void Main(string[] args)
        {
       
            int opcion;

   
            //Menu de Opciones
            do
            {
                Console.Clear();
                Console.WriteLine("\n*** Inventario Amazon ***");
                Console.WriteLine("1.- Ingresa un Nuevo Producto");
                Console.WriteLine("2.- Despliegue De los productos");
                Console.WriteLine("3.- Salida del Programa.");
                Console.Write("\nQue opcion deseas: ");
                opcion = Int16.Parse(Console.ReadLine());

                Producto producto = new Producto();
                switch (opcion)
                {
                    case 1:
                        //Bloque de escritura
                        try
                        {
                            producto.IngresarDatos();
                            Console.WriteLine("Datos Guardados\n\rPrecione <Enter> para regresar al menu principal");
                            Console.ReadKey();
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("\nError : " + e.Message);
                            Console.WriteLine("\nRuta : " + e.StackTrace);
                        }
                        break;
                    case 2:
                        producto.DesplegarDatos();
                        Console.WriteLine("Datos Guardados\n\rPrecione <Enter> para regresar al menu principal");
                        Console.ReadKey();     
                        break;
                    case 3:
                        Console.Write("\nPresione <enter> para Salir del programa.");
                        Console.ReadKey();
                        break;

                    default:
                        Console.Write("\nEsa Opcion No Existe!!, Presione <enter> para Continuar...");
                        Console.ReadKey();
                        break;
                }
            } while (opcion != 3);
        }
    }
}
