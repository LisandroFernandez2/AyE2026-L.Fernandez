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
            static void Main(string[] args)
            {
                Punto2D punto = new Punto2D(5, 10);
                punto.Mostrar();
            }

        
    }
}