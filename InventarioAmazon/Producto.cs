using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace InventarioAmazon
{
    class Producto
    {
        public string Nombre,Descripcion;
        public float Precio;
        public int Stock;
     

        public void IngresarDatos()
        {
            Console.Clear();
            Console.Write("Ingrese el Nombre del nuevo producto: ");
            Nombre = Console.ReadLine();
            Console.Write("Ingrese el Precio del nuevo producto: ");
            Precio = float.Parse(Console.ReadLine());
            Console.Write("Ingrese la Cantidad De Stock del nuevo producto: ");
            Stock = int.Parse(Console.ReadLine());
            Console.Write("Ingrese Una BREVE Descripcion del nuevo producto: ");
            Descripcion = Console.ReadLine();


            StreamWriter sw = new StreamWriter("Productos.txt",true);
            sw.WriteLine("Datos Del producto: " + Nombre);
            sw.WriteLine("Nombre del producto: "+Nombre);
            sw.WriteLine("Precio del producto: {0:C}",Precio);
            sw.WriteLine("Cantidad De Stock: "+Stock);
            sw.WriteLine("Descripcion Breve del producto: " +Descripcion+"\r\n\n");
            sw.Close();
        }
        public void DesplegarDatos()
        {
            Console.Clear();
            StreamReader sr = new StreamReader("Productos.txt");   
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
            sr.Close();
       
        }
    }
}
