using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Arbol
    {
        public pokemones Raiz { get; set; }

        public Arbol()
        {
            Raiz = null;
        }
        public string buscar(int idBuscado)
        {
            
            if (Raiz == null)
            {
                return "El árbol está vacío.";
            }

            
            return BuscarRecursivo(Raiz, idBuscado);
        }

       
        private string BuscarRecursivo(pokemones nodoActual, int idBuscado)
        {
            
            if (nodoActual == null)
            {
                return $"No se encontró ningún Pokémon con el ID {idBuscado}.";
            }

            
            if (idBuscado == nodoActual.id)
            {
                return $"Pokémon encontrado: {nodoActual.nombre}";
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




        public void Insertar(pokemones nuevo)
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

            private void InsertarRecursivo(pokemones nodoActual, pokemones nuevo)
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
    }


}

