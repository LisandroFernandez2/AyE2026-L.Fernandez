using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    internal class Arbol
    {
        public Nodo raiz { get; set; }
        public Arbol()
        {
            raiz = null;
        }
        public void Insertar(Agentes JugadorAInsertar)
        {
            raiz = InsertarRecursivo(JugadorAInsertar,raiz);
        }
        public Nodo InsertarRecursivo(Agentes JugadorAInsertar, Nodo NodoActual)
        {
            if (NodoActual == null)
            {
                Nodo NodoNuevo = new Nodo(JugadorAInsertar, null, null);
                return NodoNuevo;
            }
            if (NodoActual.valor.Id == JugadorAInsertar.Id)
            {
                Console.WriteLine("El id de su jugador ests repetido");
                return NodoActual;
            }
            if (JugadorAInsertar.Id < NodoActual.valor.Id)
            {
                NodoActual.izquierdo = InsertarRecursivo(JugadorAInsertar, NodoActual.izquierdo);
            }
            else if (JugadorAInsertar.Id > NodoActual.valor.Id)
            {
               NodoActual.derecho = InsertarRecursivo(JugadorAInsertar, NodoActual.derecho);
            }
            return NodoActual;
        }
        public void Buscar(int BuscarNumero)
        {
            Nodo NodoActual = raiz;
            BuscarRecursivo(BuscarNumero,NodoActual);
        }
        public void BuscarRecursivo (int BuscarElNumerito, Nodo NodoActual)
        {
            if (NodoActual == null)
            {
                Console.WriteLine("Su agente no existe en la base de datps");
                return;
            }
            if (NodoActual.valor.Id == BuscarElNumerito)
            {
                Console.WriteLine("Encontrado: " + NodoActual.valor.Id + " " + NodoActual.valor.nombre_agente + " " + NodoActual.valor.tipo_agente);
                return;
            }
            if (NodoActual.valor.Id < BuscarElNumerito)
            {
                BuscarRecursivo(BuscarElNumerito, NodoActual.derecho);
            }
            else if (NodoActual.valor.Id > BuscarElNumerito)
            {
                BuscarRecursivo(BuscarElNumerito, NodoActual.izquierdo);
            }
        }
    }
}
