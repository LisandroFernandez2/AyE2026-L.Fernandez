using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Arbol
    {
        public Nodo Raiz { get; set; }

        public Arbol()
        {
            Raiz = null;
        }

        public void Insertar(int valor)
        {
            Raiz = insertarRecursivo(Raiz, valor);

        }

        public Nodo insertarRecursivo(Nodo nodoActual, int valor)
        {
            if (nodoActual == null)
            {
                return new Nodo(valor);

            }
            if (valor < nodoActual.Valor)
            {
                nodoActual.Izquierdo = insertarRecursivo(nodoActual.Izquierdo, valor);
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

            if (nodoActual.Valor == valor)
            {
                return true;
            }
            if (valor < nodoActual.Valor)
            {
                return buscarRecursivo(nodoActual.Izquierdo, valor);
            }
            else
            {
                return buscarRecursivo(nodoActual.Derecho, valor);
            }


        }
        public Nodo ObtenerMinimo(Nodo nodoActual)
        {
            while (nodoActual.Izquierdo != null)
            {
                nodoActual = nodoActual.Izquierdo;
            }
            return nodoActual;
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
            int nodoactualIzquierda = ObtenerCantidadNodos(nodoActual.Izquierdo);
            int nodoactualDerecha = ObtenerCantidadNodos(nodoActual.Derecho);

            if (nodoactualDerecha > nodoactualIzquierda)
            {
                return nodoactualDerecha;
            }
            else if(nodoactualIzquierda > nodoactualDerecha)
            {
                return nodoactualIzquierda;
            }
            else
            {
                return nodoactualIzquierda;
            }
        }

        public int ContarHoja(Arbol arbolito)
        {
            return ContarHojas(arbolito.Raiz); 
        }

        
        public int ContarHojas(Nodo actual)
        {
            if (actual == null)
            {
                return 0;
            }

            if (actual.Izquierdo == null && actual.Derecho == null)
            {
                return 1;
            }

            return ContarHojas(actual.Izquierdo) + ContarHojas(actual.Derecho);
        }

        public void Eliminar(int valor)
        {
            Raiz = EliminarRecursivo(Raiz, valor);
        }

        public Nodo EliminarRecursivo(Nodo actual, int valor)
        {
            if (actual == null) return null;

            
            if (valor < actual.Valor)
            {
                actual.Izquierdo = EliminarRecursivo(actual.Izquierdo, valor);
            }
            else if (valor > actual.Valor)
            {
                actual.Derecho = EliminarRecursivo(actual.Derecho, valor);
            }

            else
            {
 
                if (actual.Izquierdo == null) return actual.Derecho;


                if (actual.Derecho == null) return actual.Izquierdo;

                Nodo sucesor = ObtenerMinimo(actual.Derecho);

                actual.Valor = sucesor.Valor;

                actual.Derecho = EliminarRecursivo(actual.Derecho, sucesor.Valor);
            }
            return actual;
        }

        public bool EsValido()
        {
            return EsValidoRecursivo(Raiz, int.MinValue, int.MaxValue);
        }

        public bool EsValidoRecursivo(Nodo actual, int min, int max)
        {
            if (actual == null)
            {
                return true;
            }

            if (actual.Valor <= min || actual.Valor >= max)
            {
                return false;
            }

            return EsValidoRecursivo(actual.Izquierdo, min, actual.Valor) &&
                   EsValidoRecursivo(actual.Derecho, actual.Valor, max);
        }
    }
}
