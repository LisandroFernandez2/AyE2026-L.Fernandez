using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp1
{
    public class Pokemon
    {
        public string nombre { get; set; }
        public string tipo_1 { get; set; }
        public string tipo_2 { get; set; }
        public int hp { get; set; }
        public int ataque { get; set; }
        public int defensa { get; set; }
        public int ataque_especial { get; set; }
        public int defensa_especial { get; set; }
        public int velocidad { get; set; }
        public int nivel { get; set; }


        public Pokemon(string nombre, string tipo_1, string tipo_2, int hp, int ataque,
                       int defensa, int ataque_especial, int defensa_special, int velocidad, int nivel)
        {
            this.nombre = nombre;
            this.tipo_1 = tipo_1;
            this.tipo_2 = tipo_2;
            this.hp = hp;
            this.ataque = ataque;
            this.defensa = defensa;
            this.ataque_especial = ataque_especial;
            this.defensa_especial = defensa_special;
            this.velocidad = velocidad;
            this.nivel = nivel;
        }

    }
}
