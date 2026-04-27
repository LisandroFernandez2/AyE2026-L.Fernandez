using System.ComponentModel.Design;
void ejercicioA()
{
    for (int x = 0; x <= 100; x += 3)
    {
        Console.WriteLine(x);
    }
}
ejercicioA();

void ejercicioB()
{
    Console.WriteLine("Ingrese su edad");
    int edad = Convert.ToInt32(Console.ReadLine());
    if (edad > 18)
    {

        Console.WriteLine("Usted es mayor de edad");

    }
    else if (edad < 18)
    {

        Console.WriteLine("Usted es menor de edad");
    }
    else
    {

        Console.WriteLine("Usted tiene exactamente 18 años");


    }

}
ejercicioB();

void ejercicioC()
{
    Console.WriteLine("Escribí una palabra:");
    string palabra = Console.ReadLine();

    int cantidad = palabra.Length;

    Console.WriteLine("La palabra tiene " + cantidad + " letras.");
}
ejercicioC();

void ejercicioD()
{

    int acum = 0;
    Console.WriteLine("Intente adivinar la contraseña, solo tiene 5 intentos");
    string adiv = Console.ReadLine();
    while (acum <= 3 && adiv != "bocajrs")
    {
        acum = acum + 1;
        Console.WriteLine("Intente de vuelta");
        adiv = Console.ReadLine();
    }
    if (adiv != "bocajrs")
    {
        Console.WriteLine("Acceso denegado, no ha logrado adivinar la contraseña secreta");
    }
    else
    {
        Console.WriteLine("Felicidades, ha adivinado la contraseña");
    }
}
ejercicioD();

