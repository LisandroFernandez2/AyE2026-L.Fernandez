void ejercicio6() {
    string c = "hola123";
    Console.WriteLine("Ingrese la contraseña");
    string adiv = Console.ReadLine();
    while (adiv != c)
    {
        Console.WriteLine("Contraseña incorrecta, porfavor intente de nuevo");
        adiv = Console.ReadLine();

    }
    Console.WriteLine("Entrando");
}
ejercicio6();

void ejercicio7()
{
    int x = 5;
    int acum = 6;
    while (x > 0)
    {
        x = x - 1;
        acum = acum - 1;
        Console.WriteLine(acum);
    }
    Console.WriteLine("¡Listo para despegar!");
    Console.WriteLine("¡Despegue!");
}
ejercicio7();

void ejercicio8()
{
    int secret = 7;

    Console.WriteLine("Adivina el numero del 1-10");
    int adiv = Convert.ToInt32(Console.ReadLine());
    while (adiv != secret)
    {
        Console.WriteLine("Incorrecto, tira otro numero");
        adiv = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine("Adivinaste el numero");

}
ejercicio8();

void ejercicio9 ()
{
    int numero = 1;
    int suma = 0;
    while (numero != 0)
    {
        Console.WriteLine("Ingrese un numero (Ingrese 0 para finalizar) ");
        numero = Convert.ToInt32(Console.ReadLine());

        suma = suma + numero;
    }
    Console.WriteLine("La suma total de los numeros ingresados es " + suma);
}
ejercicio9();
