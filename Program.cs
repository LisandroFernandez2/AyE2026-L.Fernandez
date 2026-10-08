using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace ConsoleApp1
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            using var Mundial = new AppDbContext();
            int decision = 0;
            while (decision != 8)
            {
                Console.WriteLine("¿Que desea hacer?");
                Console.WriteLine("1- Agregar");
                Console.WriteLine("2- Eliminar");
                Console.WriteLine("3- Actualizar");
                Console.WriteLine("4- Consultar");
                Console.WriteLine("5- Buscar en el arbol");
                Console.WriteLine("6- Ordenamiento burbuja por orden alfabetico");
                Console.WriteLine("7- Ordenamiento burbuja por cantidad de mundiales jugados");
                Console.WriteLine("8- Finalizar programa");
                decision = int.Parse(Console.ReadLine());
                switch (decision)
                {
                    case 1:
                        Console.WriteLine("Ingrese el nombre");
                        string nombreing = Console.ReadLine();
                        Console.WriteLine("Ingrese apellido");
                        string apellidoing = Console.ReadLine();
                        Console.WriteLine("Ingrese el pais");
                        string paising = Console.ReadLine();
                        Console.WriteLine("Ingrese la posicion");
                        string posicioning = Console.ReadLine();
                        Console.WriteLine("Ingrese los goles");
                        int golesing = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese los mundiales jugados");
                        int mundialesjugadosing = int.Parse(Console.ReadLine());
                        var nuevoing = new GoleadoresMundialBD
                        {
                            nombre = nombreing,
                            apellido = apellidoing,
                            pais = paising,
                            posicion = posicioning,
                            goles = golesing,
                            mundiales_jugados = mundialesjugadosing
                        };
                        Mundial.Goleadores_Mundial.Add(nuevoing);
                        await Mundial.SaveChangesAsync();
                        break;
                    case 2:
                        Console.WriteLine("Ingrese el id del dato que desea eliminar");
                        int id = int.Parse(Console.ReadLine());
                        var datoBuscado = await Mundial.Goleadores_Mundial.FindAsync(id);
                        if (datoBuscado != null)
                        {
                            Mundial.Goleadores_Mundial.Remove(datoBuscado);
                            await Mundial.SaveChangesAsync();
                        }
                        break;
                    case 3:
                        int modificar = 0;
                        string modificars = "";
                        Console.WriteLine("Ingrese el id del dato que desea modificar");
                        int id2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("¿Que desea modificar?");
                        Console.WriteLine("1- Nombre");
                        Console.WriteLine("2- Apellido");
                        Console.WriteLine("3- Pais");
                        Console.WriteLine("4- Posicion");
                        Console.WriteLine("5- Goles");
                        Console.WriteLine("6- Mundiales jugados");
                        int decision2 = int.Parse(Console.ReadLine());
                        if (decision2 == 5 || decision2 == 6)
                        {
                            modificar = int.Parse(Console.ReadLine());
                        }
                        else
                        {
                            modificars = Console.ReadLine();
                        }
                        var datoBuscado2 = await Mundial.Goleadores_Mundial.FindAsync(id2);
                        if (datoBuscado2 != null)
                        {
                            switch (decision2)
                            {
                                case 1:
                                    datoBuscado2.nombre = modificars;
                                    break;
                                case 2:
                                    datoBuscado2.apellido = modificars;
                                    break;
                                case 3:
                                    datoBuscado2.pais = modificars;
                                    break;
                                case 4:
                                    datoBuscado2.posicion = modificars;
                                    break;
                                case 5:
                                    datoBuscado2.goles = modificar;
                                    break;
                                case 6:
                                    datoBuscado2.mundiales_jugados = modificar;
                                    break;
                            }

                            await Mundial.SaveChangesAsync();
                        }
                        break;
                    case 4:
                        var todos = await Mundial.Goleadores_Mundial.ToListAsync();
                        foreach (var e in todos)
                        {
                            Console.WriteLine(" ID: " + e.Id);
                            Console.Write(" NOMBRE: " + e.nombre);
                            Console.Write(" APELLIDO: " + e.apellido);
                            Console.Write(" PAIS: " + e.pais);
                            Console.Write(" POSICION: " + e.posicion);
                            Console.Write(" GOLES: " + e.goles);
                            Console.Write(" MUNDIALES JUGADOS: " + e.mundiales_jugados);
                            GoleadoresMundialBD pokemon = new GoleadoresMundialBD();
                            pokemon = e;
                        }
                        break;
                    case 5:
                        var todos2 = await Mundial.Goleadores_Mundial.ToListAsync();
                        Arbol Arbolito = new Arbol();

                        foreach (var e in todos2)
                        {

                            GoleadoresMundialNodo nuevoGoleador = new GoleadoresMundialNodo();
                            nuevoGoleador.id = e.Id;
                            nuevoGoleador.nombre = e.nombre;
                            nuevoGoleador.apellido = e.apellido;
                            nuevoGoleador.pais = e.pais;
                            nuevoGoleador.posicion = e.posicion;
                            nuevoGoleador.goles = e.goles;
                            nuevoGoleador.mundiales_jugados = e.mundiales_jugados;

                            Arbolito.Insertar(nuevoGoleador);
                        }

                        Console.WriteLine("Ingresa el id del jugador que desea buscar");
                        int Buscar = int.Parse(Console.ReadLine());
                        var encontrado = Arbolito.buscar(Buscar);
                        if (encontrado != null)
                        {
                            Console.WriteLine($"Encontrado: {encontrado}");
                        }
                        else
                        {
                            Console.WriteLine("Jugador con ID 5 no encontrado en el árbol.");
                        }



                        break;
                    default:
                        Console.WriteLine("Ingrese un numero valido");
                        break;
                    case 6:

                        static void OrdenarPorOrdenAlfabetico(List<GoleadoresMundialBD> lista)
                        {
                            int n = lista.Count;
                            for (int i = 0; i < n - 1; i++)
                            {
                                for (int j = 0; j < n - i - 1; j++)
                                {
                                    int comparacion = string.Compare(lista[j].apellido, lista[j + 1].apellido, StringComparison.OrdinalIgnoreCase);

                                    if (comparacion == 0)
                                    {
                                        comparacion = string.Compare(lista[j].nombre, lista[j + 1].nombre, StringComparison.OrdinalIgnoreCase);
                                    }
                                    if (comparacion > 0)
                                    {
                                        var temp = lista[j];
                                        lista[j] = lista[j + 1];
                                        lista[j + 1] = temp;
                                    }
                                }
                            }
                        }
                        var listaAlfabetico = await Mundial.Goleadores_Mundial.ToListAsync();
                        OrdenarPorOrdenAlfabetico(listaAlfabetico);
                        MostrarLista(listaAlfabetico);

                        break;
                    case 7:
                        static void OrdenarPorMundialesJugados(List<GoleadoresMundialBD> lista)
                        {
                            int n = lista.Count;
                            for (int i = 0; i < n - 1; i++)
                            {
                                for (int j = 0; j < n - i - 1; j++)
                                {
                                    
                                    if (lista[j].mundiales_jugados < lista[j + 1].mundiales_jugados)
                                    {
                                        var temp = lista[j];
                                        lista[j] = lista[j + 1];
                                        lista[j + 1] = temp;
                                    }
                                }
                            }
                        }
                        var listaMundiales = await Mundial.Goleadores_Mundial.ToListAsync();
                        OrdenarPorMundialesJugados(listaMundiales);
                        MostrarLista(listaMundiales);
                        break;
                }

                static void MostrarLista(List<GoleadoresMundialBD> lista)
                {
                    foreach (var e in lista)
                    {
                        Console.WriteLine($"ID: {e.Id} | {e.apellido}, {e.nombre} | País: {e.pais} | Goles: {e.goles} | Mundiales: {e.mundiales_jugados}");
                    }
                }
            }
        }
    }
}
