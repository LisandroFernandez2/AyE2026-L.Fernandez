
using Prueba_Base_de_Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp2;
using Microsoft.EntityFrameworkCore;
namespace ConsoleApp2
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            // le pongo el nombre de la base de datos para no perderme
            using var cia = new AppDbContext();
            // AGREGSR
            var Agente = new Agentes
            {
                nombre_agente = "Lisandro",
                tipo_agente = "Espia",
                nacionalidad = "Argentino",
                fecha_lanzamiento = "8 de Julio"


            };
            cia.agentes_valorant.Add(Agente);
            await cia.SaveChangesAsync();
            // ELIMINSR
            int IdAgenteEliminar = 6;

            var AgenteEliminar = await cia.agentes_valorant.FindAsync(IdAgenteEliminar);

            if (AgenteEliminar != null)
            {
                cia.agentes_valorant.Remove(AgenteEliminar);
                await cia.SaveChangesAsync();
            }
            // ACTUALIZAR
            int IdAgente = 2;
            // uso findasync para encontrar el dato con id 2
            var AgenteActualizar = await cia.agentes_valorant.FindAsync(IdAgente);

            if (AgenteActualizar != null)
            {
               // si no esta vacio, le cambio el nombre a satanas
                AgenteActualizar.nombre_agente = "Satanas";
                await cia.SaveChangesAsync();
            }
            // CONSULTAR
            var todos = await cia.agentes_valorant.ToListAsync();
            Console.WriteLine("TODOS LOS DATOS:");
            foreach (var i in todos)
            {
                Console.WriteLine(i.Id + " " + i.nombre_agente + " " + i.tipo_agente);
            };
            Console.WriteLine("--------------------------------------");
            // INSERTO EN EL ARBOL ANTES DE BUSCAR
            Arbol elarbolito = new Arbol();
           //  uso la lista todos que cree antes
            foreach (var i in todos)
            {
                elarbolito.Insertar(i);
            }
            // BUSCAR EN EL ARBOL
            int IdABuscar = 8;
            elarbolito.Buscar(IdABuscar);
            // creo una lista
            Agentes[] Lista = await cia.agentes_valorant.ToArrayAsync();
            Console.WriteLine("Nombres de la lista sin ordenar: ");
            foreach (Agentes i in Lista)
            {
                // lo muestro para ver si anda
                Console.WriteLine(i.nombre_agente);
            }
            // ORDENAMIENTO BURBUJA
            void OrdenarEnOrdenAlfabetico(Agentes[] LaListita)
            {
                for (int i = 0; i < LaListita.Length - 1; i++)
                {
                    for (int x = 0; x < LaListita.Length - 1; x++)
                    {
                        string NombreActual = LaListita[x].nombre_agente;
                        string NombreMasUno = LaListita[x + 1].nombre_agente;
                        if (NombreActual.CompareTo(NombreMasUno) > 0)
                        {
                            Agentes Aux = LaListita[x];
                            LaListita[x] = LaListita[x + 1];
                            LaListita[x + 1] = Aux;
                        }
                    }
                }
                Console.WriteLine("Nombres en orden: ");
                foreach (var nombre in LaListita)
                {
                    Console.WriteLine(nombre.nombre_agente);
                }
            }
            OrdenarEnOrdenAlfabetico(Lista);
        }
    }
}
