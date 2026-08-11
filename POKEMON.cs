namespace ConsoleApp1
{
    internal class Program
    {
        public struct Pokemon
        {

            // Propiedades

            public string nombre { get; set; }
            public int nivel { get; set; }

            public int ps { get; set; }

            public int ataque { get; set; }

            public int defensa { get; set; }

            public int ae { get; set; }

            public int de { get; set; }

            public int velocidad { get; set; }

            public string estado { get; set; }



            // Constructor
            public Pokemon(string nombre, int nivel, int ps, int ataque, int defensa, int ae, int de, int velocidad, string estado)
            {
                this.nombre = nombre;
                this.nivel = nivel;
                this.ps = ps;
                this.ataque = ataque;
                this.defensa = defensa;
                this.ae = ae;
                this.de = de;
                this.velocidad = velocidad;
                this.estado = estado;
            }
        }

        public struct Entrenador
        {

            // propiedades

            public string nombre { get; set; }
            public int pokedolares { get; set; }
            public string[] medallas { get; set; }
            public Pokemon[] equipo { get; set; }

            //constructor

            public Entrenador(string nombre, int pokedolares, string[] medallas, Pokemon[] equipo)
            {
                this.nombre = nombre;
                this.pokedolares = pokedolares;
                this.medallas = medallas;
                this.equipo = equipo;
            }

            //funciones

            //funcion dame nivel recorre la lista de pokemons y suma todos sus niveles
            public int DameNivel()
            {
                int retorno = 0;
                for (int i = 0; i <= 5; i++)
                {
                    retorno = retorno + equipo[i].nivel;
                }
                return retorno;
            }
        }
        public static string ComprarPocion(Entrenador entrenador1)
        {
            if (entrenador1.pokedolares < 200)
            {
                return "No se pudo comprar";

            }
            else
            {
                entrenador1.pokedolares = entrenador1.pokedolares - 200;
                return "Se compro una pocion le quedan " + entrenador1.pokedolares;
            }
        }
        public static Entrenador CompararMedallas(Entrenador entrenador1, Entrenador entrenador2)
        {
            if (entrenador1.medallas.Length > entrenador2.medallas.Length)
            {
                return entrenador1;
            }
            else
            {
             
                return entrenador2;
            }

        }
        public static Entrenador EntrenadorConMasPokemonsAlterados(Entrenador entrenador1, Entrenador entrenador2)
        {
            Entrenador entrenadoralterado = new Entrenador();
            int contadordealterados1 = 0;
            int contadordealterados2 = 0;
            for (int i = 0; i < 6; i++)
            {
                if (entrenador1.equipo[i].estado == "Alterado")
                {
                    contadordealterados1++;
                }
                if (entrenador2.equipo[i].estado == "Alterado")
                {
                    contadordealterados2++;
                }



            }
            if (contadordealterados1 > contadordealterados2)
            {
                entrenadoralterado = entrenador1;
                return entrenadoralterado;
            }
            else
            {
                entrenadoralterado = entrenador2;
                return entrenadoralterado;
            }



        }

        public static Entrenador AplicarEfectoAlterado(Entrenador entrenador1)
        {
                for (int i = 0; i < entrenador1.equipo.Length; i++)
                {
                    Console.Write(entrenador1.equipo[i].nombre);
                    Console.WriteLine(" " + entrenador1.equipo[i].estado);
                }
                Console.WriteLine("A que pokemon desea aplicarle el efecto alterado");
                int decision = int.Parse(Console.ReadLine());
                Console.WriteLine("¿A que estado alterado desea cambiarlo?");
                string[] EstadosAlterados = new string[6];
                EstadosAlterados = ["Paralizado", "Quemado", "Envenenado", "Gravemente envenenado", "Dormido", "Congelado"];
                for (int i = 0; i < EstadosAlterados.Length; i++)
                {
                    Console.WriteLine(EstadosAlterados[i]);
                }
                 int DesicionAlterado = int.Parse(Console.ReadLine());
                if (entrenador1.equipo[decision].estado != "Normal")
                {
                    Console.WriteLine(entrenador1.equipo[decision].nombre + " " + entrenador1.equipo[decision].ps + " paso de estar " + entrenador1.equipo[decision].estado + " a " + EstadosAlterados[DesicionAlterado]);
                    entrenador1.equipo[decision].estado = EstadosAlterados[DesicionAlterado];
                    return entrenador1;
                }
                else
                {
                    Console.WriteLine(entrenador1.equipo[decision].nombre + " " + entrenador1.equipo[decision].ps + " esta " + entrenador1.equipo[decision].estado);
                    entrenador1.equipo[decision].estado = EstadosAlterados[DesicionAlterado];
                    return entrenador1;
                }

        }

        public static int DeterminarSiPuedeControlar(Entrenador entrenador1)
        {
            int NivelAlQuePuedeControlar = (entrenador1.medallas.Length * 10) + 20;
            int CantidadQuePuedeControlar = 0;
            if (entrenador1.medallas.Length > 0 && NivelAlQuePuedeControlar <= 99)
            {
                for ( int i = 0; i < entrenador1.equipo.Length; i++)
                {
                    if (entrenador1.equipo[i].nivel <= NivelAlQuePuedeControlar)
                    {
                        Console.WriteLine("El entrenador puede controlar a " + entrenador1.equipo[i].nombre + " con un nivel de " + entrenador1.equipo[i].nivel);
                        CantidadQuePuedeControlar++;
                    }
                }
                return entrenador1.equipo.Length - CantidadQuePuedeControlar;
            }
            else if (entrenador1.medallas.Length <= 0)
            {
               return entrenador1.equipo.Length - CantidadQuePuedeControlar;
            }
            return entrenador1.equipo.Length - CantidadQuePuedeControlar;
        }

        public static string DeterminarSiPuedeControlarPokemonIndividual(Entrenador entrenador1)
        {
            int NivelAlQuePuedeControlar = (entrenador1.medallas.Length * 10) + 20;
            for (int i = 0; i < entrenador1.equipo.Length; i++)
            {
                Console.WriteLine(entrenador1.equipo[i].nombre + " " + entrenador1.equipo[i].nivel);
            }
            Console.WriteLine("¿Que pokemon desea saber si puede ser controlado o no?");
            int Decision = int.Parse(Console.ReadLine());
            if (entrenador1.equipo[Decision].nivel < NivelAlQuePuedeControlar)
            {
                return "Si, el entrenador puede controlar a este pokemon";
            }
            else
            {
                return "No, el entrenador no puede controlar a este pokemon";
            }


        }
                static void Main(string[] args)
                {

                    // creo una lista de pokemons
                    Pokemon[] equipo1 = new Pokemon[]
                    {
                        new Pokemon("Pikachu", 150, 150, 90, 55, 110, 50, 90, "Normal"),
                        new Pokemon("Charizard", 55, 180, 84, 78, 109, 85, 100, "Alterado"),
                        new Pokemon("Blastoise", 252, 175, 83, 100, 85, 105, 78, "Normal"),
                        new Pokemon("Venusaur", 351, 170, 82, 83, 100, 100, 80, "Alterado"),
                        new Pokemon("Snorlax", 48, 160, 110, 65, 55, 55, 45, "Normal"),
                        new Pokemon("Gengar", 120, 130, 65, 60, 130, 110, 110, "Normal")
                    };

                    // creo otra lista de pokemons
                    Pokemon[] equipo2 = new Pokemon[]
                     {
                         new Pokemon("Dragonite", 52, 160, 134, 95, 70, 100, 80, "Normal"),
                         new Pokemon("Alakazam", 50, 140, 50, 70, 135, 115, 120, "Normal"),
                         new Pokemon("Gyarados", 49, 200, 130, 60, 95, 85, 65, "Normal"),
                         new Pokemon("Rhydon", 53, 155, 110, 96, 83, 85, 45, "Normal"),
                         new Pokemon("Jolteon", 50, 135, 110, 100, 50, 70, 130, "Normal"),
                         new Pokemon("Starmie", 51, 145, 105, 75, 100, 90, 115, "Normal")
                     };
                    // medallas 1 y 2
                    string[] medallas = new string[8]
                    {
                        "Medalla Roca",
                        "Medalla Cascada",
                        "Medalla Trueno",
                        "Medalla Arcoíris",
                        "Medalla Alma",
                        "Medalla Pantano",
                        "Medalla Volcán",
                        "Medalla Tierra"
                    };
                    string[] medallas2 = new string[4]
                 {
                     "Medalla Roca",
                     "Medalla Cascada",
                     "Medalla Trueno",
                     "Medalla Arcoíris",
                 };

                    Entrenador entrenador1 = new Entrenador("Ash", 500, medallas2, equipo1);
                    Entrenador entrenador2 = new Entrenador("Pepe", 100, medallas, equipo2);


                    // COMPARACION DE NIVEL
                    if (entrenador1.DameNivel() > entrenador2.DameNivel())
                    {
                        Console.WriteLine(entrenador1.nombre + " Tiene mas nivel que: " + entrenador2.nombre);
                    }
                    else if (entrenador2.DameNivel() > entrenador1.DameNivel())
                    {
                        Console.WriteLine(entrenador2.nombre + " Tiene mas nivel que: " + entrenador1.nombre);
                    }
                    else
                    {
                        Console.WriteLine("Tienen el mismo nivel");
                    }
                    // funcion de pocion
                    Console.WriteLine(ComprarPocion(entrenador1));
                    Console.WriteLine(ComprarPocion(entrenador2));
                    // funcion de medallas
                    Entrenador EntrenadorConMasMedallas = CompararMedallas(entrenador1, entrenador2);
                    Console.WriteLine("El entrenador con mas medallas es " + EntrenadorConMasMedallas.nombre + " con una cantidad de " + EntrenadorConMasMedallas.medallas.Length);
                    // funcion de pokemones alterados
                    Entrenador EntrenadorConMasAlterados = EntrenadorConMasPokemonsAlterados(entrenador1, entrenador2);
                    Console.WriteLine("El entrenador con mas pokemones alterados es " + EntrenadorConMasAlterados.nombre);
                    // FUNCION PARA ELEGIR A QUE POKEMON APLICARLE EL ESTADO ALTERADO
                    AplicarEfectoAlterado(entrenador1);
                    //FUNCION PARA DETERMINAR A QUE POKEMONES PUEDE CONTROLAR EL ENTRENADOR
                    Console.WriteLine(DeterminarSiPuedeControlarPokemonIndividual(entrenador1));
                }
    }
}
