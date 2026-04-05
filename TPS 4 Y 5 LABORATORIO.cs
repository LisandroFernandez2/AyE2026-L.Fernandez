using System.ComponentModel.Design;

void ejercicio1()
{
    for (int x = 1; x <= 10; x++)
    {
        Console.WriteLine(x);

    }
}
ejercicio1();
void ejercicio2()
{
    for (int y = 1; y <= 5; y++)
    {
        Console.WriteLine("¡Hola mundo!");
    }
}
ejercicio2();
void ejercicio3()

{
    for (int z = 2; z <= 20; z += 2)
    {

        Console.WriteLine(z);


    }
}
ejercicio3();
void ejercicio4()
{
    for (int a = 7; a <= 70; a += 7)
    {
        Console.WriteLine(a);
    }
   
}
ejercicio4();
void ejercicio5()
{
    int sum = 0;
    for (int b = 1; b <= 5; b++)
    {
        sum = sum + b;
        Console.WriteLine(sum);

        
    }
}
ejercicio5();

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

void ejercicio7() { 
    for (int d = 5; d >= 0; d--)
    {
        Console.WriteLine(d);
        
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
