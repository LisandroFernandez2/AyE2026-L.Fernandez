using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Arbol
    {
        public Nodo Raiz { get; set; }
    
        public Arbol()
        {
            Raiz = null;
        }
    
        public void Insertar(int valor)
        {
            Raiz = insertarRecursivo(Raiz,valor); 

        }
    
        public Nodo insertarRecursivo(Nodo nodoActual, int valor)
        {
            if(nodoActual == null)
            {
                return new Nodo(valor);

            }
            if (valor < nodoActual.Valor)
            {
                nodoActual.Izquierdo = insertarRecursivo(nodoActual.Izquierdo,valor);
            }
            else if (valor > nodoActual.Valor)
            {
                nodoActual.Derecho = insertarRecursivo(nodoActual.Derecho, valor);
            }



            return nodoActual;
        }

        public bool buscar(int valor)
        {



            return buscarRecursivo(Raiz, valor);
        }

        public bool buscarRecursivo(Nodo nodoActual, int valor)
        {
            if (nodoActual == null)
            {
                return false;
            }

            if(nodoActual.Valor == valor)
            {
                return true;
            }
            if(valor < nodoActual.Valor)
            {
                return buscarRecursivo(nodoActual.Izquierdo, valor);
            }
            else
            {
                return buscarRecursivo(nodoActual.Derecho, valor);
            }

            
        }
        public int ObtenerMinimo(Nodo nodoActual)
        { 
            if (nodoActual.Izquierdo == null && nodoActual.Derecho == null)
            {
                return nodoActual.Valor;
            }
            else
            {
                return ObtenerMinimo(nodoActual.Izquierdo);
            }

        }
    
        public int ObtenerMaximo(Nodo nodoActual)
        {
            if (nodoActual.Izquierdo == null && nodoActual.Derecho == null)
            {
                return nodoActual.Valor;
            }
            else
            {
                return ObtenerMaximo(nodoActual.Derecho);
            }

        }
        public int ObtenerCantidadNodos(Nodo nodoActual)
        {
            if (nodoActual == null)
            {
                return 0;
            }
            int nodoactualIzquierda = ObtenerCantidadNodos(nodoActual.Izquierdo);
            int nodoactualDerecha = ObtenerCantidadNodos(nodoActual.Derecho);

            return 1 + nodoactualIzquierda + nodoactualDerecha;


        }
        public int ObtenerAltura(Nodo nodoActual)
        {
            if (nodoActual == null)
            {
                return 0;
            }
            int nodoactual = ObtenerCantidadNodos(nodoActual.Izquierdo);


            return 1 + nodoactual;


        }
    }
}