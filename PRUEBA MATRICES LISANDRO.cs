using System.Timers;
// profe lo hice lo mas prolijo posible no me bajes puntos por eso porfa (; 
// MATRICES

string[] pokedex;
pokedex = [ "Bulbasaur", "Ivysaur", "Venusaur", "Charmander", "Charmeleon", "Charizard", "Squirtle", "Wartortle", "Blastoise", "Caterpie", "Metapod", "Butterfree", "Weedle", "Kakuna", "Beedrill", "Pidgey", "Pidgeotto", "Pidgeot", "Rattata", "Raticate", "Spearow", "Fearow", "Ekans", "Arbok", "Pikachu", "Raichu", "Sandshrew", "Sandslash", "Nidoran♀", "Nidorina", "Nidoqueen", "Nidoran♂", "Nidorino", "Nidoking", "Clefairy", "Clefable", "Vulpix", "Ninetales", "Jigglypuff", "Wigglytuff", "Zubat", "Golbat", "Oddish", "Gloom", "Vileplume", "Paras", "Parasect", "Venonat", "Venomoth", "Diglett", "Dugtrio", "Meowth", "Persian", "Psyduck", "Golduck", "Mankey", "Primeape", "Growlithe", "Arcanine", "Poliwag", "Poliwhirl", "Poliwrath", "Abra", "Kadabra", "Alakazam", "Machop", "Machoke", "Machamp", "Bellsprout", "Weepinbell", "Victreebel", "Tentacool", "Tentacruel", "Geodude", "Graveler", "Golem", "Ponyta", "Rapidash", "Slowpoke", "Slowbro", "Magnemite", "Magneton", "Farfetch'd", "Doduo", "Dodrio", "Seel", "Dewgong", "Grimer", "Muk", "Shellder", "Cloyster", "Gastly", "Haunter", "Gengar", "Onix", "Drowzee", "Hypno", "Krabby", "Kingler", "Voltorb", "Electrode", "Exeggcute", "Exeggutor", "Cubone", "Marowak", "Hitmonlee", "Hitmonchan", "Lickitung", "Koffing", "Weezing", "Rhyhorn", "Rhydon", "Chansey", "Tangela", "Kangaskhan", "Horsea", "Seadra", "Goldeen", "Seaking", "Staryu", "Starmie", "Mr. Mime", "Scyther", "Jynx", "Electabuzz", "Magmar", "Pinsir", "Tauros", "Magikarp", "Gyarados", "Lapras", "Ditto", "Eevee", "Vaporeon", "Jolteon", "Flareon", "Porygon", "Omanyte", "Omastar", "Kabuto", "Kabutops", "Aerodactyl", "Snorlax", "Articuno", "Zapdos", "Moltres", "Dratini", "Dragonair", "Dragonite", "Mewtwo", "Mew" ];
string[] tipo;
tipo = [ "Grass", "Grass", "Grass", "Fire", "Fire", "Fire", "Water", "Water", "Water", "Bug", "Bug", "Bug", "Bug", "Bug", "Bug", "Normal", "Normal", "Normal", "Normal", "Normal", "Normal", "Normal", "Poison", "Poison", "Electric", "Electric", "Ground", "Ground", "Poison", "Poison", "Poison", "Poison", "Poison", "Poison", "Fairy", "Fairy", "Fire", "Fire", "Normal", "Normal", "Poison", "Poison", "Grass", "Grass", "Grass", "Bug", "Bug", "Bug", "Bug", "Ground", "Ground", "Normal", "Normal", "Water", "Water", "Fighting", "Fighting", "Fire", "Fire", "Water", "Water", "Water", "Psychic", "Psychic", "Psychic", "Fighting", "Fighting", "Fighting", "Grass", "Grass", "Grass", "Water", "Water", "Rock", "Rock", "Rock", "Fire", "Fire", "Water", "Water", "Electric", "Electric", "Normal", "Normal", "Normal", "Water", "Water", "Poison", "Poison", "Water", "Water", "Ghost", "Ghost", "Ghost", "Rock", "Psychic", "Psychic", "Water", "Water", "Electric", "Electric", "Grass", "Grass", "Ground", "Ground", "Fighting", "Fighting", "Normal", "Poison", "Poison", "Ground", "Ground", "Normal", "Grass", "Normal", "Water", "Water", "Water", "Water", "Water", "Water", "Psychic", "Bug", "Ice", "Electric", "Fire", "Bug", "Normal", "Water", "Water", "Water", "Normal", "Normal", "Water", "Electric", "Fire", "Normal", "Rock", "Rock", "Rock", "Rock", "Rock", "Normal", "Ice", "Electric", "Fire", "Dragon", "Dragon", "Dragon", "Psychic", "Psychic" ];
;
string[] numero;
numero = ["50","51","52","53","54","55","56","57","58","59","60","61","62","63","64","65","66","67","68","69","70","71","72","73","74","75","76","77","78","79","80"];
string[,] equipoRed = new string[6, 3];
string[,] equipoGreen = new string[6, 3];
string[,] equipoBlue = new string[6, 3];
string[,] equipoYellow = new string[6, 3];
Random aleatorio = new Random();
// VARIABLES
int numeroaleatoriodepokemon1 = 0;
int numeroaleatoriodepokemon2 = 0;
int numeroaleatoriodepokemon3 = 0;
int numeroaleatoriodepokemon4 = 0;
int numeroaleatoriodepokemon5 = 0;
int numeroaleatoriodepokemon6 = 0;
int numeroaleatoriodepokemon7 = 0;
int numeroaleatoriodepokemon8 = 0;
int rednumero = 0;
int greennumero = 0;
int bluenumero = 0; 
int yellownumero = 0;
int rednumero2 = 0;
int greennumero2 = 0;
int bluenumero2 = 0; 
int yellownumero2 = 0;
int ganadorsemi1 = 0;
int ganadorsemi2 = 0;
string nombredelganador = "";
string nombredelganador2 = "";

