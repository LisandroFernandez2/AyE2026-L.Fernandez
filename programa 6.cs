int[,] matriztesoro = new int[10, 10];
int numerorandom = 0;
int contadordeunos = 0;
int intentos = 5;
int cantidadtesoros = 3;
// For que genera el mapa del tesoro
for (int i = 0; i < 10; i++)
{
    for (int x = 0; x < 10; x++)
    {
        Random aleatorio = new Random();
        numerorandom = aleatorio.Next(0, 20);

        if (numerorandom == 1)
        {
            matriztesoro[i, x] = 1;
            contadordeunos++;
            if (contadordeunos > 3)
            {
                matriztesoro[i, x] = 0;
            }
        }
    }
}
    for (int i = 0; i < 10; i++)
    {

        for (int x = 0; x < 10; x++)
        {

            Console.Write(matriztesoro[i, x]);

        }
        Console.WriteLine();
    }
    
while (intentos > 0)
{
    Console.WriteLine("Elija una fila");
    int eleccionfila = int.Parse(Console.ReadLine());
    Console.WriteLine("Elija una columna");
    int eleccioncolumna = int.Parse(Console.ReadLine());
    if (matriztesoro[eleccionfila, eleccioncolumna] == 1)
    {
        matriztesoro[eleccionfila, eleccioncolumna] = 2;
    }
    for (int f = 0; f < 10; f++)
    {
        for (int c = 0; c < 10; c++)
        {
            if (matriztesoro[f, c] == 2)
            {
                Console.Write("O");
            }
            else
            {
                Console.Write("X");
            }

        }
        Console.WriteLine();
    }
    if (matriztesoro[eleccionfila, eleccioncolumna] == 1)
    {

        cantidadtesoros--;
        intentos = 5;
        Console.WriteLine("¡Felicidades, usted ha encontrado un tesoro!, Le quedan por encontrar: " + cantidadtesoros);
    }
    else if (matriztesoro[eleccionfila, eleccioncolumna] == 0)
    {
        intentos--;
        Console.WriteLine("No ha encontrado un tesoro, le quedan " + intentos + " intentos.");

    }
    if (cantidadtesoros == 0)
    {
        Console.WriteLine("Ya ha encontrado todos los tesoros, Felicidades: ¡Ha ganado!");
        intentos = 0;
    }
    if (intentos == 0)
    {
        Console.WriteLine("Usted se ha quedado sin intentos ):");
    }
}
