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
void segundobloqueC()
{
    bool sigue = true;
    int segundotermino = 1;
    int resultado = 0;
    int primertermino = 0;
    while (resultado < 4181)
    {
        resultado = primertermino + segundotermino;
        Console.WriteLine(resultado);
        primertermino = segundotermino;
        segundotermino = resultado;

    }

}
segundobloqueC();
