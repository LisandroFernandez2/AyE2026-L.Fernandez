void segundobloqueA()
{
    Random aleatorio = new Random();
    int numero = aleatorio.Next(0, 11);
    int numeroingresado = 0;
    while (numeroingresado != numero)
    {
        Console.WriteLine("Intente adivinar");
        numeroingresado = int.Parse(Console.ReadLine());
        if (numeroingresado < numero)
        {
            Console.WriteLine("El numero es mas alto");
        }
        else
        {
            Console.WriteLine("El numero es mas bajo");
        }
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
void segundobloqueD()
{
    Console.WriteLine("Elije una operacion, (suma, resta, multiplicacion o divison)");
    string eleccion = Console.ReadLine();
    Console.WriteLine("Ingrese el primer numero");
    double primernumero = int.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese el segundo numero");
    double segundonumero = int.Parse(Console.ReadLine());
    double resultado = 0;
    switch (eleccion)
    {
        case "suma":
            resultado = primernumero + segundonumero;
            break;
        case "resta":
            resultado = primernumero - segundonumero;
            break;
        case "multiplicacion":
            resultado = primernumero * segundonumero;
            break;
        case "division":
            resultado = primernumero / segundonumero;
            break;
    }
    Console.WriteLine("El resultado de la operacion es: " + resultado);
}
segundobloqueD();
