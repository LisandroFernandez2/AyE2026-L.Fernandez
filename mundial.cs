namespace ConsoleApp1
{
    public struct Jugador
    {
        public String Nombre { get; set; }
        public String Apellido { get; set; }

        public int Cant_goles { get; set; }

        public int Cant_disparos_arco { get; set; }

        public int Numero_camiseta { get; set; }

        public string Posicion { get; set; }

        public string[] Equipo { get; set; }

        public Jugador(string nombre, string apellido, int cant_goles, int cant_disparos_arco, int numero_camiseta, string posicion)
        {
            Nombre = nombre;
            Apellido = apellido;
            Cant_goles = cant_goles;
            Cant_disparos_arco = cant_disparos_arco;
            Numero_camiseta = numero_camiseta;
            Posicion = posicion;
            Equipo = new string[10];
        }
    }
    internal class Program
    {
        int indice_ataque = 0;
        double max_indice = 0;
        static void Main(string[] args)
        {
            Jugador[] equipo = new Jugador[10];
            equipo[0] = new Jugador("Kylian", "Mbappé", 8, 33, 10, "Delantero");
            equipo[1] = new Jugador("Lionel", "Messi", 8, 34, 10, "Delantero");
            equipo[2] = new Jugador("Erling", "Haaland", 7, 20, 9, "Delantero");
            equipo[3] = new Jugador("Jude", "Bellingham", 6, 17, 10, "Mediocampista");
            equipo[4] = new Jugador("Harry", "Kane", 6, 19, 9, "Delantero");
            equipo[5] = new Jugador("Mikel", "Oyarzabal", 5, 14, 7, "Delantero");
            equipo[6] = new Jugador("Ousmane", "Dembélé", 5, 18, 11, "Delantero");
            equipo[7] = new Jugador("Vinícius", "Júnior", 4, 15, 7, "Delantero");
            equipo[8] = new Jugador("Julián", "Quiñones", 4, 14, 33, "Delantero");
            equipo[9] = new Jugador("Ismaïla", "Sarr", 4, 12, 18, "Delantero");

            Jugador mejor = Ver_mejor_jugador(equipo);
            double mejor_indice = Generarindiceataque(mejor.Cant_goles, mejor.Cant_disparos_arco);
            Console.WriteLine($"El jugador con mayor indice de ataque es: {mejor.Nombre} {mejor.Apellido} Posicion: {mejor.Posicion} #{mejor.Numero_camiseta} Disparos al arco:{mejor.Cant_disparos_arco} Goles:{mejor.Cant_goles}");
        }
        static double Generarindiceataque(int Cant_goles, int Cant_disparos_arco)
        {
            if (Cant_disparos_arco == 0) { return 0; }
            return ((double)Cant_goles / Cant_disparos_arco) * 100;
        }

        static Jugador Ver_mejor_jugador(Jugador[] equipo)
        {
            Jugador mejor_jugador = equipo[0];
            double max_indice = Generarindiceataque(equipo[0].Cant_goles, equipo[0].Cant_disparos_arco);
            for (int i = 1; i < equipo.Length; i++)
            {
                double indice_Actual = Generarindiceataque(equipo[i].Cant_goles, equipo[i].Cant_disparos_arco);

                if (indice_Actual > max_indice)
                {
                    max_indice = indice_Actual;
                    mejor_jugador = equipo[i];
                }
            }

            return mejor_jugador;
        }
    }
}
