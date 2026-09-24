using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace ConsoleApp1
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            using var pokedex = new AppDbContext();
            int decision = 0;
            while (decision != 5)
            {
                Console.WriteLine("¿Que desea hacer?");
                Console.WriteLine("1- Agregar");
                Console.WriteLine("2- Eliminar");
                Console.WriteLine("3- Actualizar");
                Console.WriteLine("4- Consultar");
                Console.WriteLine("5- Finalizar Programa");
                decision = int.Parse(Console.ReadLine());
                switch (decision)
                {
                    case 1:
                        Console.WriteLine("Ingrese el nombre");
                        string nombre = Console.ReadLine();
                        Console.WriteLine("Ingrese el tipo 1");
                        string tipo_1 = Console.ReadLine();
                        Console.WriteLine("Ingrese el tipo 2");
                        string tipo_2 = Console.ReadLine();
                        Console.WriteLine("Ingrese el hp");
                        int hp = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el ataque");
                        int ataque = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese la defensa");
                        int defensa = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el ataque especial");
                        int ataque_especial = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese la defensa especial");
                        int defensa_especial = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese la velocidad");
                        int velocidad = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el nivel");
                        int nivel = int.Parse(Console.ReadLine());
                        var nuevo = new Pokemon
                        (
                            nombre = nombre,
                            tipo_1 = tipo_1,
                            tipo_2 = tipo_2,
                            hp = hp,
                            ataque = ataque,
                            defensa = defensa,
                            ataque_especial = ataque_especial,
                            defensa_especial = defensa_especial,
                            velocidad = velocidad,
                            nivel = nivel 
                        );
                        pokedex.pokedex.Add(nuevo);
                        break;
                }


            }
        }
    }
}
