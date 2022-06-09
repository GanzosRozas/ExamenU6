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
     
        public Producto(string Nombre,string Descripcion, float Precio,int Stock)
        {
            this.Nombre = Nombre;
            this.Descripcion = Descripcion;
            this.Precio = Precio;
            this.Stock = Stock;
        }
        public Producto()
        {

        }
        public void IngresarDatos()
        {
            StreamWriter sw = new StreamWriter("Productos.txt",true);
            sw.WriteLine("Datos Del producto: " + Nombre);
            sw.WriteLine(Nombre);
            sw.WriteLine("{0:C}",Precio);
            sw.WriteLine(Stock);
            sw.WriteLine(Descripcion+"\r\n\n");
            sw.Close();
        }
        public void DesplegarDatos()
        {
            StreamReader sr = new StreamReader("Productos.txt");
            sr.ReadToEnd();
        }
    }
}
