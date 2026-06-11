
bool seguimos = true;
int opcion = 0;
int num_descartar, cantidad;
string palo, numero;
Random aleatorio = new Random();



string[] posibles_palos = ["Picas", "Corazones", "Treboles", "diamantes"];
string[] posibles_numeros = ["A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K"];
string[,] cartas = new string[8, 2];

while (seguimos)
{
    Console.WriteLine("ingrese que quiere hacer: 1- Pedir Cartas 2-Descartar Cartas 3-Salir");
    opcion = Convert.ToInt32(Console.ReadLine());
    switch (opcion)
    {
        case 1:
            Console.WriteLine("Pidiendo cartas...");
            dar_cartas();
            break;
        case 2:
            Console.WriteLine("Descartando cartas...");
            descartar_cartas();
            break;
        case 3:
            Console.WriteLine("Saliendo...");
            seguimos = false;
            break;
        default:
            Console.WriteLine("numero no valido");
            break;
    }

}

void dar_cartas()
{
    for (int i = 0; i < 8; i++)
    {
        cartas[i, 0] = posibles_palos[aleatorio.Next(0, 4)];   
        cartas[i, 1] = posibles_numeros[aleatorio.Next(0, 13)]; 
    }
    Console.WriteLine("Tus cartas son: ");
    for (int i = 0; i < 8; i++)
    {
        Console.WriteLine((i + 1) + "- " + cartas[i, 1] + " de " + cartas[i, 0]);
    }
}

void descartar_cartas()
{

    Console.WriteLine("ingrese la cantidad de cartas que quiere descartar");
    cantidad = Convert.ToInt32(Console.ReadLine());
    for (int i = 1; i <= cantidad; i++)
    {
        Console.WriteLine("Ingrese el numero de carta que quiere descartar (1 al 8):");
        num_descartar = Convert.ToInt32(Console.ReadLine());

        if (num_descartar >= 1 && num_descartar <= 8)
        {
            int indice = num_descartar - 1; 

            
            cartas[indice, 0] = posibles_palos[aleatorio.Next(0, 4)];
            cartas[indice, 1] = posibles_numeros[aleatorio.Next(0, 13)];

            Console.WriteLine("Tus cartas ahora son: ");
            for (int j = 0; j < 8; j++)
            {
                Console.WriteLine((j + 1) + "- " + cartas[j, 1] + " de " + cartas[j, 0]);
            }
        }
        else
        {
            Console.WriteLine("Numero de carta no valido.");
        }
    }

}


