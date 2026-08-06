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
            public int damenivel()
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
        public static Entrenador CompararMedallas (Entrenador entrenador1, Entrenador entrenador2)
        {
            Entrenador Entrenadormedallas = new Entrenador();
            if (entrenador1.medallas.Length > entrenador2.medallas.Length)
            {
                Entrenadormedallas = entrenador1;
                return Entrenadormedallas;
            }
            else
            {
                Entrenadormedallas = entrenador2;
                return Entrenadormedallas;
            }

        }
        public static Entrenador EntrenadorConMasPokemonsAlterados (Entrenador entrenador1, Entrenador entrenador2)
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
        static void Main(string[] args)
        {

            // creo una lista de pokemons
            Pokemon[] equipo1 = new Pokemon[]
            {
                new Pokemon("Pikachu", 50, 150, 90, 55, 110, 50, 90, "Normal"),
                new Pokemon("Charizard", 55, 180, 84, 78, 109, 85, 100, "Alterado"),
                new Pokemon("Blastoise", 52, 175, 83, 100, 85, 105, 78, "Normal"),
                new Pokemon("Venusaur", 51, 170, 82, 83, 100, 100, 80, "Alterado"),
                new Pokemon("Snorlax", 48, 160, 110, 65, 55, 55, 45, "Normal"),
                new Pokemon("Gengar", 50, 130, 65, 60, 130, 110, 110, "Normal")
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


            // comparacion
            if (entrenador1.damenivel() > entrenador2.damenivel())
            {
                Console.WriteLine(entrenador1.nombre + " Tiene mas nivel que: " + entrenador2.nombre);
            }
            else if (entrenador2.damenivel() > entrenador1.damenivel())
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
        }
    }
}
