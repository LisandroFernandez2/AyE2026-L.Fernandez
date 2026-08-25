using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Perro
    {
        int edad { get; set; }
        string dueño { get; set; }
        string raza { get; set; }

        public Perro(int edad,string dueño, string raza)
        {
            this.edad = edad;
            this.dueño = dueño;
            this.raza = raza;
        }
 
    } 
}
