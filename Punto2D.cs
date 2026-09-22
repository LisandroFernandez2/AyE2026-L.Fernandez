using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Punto2D
    {
        public int x { get; set; }
        public int y { get; set; }

        public Punto2D(int x, int y)
        {
            this.y = y;
            this.x = x;
        }
        public void Mostrar()
        {
            Console.WriteLine(x + " " + y);
        }
    }
}
