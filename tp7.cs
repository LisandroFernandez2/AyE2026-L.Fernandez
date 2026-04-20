void ejercicio1() {
Console.WriteLine("Ingresa un número entero:");
int num = Convert.ToInt32(Console.ReadLine());

bool Primo = true;

if (num < 2)
{
    Primo = false;
}
else
{
   
    for (int i = 2; i < num; i++)
    {
        if (num % i == 0)
        {
            Primo = false;
            break;
        }
    }
}

if (Primo)
{
    Console.WriteLine(num + " es primo");
}
else
{
    Console.WriteLine(num + " no es primo");
}
    }
ejercicio1();

void ejercicio2()
{
    Console.WriteLine("Ingresa un número entero no negativo:");
    int num = Convert.ToInt32(Console.ReadLine());

    int factorial = 1; 

    if (num < 0)
    {
        Console.WriteLine("Error: El número es negativo.");
    }
    else
    {
        for (int i = 1; i <= num; i++)
        {
            factorial = factorial * i;
        }
        Console.WriteLine("El factorial de " + num + " es " + factorial);
    }
}
ejercicio2();

void ejercicio3()
{
    Console.WriteLine("cuantos numeros de Fibonacci queres ver");
    int n = Convert.ToInt32(Console.ReadLine());

    int a = 0;
    int b = 1;

    for (int i = 0; i < n; i++)
    {
        Console.WriteLine(a);

        int siguiente = a + b;
        a = b;
        b = siguiente;
    }
} 
ejercicio3();

void ejercicio4()
{
    int opcion = 0;

    while (opcion != 3)
    {
        Console.WriteLine("Seleccione 1 para que la consola diga hola, dos para que la consola diga chau y 3 para finalizar el programa");
        opcion = Convert.ToInt32(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                Console.WriteLine("hola");
                break;

            case 2:
                Console.WriteLine("chau");
                break;

            case 3:
                break;


        }
    }
}
ejercicio4();