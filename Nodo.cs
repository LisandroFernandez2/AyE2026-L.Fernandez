using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    internal class Nodo
    {
        public Agentes valor { get; set; }
        public Nodo izquierdo { get; set;}
        public Nodo derecho { get; set; }
        public Nodo(Agentes valor,Nodo izquierdo,Nodo derecho)
        {
            this.valor = valor;
            izquierdo = null;
            derecho = null;
        }
    }
}
