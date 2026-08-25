using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    internal class Pokemon
    {
        public string nombre { get; set; }
        public int nivel { get; set; }

        public int ps { get; set; }
        public int psa { get; set; }

        public int ataque { get; set; }

        public int defensa { get; set; }

        public int ae { get; set; }

        public int de { get; set; }

        public int velocidad { get; set; }
        public Sprite frente { get; set; }
        public Sprite detras { get; set; }

        // Constructor
        public Pokemon(string nombre, int nivel, int ps, int psa, int ataque, int defensa, int ae, int de, int velocidad, Sprite frente, Sprite detras)
        {
            this.nombre = nombre;
            this.nivel = nivel;
            this.ps = ps;
            this.psa = psa;
            this.ataque = ataque;
            this.defensa = defensa;
            this.ae = ae;
            this.de = de;
            this.velocidad = velocidad;
            this.frente = frente;
            this.detras = detras;
        }



    }
}
