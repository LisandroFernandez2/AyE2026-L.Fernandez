using System;
using System.IO;
using System.Runtime.Intrinsics.X86;
using System.Text.Json;
using ConsoleApp1;
using Microsoft.EntityFrameworkCore;
using Prueba_Base_de_Datos;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace ConsoleApp2
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            using var pokedex = new AppDbContext();

            Pokemon[] Lista = await pokedex.pokemon.ToArrayAsync();
            var opciones = new JsonSerializerOptions
            {
                WriteIndented = true
            };

            string jsonTexto = JsonSerializer.Serialize(Lista, opciones);
            string rutaArchivo = "pokemones.json";
            File.WriteAllText(rutaArchivo, jsonTexto);
            if (File.Exists(rutaArchivo))
            {
                string contenidoJson = File.ReadAllText(rutaArchivo);

                var opciones2 = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                };

                List<Pokemon>? pokemones = JsonSerializer.Deserialize<List<Pokemon>>(contenidoJson, opciones2);
                if (pokemones != null)
                {
                    foreach (var p in pokemones)
                    {
                        Console.WriteLine("Nombre: " + p.nombre);
                        Console.WriteLine("Tipo 1: " + p.tipo_1);
                        Console.WriteLine("Tipo 2: " + p.tipo_2);
                        Console.WriteLine("Hp: " + p.hp);
                        Console.WriteLine("Ataque: " + p.ataque);
                        Console.WriteLine("Defensa: " + p.defensa);
                        Console.WriteLine("Ataque especial: " + p.ataque_especial);
                        Console.WriteLine("Defensa especial: " + p.defensa_especial);
                        Console.WriteLine("Velocidad: " + p.velocidad);
                        Console.WriteLine("Nivel: " + p.nivel);
                    }
                }
            }
        }
    }
}