void generarmatrices()
{
    for (int i = 0; i < 6; i++)
    {
        for (int x = 0; x < 3; x++)
        {
            numeroaleatoriodepokemon1 = aleatorio.Next(0, 151);
            equipoRed[i, 0] = pokedex[numeroaleatoriodepokemon1];
            equipoRed[i, 1] = tipo[numeroaleatoriodepokemon1];

        }

    }
    for (int i = 0; i < 6; i++)
    {
        for (int x = 0; x < 3; x++)
        {
            numeroaleatoriodepokemon2 = aleatorio.Next(0, 30);
            equipoRed[i, 2] = numero[numeroaleatoriodepokemon2];
        }
    }
    for (int i = 0; i < 6; i++)
    {
        for (int x = 0; x < 3; x++)
        {
            numeroaleatoriodepokemon3 = aleatorio.Next(0, 151);
            equipoGreen[i, 0] = pokedex[numeroaleatoriodepokemon3];
            equipoGreen[i, 1] = tipo[numeroaleatoriodepokemon3];

        }

    }
    for (int i = 0; i < 6; i++)
    {
        for (int x = 0; x < 3; x++)
        {
            numeroaleatoriodepokemon4 = aleatorio.Next(0, 30);
            equipoGreen[i, 2] = numero[numeroaleatoriodepokemon4];
        }
    }
    for (int i = 0; i < 6; i++)
    {
        for (int x = 0; x < 3; x++)
        {
            numeroaleatoriodepokemon5 = aleatorio.Next(0, 151);
            equipoBlue[i, 0] = pokedex[numeroaleatoriodepokemon5];
            equipoBlue[i, 1] = tipo[numeroaleatoriodepokemon5];

        }

    }
    for (int i = 0; i < 6; i++)
    {
        for (int x = 0; x < 3; x++)
        {
            numeroaleatoriodepokemon6 = aleatorio.Next(0, 30);
            equipoBlue[i, 2] = numero[numeroaleatoriodepokemon6];
        }
    }
    for (int i = 0; i < 6; i++)
    {
        for (int x = 0; x < 3; x++)
        {
            numeroaleatoriodepokemon7 = aleatorio.Next(0, 151);
            equipoYellow[i, 0] = pokedex[numeroaleatoriodepokemon7];
            equipoYellow[i, 1] = tipo[numeroaleatoriodepokemon7];

        }

    }
    for (int i = 0; i < 6; i++)
    {
        for (int x = 0; x < 3; x++)
        {
            numeroaleatoriodepokemon8 = aleatorio.Next(0, 30);
            equipoYellow[i, 2] = numero[numeroaleatoriodepokemon8];
        }
    }
}
void convertirdestringaint()
{
    for (int i = 0; i < 6; i++)
    {
        for (int x = 0; x < 3; x++)
        {
            rednumero2 = Convert.ToInt32(equipoRed[i, 2]);
            rednumero = rednumero + rednumero2;
            greennumero2 = Convert.ToInt32(equipoGreen[i, 2]);
            greennumero = greennumero + greennumero2;
            bluenumero2 = Convert.ToInt32(equipoBlue[i, 2]);
            bluenumero = bluenumero + bluenumero2;
            yellownumero2 = Convert.ToInt32(equipoYellow[i, 2]);
            yellownumero = yellownumero + yellownumero2;
        }
    }
}
void mostrarequipos()
{
    Console.WriteLine("- EQUIPO ROJO -");
    for (int i = 0; i < 6; i++)
    {
        for (int x = 0; x < 3; x++)
        {
            Console.Write(equipoRed[i, x]);
            Console.Write(" ");
        }
        Console.WriteLine();
    }
    Console.WriteLine("- EQUIPO AZUL - ");
    for (int i = 0; i < 6; i++)
    {
        for (int x = 0; x < 3; x++)
        {
            Console.Write(equipoBlue[i , x]);
            Console.Write(" ");
        }
        Console.WriteLine();
    }
    Console.WriteLine("- EQUIPO VERDE -");
    for (int i = 0; i < 6; i++)
    {
        for (int x = 0; x < 3; x++)
        {
            Console.Write(equipoGreen[i, x]);
            Console.Write(" ");
        }
        Console.WriteLine();
    }
    Console.WriteLine("- EQUIPO AMARILLO -");
    for (int i = 0; i < 6; i++)
    {
        for (int x = 0; x < 3; x++)
        {
            Console.Write(equipoYellow[i, x]);
            Console.Write(" ");
        }
        Console.WriteLine();
    }
}
void determinarganadortorneo()
{
    if (rednumero > greennumero)
    {
        ganadorsemi1 = rednumero;
        nombredelganador = "Rojo";
        Console.WriteLine("El equipo rojo ha ganado la primer semifinal");
    }
    else
    {
        ganadorsemi1 = greennumero;
        nombredelganador = "Verde";
        Console.WriteLine("El equipo verde ha ganado la primer semifinal");
    }
    if (bluenumero > yellownumero)
    {
        ganadorsemi2 = bluenumero;
        nombredelganador2 = "Azul";
        Console.WriteLine("El equipo azul ha ganado la segunda semifinal");
    }
    else
    {
        ganadorsemi2 = yellownumero;
        nombredelganador2 = "Verde";
        Console.WriteLine("El equipo amarillo ha ganado la segunda semifinal");
    }
    if (ganadorsemi1 > ganadorsemi2)
    {
        Console.WriteLine("El ganador del torneo es el equipo " + nombredelganador);
    }
    else
    {
        Console.WriteLine("El ganador del torneo es el equipo " + nombredelganador2);
    }
}


generarmatrices();
convertirdestringaint();
mostrarequipos();
determinarganadortorneo();


bool mostrarnumeros50al0(int numero)
{
    if (numero == -5)
    {
        return false;
    }
    else
    {
        Console.WriteLine(numero);
        mostrarnumeros50al0(numero - 5);
        return true;
    }



    // PUSE QUE SEA -5 ASI MUESTRA EL 0 EN LA CONSOLA TAMBIEN

}
mostrarnumeros50al0(50);