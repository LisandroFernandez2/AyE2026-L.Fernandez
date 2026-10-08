using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Arbol
    {
        public GoleadoresMundialNodo Raiz { get; set; }

        public Arbol()
        {
            Raiz = null;
        }
        public void Insertar(GoleadoresMundialNodo nuevo)
        {

            if (Raiz == null)
            {
                Raiz = nuevo;
            }
            else
            {

                InsertarRecursivo(Raiz, nuevo);
            }
        }

        private void InsertarRecursivo(GoleadoresMundialNodo nodoActual, GoleadoresMundialNodo nuevo)
        {

            if (nuevo.id < nodoActual.id)
            {
                if (nodoActual.izquierdo == null)
                {
                    nodoActual.izquierdo = nuevo;
                }
                else
                {
                    InsertarRecursivo(nodoActual.izquierdo, nuevo);
                }
            }

            else if (nuevo.id > nodoActual.id)
            {
                if (nodoActual.derecho == null)
                {
                    nodoActual.derecho = nuevo;
                }
                else
                {
                    InsertarRecursivo(nodoActual.derecho, nuevo);
                }
            }
        }
        public string buscar(int idBuscado)
        {

            if (Raiz == null)
            {
                return "El árbol está vacío.";
            }


            return BuscarRecursivo(Raiz, idBuscado);
        }


        private string BuscarRecursivo(GoleadoresMundialNodo nodoActual, int idBuscado)
        {

            if (nodoActual == null)
            {
                return $"No se encontró ningún Jugador con el ID {idBuscado}.";
            }


            if (idBuscado == nodoActual.id)
            {
                return $"{nodoActual.nombre}";
            }


            if (idBuscado < nodoActual.id)
            {
                return BuscarRecursivo(nodoActual.izquierdo, idBuscado);
            }

            else
            {
                return BuscarRecursivo(nodoActual.derecho, idBuscado);
            }
        }
    }
}
