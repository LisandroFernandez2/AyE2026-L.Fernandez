using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    internal class Entrenador
    {
        public string nombre { get; set; }
        public int pokedolares { get; set; }
        public Pokemon[] equipo { get; set; }

        public Entrenador(string nombre, int pokedolares, Pokemon[] equipo)
        {
            this.nombre = nombre;
            this.pokedolares = pokedolares;
            this.equipo = equipo;
        }


    }
}
