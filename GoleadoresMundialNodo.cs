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
    internal class GoleadoresMundialNodo
    {
        public int id { get; set; }
        public string? nombre { get; set; }
        public string? apellido { get; set; }
        public string? pais { get; set; }
        public string? posicion { get; set; }
        public int? goles { get; set; }
        public int? mundiales_jugados { get; set; }
        public GoleadoresMundialNodo? izquierdo {get; set;}
        public GoleadoresMundialNodo? derecho { get; set; }
    }
}
