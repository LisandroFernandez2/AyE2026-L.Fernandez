void segundobloqueA()
{
    Random aleatorio = new Random();
    int numero = aleatorio.Next(0, 11);
    int numeroingresado = 0;
    while (numeroingresado != numero)
    {
        Console.WriteLine("Intente adivinar");
        numeroingresado = int.Parse(Console.ReadLine());
    }
    Console.WriteLine("¡Felicidades, usted ha adivinado el numero!");
}
segundobloqueA();
void segundobloqueB()
{
    Console.WriteLine("Ingrese un numero");
    int numeroingresado = int.Parse(Console.ReadLine());
    for (int i = 1; i <= numeroingresado; i++)
    {
        if (numeroingresado % i == 0)
        {
            Console.WriteLine("Divisor encontrado: " + i);
        }
    }
}
segundobloqueB();
