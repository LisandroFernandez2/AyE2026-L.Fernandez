using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Personaje
    {
      public int VidaTotal { get; set; }
      public int VidaActual { get; set; }
      public string UltimaAccion { get; set; }
            
        public Personaje(int VidaTotal, int VidaActual,string UltimaAccion)
        {
            this.VidaTotal = VidaTotal;
            this.VidaActual = VidaActual;
            this.UltimaAccion = UltimaAccion;
        }
    }

}
