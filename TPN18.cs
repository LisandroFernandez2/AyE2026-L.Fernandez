using System.Reflection.Metadata;
using System.Runtime.InteropServices;

namespace ConsoleApp2
{
    internal class Program
    {
        public struct Punto2D
        {
            public int X { get; set; }
            public int Y { get; set; }

            public Punto2D(int x, int y)
            {
                X = x;
                Y = y;
            }
            public void Mostrar()
            {
                Console.WriteLine($"{X} {Y}");



            }
        }
        public struct Dimensiones
        {
        public int Ancho { get; set; }
        public int Alto { get; set; }


        public Dimensiones(int ancho, int alto){
        Ancho = ancho;
        Alto = alto;
          }
        }
            static void Main(string[] args)
            {
                Punto2D punto = new Punto2D(5, 10);
                punto.Mostrar();
                Dimensiones d1 = new Dimensiones(10, 20);
                Dimensiones d2 = d1;
                d2.Ancho = 99;
                Console.WriteLine($"VALORES DE D1: {d1.Ancho},{d1.Alto}");
                Console.WriteLine($"VALORES DE D2: {d2.Ancho},{d2.Alto}");
                // Porque el sistema crea un nuevo espacio de memoria completamente nuevo para d2, sin modificar d1. Le pregunte a la IA xdxdxdxd
            }

        
    }
}
namespace ConsoleApp1
{
    internal class Program
    {
        public struct Producto
        {
            public string Nombre { get; set; }
            public int Codigo { get; set; }
            public double Precio { get; set; }
        public Producto(string n, int c, double p)
            {
                Nombre = n;
                Codigo = c;
                Precio = p;
            }


            static void Main(string[] args)
            {
                Producto[] inventario = new Producto[3];
                inventario[0] = new Producto("Tomate",2569,25.55);
                inventario[1] = new Producto("Atun", 2456, 5.67);
                inventario[2] = new Producto("Polenta", 1111, 3.20);
                int acum = 0;
                foreach (var prod in inventario)
                {

                    Console.WriteLine($"Producto: {prod.Nombre}  Código: {prod.Codigo}  Precio: ${prod.Precio}");
                }
                
            }
        }
    }
}
