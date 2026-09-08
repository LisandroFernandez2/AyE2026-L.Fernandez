using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Tarea
    {
        public int Id { get; }
        public string Titulo { get; }
        public string Prioridad { get; }
        public int EstimacionMinutos { get; }

        public Tarea(int id, string titulo, string prioridad, int estimacionMinutos)
        {
            Id = id;
            Titulo = titulo;
            Prioridad = prioridad;
            EstimacionMinutos = estimacionMinutos;
        }

    }
}
