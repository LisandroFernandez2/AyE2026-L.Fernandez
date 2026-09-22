using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Producto
    {
        public string nombre { get; set; }
        public int codigo { get; set; }
        public double precio { get; set; }

        public Producto(string nombre, int codigo, double precio)
        {
            this.precio = precio;
            this.nombre = nombre;
            this.codigo = codigo;
        }
    }
}
