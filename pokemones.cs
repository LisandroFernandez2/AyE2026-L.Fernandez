using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp1
{
    internal class pokemones
    {
        public int id { get; set; }


        public string? nombre { get; set; }
        public string? tipo_1 { get; set; }
        public string? tipo_2 { get; set; }
        public int hp { get; set; }
        public int ataque { get; set; }
        public int defensa { get; set; }
        public int ataque_especial { get; set; }
        public int defensa_especial { get; set; }
        public int velocidad { get; set; }
        public int nivel { get; set; }


        public pokemones? izquierdo { get; set; }
        public pokemones? derecho { get; set; }
    }
}
